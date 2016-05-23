namespace WindowsFormsApplication1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLoadXML = new System.Windows.Forms.Label();
            this.txtXmlFile = new System.Windows.Forms.TextBox();
            this.btnBrowseXml = new System.Windows.Forms.Button();
            this.lblCert = new System.Windows.Forms.Label();
            this.txtCert = new System.Windows.Forms.TextBox();
            this.btnBrowseCert = new System.Windows.Forms.Button();
            this.lblCertPass = new System.Windows.Forms.Label();
            this.txtCertPass = new System.Windows.Forms.TextBox();
            this.btnBrowseKeyCert = new System.Windows.Forms.Button();
            this.txtKeyCert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeyCertPassword = new System.Windows.Forms.TextBox();
            this.lblKeyEncryptionCertPassword = new System.Windows.Forms.Label();
            this.btnSignXML = new System.Windows.Forms.Button();
            this.btnBrowseNotificationZip = new System.Windows.Forms.Button();
            this.txtNotificationZip = new System.Windows.Forms.TextBox();
            this.lblZipFile = new System.Windows.Forms.Label();
            this.btnBrowseRecCert = new System.Windows.Forms.Button();
            this.txtReceiverCert = new System.Windows.Forms.TextBox();
            this.lblReceiverCert = new System.Windows.Forms.Label();
            this.txtRecKeyPassword = new System.Windows.Forms.TextBox();
            this.lblRecPass = new System.Windows.Forms.Label();
            this.btnDecryptZip = new System.Windows.Forms.Button();
            this.txtSenderCode = new System.Windows.Forms.TextBox();
            this.lblSender = new System.Windows.Forms.Label();
            this.txtReceiverCode = new System.Windows.Forms.TextBox();
            this.lblReceiver = new System.Windows.Forms.Label();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.txtNotificationFolder = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpenFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyCertGIIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowseKeyCert2 = new System.Windows.Forms.Button();
            this.txtKeyCert2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTaxYear = new System.Windows.Forms.ComboBox();
            this.radCBC = new System.Windows.Forms.RadioButton();
            this.radECB = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoadXML
            // 
            this.lblLoadXML.AutoSize = true;
            this.lblLoadXML.Location = new System.Drawing.Point(23, 31);
            this.lblLoadXML.Name = "lblLoadXML";
            this.lblLoadXML.Size = new System.Drawing.Size(48, 13);
            this.lblLoadXML.TabIndex = 0;
            this.lblLoadXML.Text = "XML File";
            // 
            // txtXmlFile
            // 
            this.txtXmlFile.Location = new System.Drawing.Point(23, 47);
            this.txtXmlFile.Name = "txtXmlFile";
            this.txtXmlFile.Size = new System.Drawing.Size(173, 20);
            this.txtXmlFile.TabIndex = 1;
            // 
            // btnBrowseXml
            // 
            this.btnBrowseXml.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseXml.Location = new System.Drawing.Point(205, 45);
            this.btnBrowseXml.Name = "btnBrowseXml";
            this.btnBrowseXml.Size = new System.Drawing.Size(28, 23);
            this.btnBrowseXml.TabIndex = 2;
            this.btnBrowseXml.Text = "...";
            this.btnBrowseXml.UseVisualStyleBackColor = true;
            this.btnBrowseXml.Click += new System.EventHandler(this.btnBrowseXml_Click);
            // 
            // lblCert
            // 
            this.lblCert.AutoSize = true;
            this.lblCert.Location = new System.Drawing.Point(23, 82);
            this.lblCert.Name = "lblCert";
            this.lblCert.Size = new System.Drawing.Size(199, 13);
            this.lblCert.TabIndex = 3;
            this.lblCert.Text = "Signing Certificate (Sender\'s Private Key)";
            // 
            // txtCert
            // 
            this.txtCert.Location = new System.Drawing.Point(23, 98);
            this.txtCert.Name = "txtCert";
            this.txtCert.Size = new System.Drawing.Size(173, 20);
            this.txtCert.TabIndex = 4;
            // 
            // btnBrowseCert
            // 
            this.btnBrowseCert.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseCert.Location = new System.Drawing.Point(205, 98);
            this.btnBrowseCert.Name = "btnBrowseCert";
            this.btnBrowseCert.Size = new System.Drawing.Size(28, 23);
            this.btnBrowseCert.TabIndex = 5;
            this.btnBrowseCert.Text = "...";
            this.btnBrowseCert.UseVisualStyleBackColor = true;
            this.btnBrowseCert.Click += new System.EventHandler(this.btnBrowseCert_Click);
            // 
            // lblCertPass
            // 
            this.lblCertPass.AutoSize = true;
            this.lblCertPass.Location = new System.Drawing.Point(23, 125);
            this.lblCertPass.Name = "lblCertPass";
            this.lblCertPass.Size = new System.Drawing.Size(141, 13);
            this.lblCertPass.TabIndex = 6;
            this.lblCertPass.Text = "Signing Certificate Password";
            // 
            // txtCertPass
            // 
            this.txtCertPass.Location = new System.Drawing.Point(23, 141);
            this.txtCertPass.Name = "txtCertPass";
            this.txtCertPass.PasswordChar = '*';
            this.txtCertPass.Size = new System.Drawing.Size(173, 20);
            this.txtCertPass.TabIndex = 7;
            // 
            // btnBrowseKeyCert
            // 
            this.btnBrowseKeyCert.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseKeyCert.Location = new System.Drawing.Point(205, 185);
            this.btnBrowseKeyCert.Name = "btnBrowseKeyCert";
            this.btnBrowseKeyCert.Size = new System.Drawing.Size(28, 23);
            this.btnBrowseKeyCert.TabIndex = 10;
            this.btnBrowseKeyCert.Text = "...";
            this.btnBrowseKeyCert.UseVisualStyleBackColor = true;
            this.btnBrowseKeyCert.Click += new System.EventHandler(this.btnBrowseKeyCert_Click);
            // 
            // txtKeyCert
            // 
            this.txtKeyCert.Location = new System.Drawing.Point(23, 185);
            this.txtKeyCert.Name = "txtKeyCert";
            this.txtKeyCert.Size = new System.Drawing.Size(173, 20);
            this.txtKeyCert.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "IRS Public Key)";
            // 
            // txtKeyCertPassword
            // 
            this.txtKeyCertPassword.Location = new System.Drawing.Point(23, 231);
            this.txtKeyCertPassword.Name = "txtKeyCertPassword";
            this.txtKeyCertPassword.Size = new System.Drawing.Size(173, 20);
            this.txtKeyCertPassword.TabIndex = 12;
            // 
            // lblKeyEncryptionCertPassword
            // 
            this.lblKeyEncryptionCertPassword.AutoSize = true;
            this.lblKeyEncryptionCertPassword.Location = new System.Drawing.Point(23, 215);
            this.lblKeyEncryptionCertPassword.Name = "lblKeyEncryptionCertPassword";
            this.lblKeyEncryptionCertPassword.Size = new System.Drawing.Size(200, 13);
            this.lblKeyEncryptionCertPassword.TabIndex = 11;
            this.lblKeyEncryptionCertPassword.Text = "IRS  Key Certificate password (if needed)";
            // 
            // btnSignXML
            // 
            this.btnSignXML.Location = new System.Drawing.Point(23, 262);
            this.btnSignXML.Name = "btnSignXML";
            this.btnSignXML.Size = new System.Drawing.Size(173, 23);
            this.btnSignXML.TabIndex = 13;
            this.btnSignXML.Text = "Sign and Encrypt XML";
            this.btnSignXML.UseVisualStyleBackColor = true;
            this.btnSignXML.Click += new System.EventHandler(this.btnSignXML_Click);
            // 
            // btnBrowseNotificationZip
            // 
            this.btnBrowseNotificationZip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseNotificationZip.Location = new System.Drawing.Point(687, 47);
            this.btnBrowseNotificationZip.Name = "btnBrowseNotificationZip";
            this.btnBrowseNotificationZip.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseNotificationZip.TabIndex = 16;
            this.btnBrowseNotificationZip.Text = "...";
            this.btnBrowseNotificationZip.UseVisualStyleBackColor = true;
            this.btnBrowseNotificationZip.Click += new System.EventHandler(this.btnBrowseNotificationZip_Click);
            // 
            // txtNotificationZip
            // 
            this.txtNotificationZip.Location = new System.Drawing.Point(508, 49);
            this.txtNotificationZip.Name = "txtNotificationZip";
            this.txtNotificationZip.Size = new System.Drawing.Size(173, 20);
            this.txtNotificationZip.TabIndex = 15;
            // 
            // lblZipFile
            // 
            this.lblZipFile.AutoSize = true;
            this.lblZipFile.Location = new System.Drawing.Point(508, 33);
            this.lblZipFile.Name = "lblZipFile";
            this.lblZipFile.Size = new System.Drawing.Size(41, 13);
            this.lblZipFile.TabIndex = 14;
            this.lblZipFile.Text = "Zip File";
            // 
            // btnBrowseRecCert
            // 
            this.btnBrowseRecCert.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseRecCert.Location = new System.Drawing.Point(687, 97);
            this.btnBrowseRecCert.Name = "btnBrowseRecCert";
            this.btnBrowseRecCert.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseRecCert.TabIndex = 19;
            this.btnBrowseRecCert.Text = "...";
            this.btnBrowseRecCert.UseVisualStyleBackColor = true;
            this.btnBrowseRecCert.Click += new System.EventHandler(this.btnBrowseRecCert_Click);
            // 
            // txtReceiverCert
            // 
            this.txtReceiverCert.Location = new System.Drawing.Point(508, 99);
            this.txtReceiverCert.Name = "txtReceiverCert";
            this.txtReceiverCert.Size = new System.Drawing.Size(173, 20);
            this.txtReceiverCert.TabIndex = 18;
            // 
            // lblReceiverCert
            // 
            this.lblReceiverCert.AutoSize = true;
            this.lblReceiverCert.Location = new System.Drawing.Point(508, 83);
            this.lblReceiverCert.Name = "lblReceiverCert";
            this.lblReceiverCert.Size = new System.Drawing.Size(209, 13);
            this.lblReceiverCert.TabIndex = 17;
            this.lblReceiverCert.Text = "Receiver Certificate (Receiver Private Key)";
            // 
            // txtRecKeyPassword
            // 
            this.txtRecKeyPassword.Location = new System.Drawing.Point(508, 142);
            this.txtRecKeyPassword.Name = "txtRecKeyPassword";
            this.txtRecKeyPassword.PasswordChar = '*';
            this.txtRecKeyPassword.Size = new System.Drawing.Size(173, 20);
            this.txtRecKeyPassword.TabIndex = 21;
            // 
            // lblRecPass
            // 
            this.lblRecPass.AutoSize = true;
            this.lblRecPass.Location = new System.Drawing.Point(508, 126);
            this.lblRecPass.Name = "lblRecPass";
            this.lblRecPass.Size = new System.Drawing.Size(155, 13);
            this.lblRecPass.TabIndex = 20;
            this.lblRecPass.Text = "Certificate password (if needed)";
            // 
            // btnDecryptZip
            // 
            this.btnDecryptZip.Location = new System.Drawing.Point(508, 170);
            this.btnDecryptZip.Name = "btnDecryptZip";
            this.btnDecryptZip.Size = new System.Drawing.Size(173, 23);
            this.btnDecryptZip.TabIndex = 22;
            this.btnDecryptZip.Text = "Decrypt Notification";
            this.btnDecryptZip.UseVisualStyleBackColor = true;
            this.btnDecryptZip.Click += new System.EventHandler(this.btnDecryptZip_Click);
            // 
            // txtSenderCode
            // 
            this.txtSenderCode.Location = new System.Drawing.Point(508, 212);
            this.txtSenderCode.Name = "txtSenderCode";
            this.txtSenderCode.Size = new System.Drawing.Size(69, 20);
            this.txtSenderCode.TabIndex = 24;
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Location = new System.Drawing.Point(508, 196);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(69, 13);
            this.lblSender.TabIndex = 23;
            this.lblSender.Text = "Sender Code";
            // 
            // txtReceiverCode
            // 
            this.txtReceiverCode.Location = new System.Drawing.Point(608, 212);
            this.txtReceiverCode.Name = "txtReceiverCode";
            this.txtReceiverCode.Size = new System.Drawing.Size(78, 20);
            this.txtReceiverCode.TabIndex = 26;
            // 
            // lblReceiver
            // 
            this.lblReceiver.AutoSize = true;
            this.lblReceiver.Location = new System.Drawing.Point(608, 196);
            this.lblReceiver.Name = "lblReceiver";
            this.lblReceiver.Size = new System.Drawing.Size(78, 13);
            this.lblReceiver.TabIndex = 25;
            this.lblReceiver.Text = "Receiver Code";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseOutput.Location = new System.Drawing.Point(688, 258);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(29, 23);
            this.btnBrowseOutput.TabIndex = 29;
            this.btnBrowseOutput.Text = "...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // txtNotificationFolder
            // 
            this.txtNotificationFolder.Location = new System.Drawing.Point(508, 258);
            this.txtNotificationFolder.Name = "txtNotificationFolder";
            this.txtNotificationFolder.Size = new System.Drawing.Size(173, 20);
            this.txtNotificationFolder.TabIndex = 28;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(508, 242);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(127, 13);
            this.lblOutput.TabIndex = 27;
            this.lblOutput.Text = "Notification Output Folder";
            // 
            // dlgOpen
            // 
            this.dlgOpen.Title = "Open File";
            // 
            // dlgSave
            // 
            this.dlgSave.Filter = "XML Files (*.xml)|*.xml";
            this.dlgSave.Title = "Save File";
            // 
            // dlgOpenFolder
            // 
            this.dlgOpenFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Create a Transmission File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Decrypting a Notification";
            // 
            // txtKeyCertGIIN
            // 
            this.txtKeyCertGIIN.Location = new System.Drawing.Point(269, 231);
            this.txtKeyCertGIIN.Name = "txtKeyCertGIIN";
            this.txtKeyCertGIIN.Size = new System.Drawing.Size(173, 20);
            this.txtKeyCertGIIN.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Option 2 Jurisdiction GIIN";
            // 
            // btnBrowseKeyCert2
            // 
            this.btnBrowseKeyCert2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseKeyCert2.Location = new System.Drawing.Point(451, 185);
            this.btnBrowseKeyCert2.Name = "btnBrowseKeyCert2";
            this.btnBrowseKeyCert2.Size = new System.Drawing.Size(28, 23);
            this.btnBrowseKeyCert2.TabIndex = 34;
            this.btnBrowseKeyCert2.Text = "...";
            this.btnBrowseKeyCert2.UseVisualStyleBackColor = true;
            this.btnBrowseKeyCert2.Click += new System.EventHandler(this.btnBrowseKeyCert2_Click);
            // 
            // txtKeyCert2
            // 
            this.txtKeyCert2.Location = new System.Drawing.Point(269, 185);
            this.txtKeyCert2.Name = "txtKeyCert2";
            this.txtKeyCert2.Size = new System.Drawing.Size(173, 20);
            this.txtKeyCert2.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Option 2 Jurisdiction Public Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 26);
            this.label6.TabIndex = 37;
            this.label6.Text = "Complete below for Model1\r\nOption 2 countries";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(259, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 160);
            this.panel1.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Tax Year";
            // 
            // cbTaxYear
            // 
            this.cbTaxYear.FormattingEnabled = true;
            this.cbTaxYear.Location = new System.Drawing.Point(272, 76);
            this.cbTaxYear.Name = "cbTaxYear";
            this.cbTaxYear.Size = new System.Drawing.Size(170, 21);
            this.cbTaxYear.TabIndex = 41;
            // 
            // radCBC
            // 
            this.radCBC.AutoSize = true;
            this.radCBC.Checked = true;
            this.radCBC.Location = new System.Drawing.Point(275, 12);
            this.radCBC.Name = "radCBC";
            this.radCBC.Size = new System.Drawing.Size(76, 17);
            this.radCBC.TabIndex = 46;
            this.radCBC.TabStop = true;
            this.radCBC.Text = "CBC Mode";
            this.radCBC.UseVisualStyleBackColor = true;
            // 
            // radECB
            // 
            this.radECB.AutoSize = true;
            this.radECB.Location = new System.Drawing.Point(275, 32);
            this.radECB.Name = "radECB";
            this.radECB.Size = new System.Drawing.Size(76, 17);
            this.radECB.TabIndex = 45;
            this.radECB.Text = "ECB Mode";
            this.radECB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 292);
            this.Controls.Add(this.radCBC);
            this.Controls.Add(this.radECB);
            this.Controls.Add(this.cbTaxYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKeyCertGIIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBrowseKeyCert2);
            this.Controls.Add(this.txtKeyCert2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.txtNotificationFolder);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtReceiverCode);
            this.Controls.Add(this.lblReceiver);
            this.Controls.Add(this.txtSenderCode);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.btnDecryptZip);
            this.Controls.Add(this.txtRecKeyPassword);
            this.Controls.Add(this.lblRecPass);
            this.Controls.Add(this.btnBrowseRecCert);
            this.Controls.Add(this.txtReceiverCert);
            this.Controls.Add(this.lblReceiverCert);
            this.Controls.Add(this.btnBrowseNotificationZip);
            this.Controls.Add(this.txtNotificationZip);
            this.Controls.Add(this.lblZipFile);
            this.Controls.Add(this.btnSignXML);
            this.Controls.Add(this.txtKeyCertPassword);
            this.Controls.Add(this.lblKeyEncryptionCertPassword);
            this.Controls.Add(this.btnBrowseKeyCert);
            this.Controls.Add(this.txtKeyCert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCertPass);
            this.Controls.Add(this.lblCertPass);
            this.Controls.Add(this.btnBrowseCert);
            this.Controls.Add(this.txtCert);
            this.Controls.Add(this.lblCert);
            this.Controls.Add(this.btnBrowseXml);
            this.Controls.Add(this.txtXmlFile);
            this.Controls.Add(this.lblLoadXML);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "IDES Data Preparation";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoadXML;
        private System.Windows.Forms.TextBox txtXmlFile;
        private System.Windows.Forms.Button btnBrowseXml;
        private System.Windows.Forms.Label lblCert;
        private System.Windows.Forms.TextBox txtCert;
        private System.Windows.Forms.Button btnBrowseCert;
        private System.Windows.Forms.Label lblCertPass;
        private System.Windows.Forms.TextBox txtCertPass;
        private System.Windows.Forms.Button btnBrowseKeyCert;
        private System.Windows.Forms.TextBox txtKeyCert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKeyCertPassword;
        private System.Windows.Forms.Label lblKeyEncryptionCertPassword;
        private System.Windows.Forms.Button btnSignXML;
        private System.Windows.Forms.Button btnBrowseNotificationZip;
        private System.Windows.Forms.TextBox txtNotificationZip;
        private System.Windows.Forms.Label lblZipFile;
        private System.Windows.Forms.Button btnBrowseRecCert;
        private System.Windows.Forms.TextBox txtReceiverCert;
        private System.Windows.Forms.Label lblReceiverCert;
        private System.Windows.Forms.TextBox txtRecKeyPassword;
        private System.Windows.Forms.Label lblRecPass;
        private System.Windows.Forms.Button btnDecryptZip;
        private System.Windows.Forms.TextBox txtSenderCode;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.TextBox txtReceiverCode;
        private System.Windows.Forms.Label lblReceiver;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.TextBox txtNotificationFolder;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.FolderBrowserDialog dlgOpenFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyCertGIIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowseKeyCert2;
        private System.Windows.Forms.TextBox txtKeyCert2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTaxYear;
        private System.Windows.Forms.RadioButton radCBC;
        private System.Windows.Forms.RadioButton radECB;
    }
}

