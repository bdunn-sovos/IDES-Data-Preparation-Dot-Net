using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Linq;
using Properties;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var year = DateTime.Now.Year;
            for (var i = 2014; i <= year; i++)
            {
                cbTaxYear.Items.Add(i.ToString());
            }
            year--;
            cbTaxYear.Text = year.ToString();
        }

        private void btnBrowseXml_Click(object sender, EventArgs e)
        {
            txtXmlFile.Text = dlgOpen.ShowDialogWithFilter("XML Files (*.xml)|*.xml");
        }

        private void btnBrowseCert_Click(object sender, EventArgs e)
        {
            txtCert.Text = dlgOpen.ShowDialogWithFilter("Signing Certificates (*.pfx, *.p12)|*.pfx;*.p12");
        }

        private void btnBrowseKeyCert_Click(object sender, EventArgs e)
        {
            txtKeyCert.Text = dlgOpen.ShowDialogWithFilter("Certificate Files (*.cer, *.pfx, *.p12)|*.cer;*.pfx;*.p12");
        }

        private void btnSignXML_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtXmlFile.Text))
            {
                MessageBox.Show(Resources.XmlFileFieldNotFilled, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCert.Text))
            {
                MessageBox.Show(Resources.SigningCertFieldNotFilled, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCertPass.Text))
            {
                MessageBox.Show(Resources.SigningCertPasswordFieldNotFilled, Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKeyCert.Text))
            {
                MessageBox.Show(Resources.EncryptionCertFieldNotFilled, Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var secondary = !string.IsNullOrWhiteSpace(txtKeyCert2.Text);
            if (secondary)
            {
                if (string.IsNullOrWhiteSpace(txtKeyCertGIIN.Text))
                {
                    MessageBox.Show(Resources.SecondaryReceiverFieldNotFilled, Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                // load XML file content
                var xmlContent = File.ReadAllBytes(txtXmlFile.Text);
                var senderGiin = Path.GetFileNameWithoutExtension(txtXmlFile.Text);
                var filePath = Path.GetDirectoryName(txtXmlFile.Text);

                // perform sign
                var envelopingSignature = XmlManager.Sign(XmlSignatureType.Enveloping, xmlContent, txtCert.Text,
                    txtCertPass.Text);

                var envelopingFileName = filePath + "\\" + senderGiin + "_Payload.xml";
                var zipFileName = envelopingFileName.Replace(".xml", ".zip");

                // save enveloping version to disk
                File.WriteAllBytes(envelopingFileName, envelopingSignature);

                // add enveloping signature to ZIP file
                ZipManager.CreateArchive(envelopingFileName, zipFileName);

                // generate AES key (32 bytes) & default initialization vector (empty)
                var aesEncryptionKey = AesManager.GenerateRandomKey(AesManager.KeySize/8);
                var aesEncryptionVector = AesManager.GenerateRandomKey(16, radECB.Checked);

                // encrypt file & save to disk
                var encryptedFileName = zipFileName.Replace(".zip", string.Empty);
                var encryptedFileName2 = encryptedFileName;
                var payloadFileName = encryptedFileName;
                AesManager.EncryptFile(zipFileName, encryptedFileName, aesEncryptionKey, aesEncryptionVector,
                    radECB.Checked);

                // encrypt key with public key of certificate & save to disk
                // System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                //aesEncryptionKey = encoding.GetBytes("test");

                //  Byte[] bytes = System.Text.Encoder.GetBytes("some test data");
                encryptedFileName = Path.GetDirectoryName(zipFileName) + "\\000000.00000.TA.840_Key";
                AesManager.EncryptAesKey(aesEncryptionKey, aesEncryptionVector, txtKeyCert.Text, txtKeyCertPassword.Text,
                    encryptedFileName, radECB.Checked);

                if (secondary)
                {
                    encryptedFileName2 = Path.GetDirectoryName(zipFileName) + "\\" + txtKeyCertGIIN.Text + "_Key";
                    AesManager.EncryptAesKey(aesEncryptionKey, aesEncryptionVector, txtKeyCert2.Text, null,
                        encryptedFileName2, radECB.Checked);
                }

                // cleanup
                envelopingSignature = null;
                aesEncryptionKey = aesEncryptionVector = null;

                //Start creating XML metadata
                XmlWriter writer = null;
                var fileCreationDateTime = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ssZ");
                var senderFile = DateTime.UtcNow.ToString("yyyyMMddTHHmmssfffZ") + "_" + senderGiin;

                try
                {
                    // Create an XmlWriterSettings object with the correct options. 
                    var settings = new XmlWriterSettings
                    {
                        Indent = true,
                        IndentChars = ("\t"),
                        OmitXmlDeclaration = false,
                        NewLineHandling = NewLineHandling.Replace,
                        CloseOutput = true
                    };

                    var metadataFileName = filePath + "\\" + senderGiin + "_Metadata.xml";

                    // Create the XmlWriter object and write some content.
                    writer = XmlWriter.Create(metadataFileName, settings);
                    writer.WriteStartElement("FATCAIDESSenderFileMetadata", "urn:fatca:idessenderfilemetadata");
                    writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
                    writer.WriteStartElement("FATCAEntitySenderId");
                    writer.WriteString(senderGiin);
                    writer.WriteEndElement();
                    writer.WriteStartElement("FATCAEntityReceiverId");
                    writer.WriteString("000000.00000.TA.840");
                    /*
                     * Not entirely sure why this was added but we are having problems sending Singapore. It is setting FATCAEntityReceiverId to Singapore giin and that doesn't work
                    if (Secondary)
                    {
                        writer.WriteString(txtKeyCertGIIN.Text);
                    }
                    else
                    {
                        writer.WriteString("000000.00000.TA.840");
                    }*/
                    writer.WriteEndElement();
                    /*not sure if needed, can't find any instructions
                                        if (Secondary)
                                        {
                                            writer.WriteStartElement("HCTAFATCAEntityId");
                                            writer.WriteString(txtKeyCertGIIN.Text);
                                            writer.WriteEndElement();
                                        }*/
                    writer.WriteStartElement("FATCAEntCommunicationTypeCd");
                    writer.WriteString("RPT");
                    writer.WriteEndElement();
                    writer.WriteStartElement("SenderFileId");
                    writer.WriteString(senderFile);
                    writer.WriteEndElement();
                    writer.WriteStartElement("FileCreateTs");
                    writer.WriteString(fileCreationDateTime);
                    writer.WriteEndElement();
                    writer.WriteStartElement("TaxYear");
                    writer.WriteString(cbTaxYear.Text);
                    writer.WriteEndElement();
                    writer.WriteStartElement("FileRevisionInd");
                    writer.WriteString("false");
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Close();
                    writer.Flush();

                    //Add the metadata, payload, and key files to the final zip package
                    // add enveloping signature to ZIP file
                    ZipManager.CreateArchive(metadataFileName, filePath + "\\" + senderFile + ".zip");
                    ZipManager.UpdateArchive(encryptedFileName, filePath + "\\" + senderFile + ".zip");

                    if (secondary)
                        ZipManager.UpdateArchive(encryptedFileName2, filePath + "\\" + senderFile + ".zip");

                    ZipManager.UpdateArchive(payloadFileName, filePath + "\\" + senderFile + ".zip");

                    MessageBox.Show(Resources.SigningAndEncryptionComplete, Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                finally
                {
                    writer?.Close();
                }
            }
            catch (Exception ex)
            {
                ex.DisplayException(Text);
            }
        }

        private void btnBrowseNotificationZip_Click(object sender, EventArgs e)
        {
            // load Notification Zip file
            txtNotificationZip.Text = dlgOpen.ShowDialogWithFilter("ZIP Files (*.zip)|*.zip");
        }

        private void btnBrowseRecCert_Click(object sender, EventArgs e)
        {
            // load Notification Receiver key
            txtReceiverCert.Text =
                dlgOpen.ShowDialogWithFilter("Certificate Files (*.cer, *.pfx, *.p12)|*.cer;*.pfx;*.p12");
        }

        private void btnDecryptZip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNotificationZip.Text) || string.IsNullOrWhiteSpace(txtReceiverCert.Text))
            {
                MessageBox.Show(Resources.DecryptFilesMissing, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string zipFolder;
            try
            {
                zipFolder = ZipManager.ExtractArchive(txtNotificationZip.Text, txtNotificationFolder.Text);
            }
            catch (Exception ex)
            {
                ex.DisplayException(Text);
                return;
            }

            // select encrypted key file
            var keyFiles = Directory.GetFiles(zipFolder, "*_Key", SearchOption.TopDirectoryOnly);
            var payloadFiles = Directory.GetFiles(zipFolder, "*_Payload", SearchOption.TopDirectoryOnly);

            if (keyFiles.Length == 0)
            {
                MessageBox.Show(Resources.MissingAesKeyFile, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (payloadFiles.Length == 0)
            {
                MessageBox.Show(Resources.MissingEncryptedPayload, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var encryptedKeyFile = keyFiles[0];
            var encryptedPayloadFile = payloadFiles[0];
            byte[] encryptedAesKey;
            byte[] decryptedAesKey;
            byte[] aesVector;

            try
            {
                // load encrypted AES key
                encryptedAesKey = File.ReadAllBytes(encryptedKeyFile);

                // decrypt AES key & generate default (empty) initialization vector
                decryptedAesKey = AesManager.DecryptAesKey(encryptedAesKey, txtReceiverCert.Text, txtRecKeyPassword.Text);
                aesVector = AesManager.GenerateRandomKey(16, true);

                if (radECB.Checked != true)
                {
                    aesVector = decryptedAesKey.Skip(32).Take(16).ToArray();
                    decryptedAesKey = decryptedAesKey.Take(32).ToArray();
                }

                // decrypt encrypted ZIP file using decrypted AES key
                var decryptedFileName = encryptedPayloadFile.Replace("_Payload", "_Payload_decrypted.zip");
                AesManager.DecryptFile(encryptedPayloadFile, decryptedFileName, decryptedAesKey, aesVector,
                    radECB.Checked);

                //Deflate the decrypted zip archive
                ZipManager.ExtractArchive(decryptedFileName, decryptedFileName, false);

                MessageBox.Show(Resources.DecryptionComplete, Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ex.DisplayException(Text);
            }
            finally
            {
                encryptedAesKey = null;
                decryptedAesKey = null;
                aesVector = null;
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            // load AES key encryption certificate
            if (dlgOpenFolder.ShowDialog() == DialogResult.OK)
                txtNotificationFolder.Text = dlgOpenFolder.SelectedPath;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnBrowseKeyCert2_Click(object sender, EventArgs e)
        {
            txtKeyCert2.Text = dlgOpen.ShowDialogWithFilter("Certificate Files (*.cer, *.pfx, *.p12)|*.cer;*.pfx;*.p12");
        }
    }
}