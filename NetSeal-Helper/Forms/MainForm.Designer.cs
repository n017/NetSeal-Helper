using System;
using System.Drawing;
namespace NetSeal_Helper.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rtbLogger = new System.Windows.Forms.RichTextBox();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpLicense = new System.Windows.Forms.TabPage();
            this.gbxExtras = new System.Windows.Forms.GroupBox();
            this.btnGetVariable = new System.Windows.Forms.Button();
            this.btnViewNews = new System.Windows.Forms.Button();
            this.gbxLicense = new System.Windows.Forms.GroupBox();
            this.btnBrowseTarget = new System.Windows.Forms.Button();
            this.gbxLicenseDetails = new System.Windows.Forms.GroupBox();
            this.lblGlobalMessage = new System.Windows.Forms.Label();
            this.txtGlobalMessage = new System.Windows.Forms.TextBox();
            this.txtUsersCount = new System.Windows.Forms.TextBox();
            this.txtExpirationDate = new System.Windows.Forms.TextBox();
            this.txtPointsCount = new System.Windows.Forms.TextBox();
            this.txtPrivateKeyBase64 = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtPublicToken = new System.Windows.Forms.TextBox();
            this.txtRemainingTime = new System.Windows.Forms.TextBox();
            this.txtLicenseType = new System.Windows.Forms.TextBox();
            this.txtUpdateAvaliable = new System.Windows.Forms.TextBox();
            this.txtUsersOnline = new System.Windows.Forms.TextBox();
            this.lblUsersCount = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblPointsCount = new System.Windows.Forms.Label();
            this.lblPrivateKeyBase64 = new System.Windows.Forms.Label();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.lblPublicToken = new System.Windows.Forms.Label();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.lblLicenseType = new System.Windows.Forms.Label();
            this.lblUpdateAvailable = new System.Windows.Forms.Label();
            this.lblUsersOnline = new System.Windows.Forms.Label();
            this.tbpExchange = new System.Windows.Forms.TabPage();
            this.gbxICrypt = new System.Windows.Forms.GroupBox();
            this.btnExchangeDecrypt = new System.Windows.Forms.Button();
            this.btnExchangeEncrypt = new System.Windows.Forms.Button();
            this.lblExchangeICryptResult = new System.Windows.Forms.Label();
            this.txtExchangeICryptResult = new System.Windows.Forms.TextBox();
            this.lblExchangeKey = new System.Windows.Forms.Label();
            this.lblExchangeDataToCryptDecrypt = new System.Windows.Forms.Label();
            this.gbxExchange = new System.Windows.Forms.GroupBox();
            this.btnSaveLastData = new System.Windows.Forms.Button();
            this.btnExchangeSaveLastDataAsAscii = new System.Windows.Forms.Button();
            this.btnExchangeSaveLastData = new System.Windows.Forms.Button();
            this.btnExchangeViewLastData = new System.Windows.Forms.Button();
            this.btnExchangeDecryptLastData = new System.Windows.Forms.Button();
            this.btnExchangeClearCookies = new System.Windows.Forms.Button();
            this.btnExchangeDownloadData = new System.Windows.Forms.Button();
            this.btnExchangeUploadValues = new System.Windows.Forms.Button();
            this.tbpLicenseManager = new System.Windows.Forms.TabPage();
            this.btnLicenseManagerSearchProgramName = new System.Windows.Forms.Button();
            this.ltvLicenses = new System.Windows.Forms.ListView();
            this.cmsLicenseManager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyProgramNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyGUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyUsernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.changeGUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.gbpSourceAndLatestRelease = new System.Windows.Forms.GroupBox();
            this.llblOpenGitHub = new System.Windows.Forms.LinkLabel();
            this.pbxMe = new System.Windows.Forms.PictureBox();
            this.gbpTutorials = new System.Windows.Forms.GroupBox();
            this.llblNetsealTutorial3 = new System.Windows.Forms.LinkLabel();
            this.llblNetsealTutorial2 = new System.Windows.Forms.LinkLabel();
            this.llblNetsealTutorial1 = new System.Windows.Forms.LinkLabel();
            this.gbpSettingsUpdater = new System.Windows.Forms.GroupBox();
            this.cbxCheckDataBaseUpdate = new System.Windows.Forms.CheckBox();
            this.gbxCredentials = new System.Windows.Forms.GroupBox();
            this.cbxSaveCredentials = new System.Windows.Forms.CheckBox();
            this.gbxSettingsLogger = new System.Windows.Forms.GroupBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnTestErrorMessage = new System.Windows.Forms.Button();
            this.btnRestoreSettings = new System.Windows.Forms.Button();
            this.brnTestWarnMessage = new System.Windows.Forms.Button();
            this.btnTestInfo = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lvlErrorColor = new System.Windows.Forms.Label();
            this.lvlWarningColor = new System.Windows.Forms.Label();
            this.lblInformationColor = new System.Windows.Forms.Label();
            this.lvlBackColor = new System.Windows.Forms.Label();
            this.lblTimeColor = new System.Windows.Forms.Label();
            this.wtxtVariables = new NetSeal_Helper.Controls.WaterMarkTextBox();
            this.wtxtTargetPath = new NetSeal_Helper.Controls.WaterMarkTextBox();
            this.wtxtPassword = new NetSeal_Helper.Controls.WaterMarkTextBox();
            this.wtxtId = new NetSeal_Helper.Controls.WaterMarkTextBox();
            this.wtxtUsername = new NetSeal_Helper.Controls.WaterMarkTextBox();
            this.wtxtExchangeKey = new NetSeal_Helper.Controls.WaterMarkTextBox();
            this.wtxtExchangeDataToEncryptDecrypt = new NetSeal_Helper.Controls.WaterMarkTextBox();
            this.wtxtExchangeResult = new NetSeal_Helper.Controls.WaterMarkTextBox();
            this.wtxtExchangeRequest = new NetSeal_Helper.Controls.WaterMarkTextBox();
            this.wtxtExchangeUrl = new NetSeal_Helper.Controls.WaterMarkTextBox();
            this.wtxtLicenseManagerSearchProgramName = new NetSeal_Helper.Controls.WaterMarkTextBox();
            this.cpcmbErrorColor = new NetSeal_Helper.Controls.ColorPickerComboBox();
            this.cpcmbWarningColor = new NetSeal_Helper.Controls.ColorPickerComboBox();
            this.cpcmbInformationColor = new NetSeal_Helper.Controls.ColorPickerComboBox();
            this.cpcmbBackColor = new NetSeal_Helper.Controls.ColorPickerComboBox();
            this.cpcmbTimeColor = new NetSeal_Helper.Controls.ColorPickerComboBox();
            this.tbcMain.SuspendLayout();
            this.tbpLicense.SuspendLayout();
            this.gbxExtras.SuspendLayout();
            this.gbxLicense.SuspendLayout();
            this.gbxLicenseDetails.SuspendLayout();
            this.tbpExchange.SuspendLayout();
            this.gbxICrypt.SuspendLayout();
            this.gbxExchange.SuspendLayout();
            this.tbpLicenseManager.SuspendLayout();
            this.cmsLicenseManager.SuspendLayout();
            this.tbpSettings.SuspendLayout();
            this.gbpSourceAndLatestRelease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMe)).BeginInit();
            this.gbpTutorials.SuspendLayout();
            this.gbpSettingsUpdater.SuspendLayout();
            this.gbxCredentials.SuspendLayout();
            this.gbxSettingsLogger.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbLogger
            // 
            this.rtbLogger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLogger.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbLogger.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLogger.Location = new System.Drawing.Point(678, 3);
            this.rtbLogger.Name = "rtbLogger";
            this.rtbLogger.ReadOnly = true;
            this.rtbLogger.Size = new System.Drawing.Size(369, 559);
            this.rtbLogger.TabIndex = 0;
            this.rtbLogger.Text = "";
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(550, 45);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(81, 23);
            this.btnInitialize.TabIndex = 5;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpLicense);
            this.tbcMain.Controls.Add(this.tbpExchange);
            this.tbcMain.Controls.Add(this.tbpLicenseManager);
            this.tbcMain.Controls.Add(this.tbpSettings);
            this.tbcMain.Location = new System.Drawing.Point(12, 12);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(659, 540);
            this.tbcMain.TabIndex = 10;
            // 
            // tbpLicense
            // 
            this.tbpLicense.Controls.Add(this.gbxExtras);
            this.tbpLicense.Controls.Add(this.gbxLicense);
            this.tbpLicense.Controls.Add(this.gbxLicenseDetails);
            this.tbpLicense.Location = new System.Drawing.Point(4, 22);
            this.tbpLicense.Name = "tbpLicense";
            this.tbpLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLicense.Size = new System.Drawing.Size(651, 514);
            this.tbpLicense.TabIndex = 0;
            this.tbpLicense.Text = "License";
            this.tbpLicense.UseVisualStyleBackColor = true;
            // 
            // gbxExtras
            // 
            this.gbxExtras.Controls.Add(this.btnGetVariable);
            this.gbxExtras.Controls.Add(this.btnViewNews);
            this.gbxExtras.Controls.Add(this.wtxtVariables);
            this.gbxExtras.Location = new System.Drawing.Point(8, 444);
            this.gbxExtras.Name = "gbxExtras";
            this.gbxExtras.Size = new System.Drawing.Size(637, 61);
            this.gbxExtras.TabIndex = 13;
            this.gbxExtras.TabStop = false;
            this.gbxExtras.Text = "Extras";
            // 
            // btnGetVariable
            // 
            this.btnGetVariable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetVariable.Location = new System.Drawing.Point(442, 20);
            this.btnGetVariable.Name = "btnGetVariable";
            this.btnGetVariable.Size = new System.Drawing.Size(95, 23);
            this.btnGetVariable.TabIndex = 3;
            this.btnGetVariable.Text = "Get Variable";
            this.btnGetVariable.UseVisualStyleBackColor = true;
            this.btnGetVariable.Click += new System.EventHandler(this.btnGetVariable_Click);
            // 
            // btnViewNews
            // 
            this.btnViewNews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewNews.Location = new System.Drawing.Point(543, 20);
            this.btnViewNews.Name = "btnViewNews";
            this.btnViewNews.Size = new System.Drawing.Size(81, 23);
            this.btnViewNews.TabIndex = 4;
            this.btnViewNews.Text = "View News";
            this.btnViewNews.UseVisualStyleBackColor = true;
            this.btnViewNews.Click += new System.EventHandler(this.btnViewNews_Click);
            // 
            // gbxLicense
            // 
            this.gbxLicense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLicense.Controls.Add(this.wtxtTargetPath);
            this.gbxLicense.Controls.Add(this.wtxtPassword);
            this.gbxLicense.Controls.Add(this.btnBrowseTarget);
            this.gbxLicense.Controls.Add(this.wtxtId);
            this.gbxLicense.Controls.Add(this.wtxtUsername);
            this.gbxLicense.Controls.Add(this.btnInitialize);
            this.gbxLicense.Location = new System.Drawing.Point(8, 6);
            this.gbxLicense.Name = "gbxLicense";
            this.gbxLicense.Size = new System.Drawing.Size(637, 84);
            this.gbxLicense.TabIndex = 12;
            this.gbxLicense.TabStop = false;
            this.gbxLicense.Text = "License";
            // 
            // btnBrowseTarget
            // 
            this.btnBrowseTarget.Location = new System.Drawing.Point(550, 18);
            this.btnBrowseTarget.Name = "btnBrowseTarget";
            this.btnBrowseTarget.Size = new System.Drawing.Size(81, 23);
            this.btnBrowseTarget.TabIndex = 10;
            this.btnBrowseTarget.Text = "Browse";
            this.btnBrowseTarget.UseVisualStyleBackColor = true;
            this.btnBrowseTarget.Click += new System.EventHandler(this.btnBrowseTarget_Click);
            // 
            // gbxLicenseDetails
            // 
            this.gbxLicenseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLicenseDetails.Controls.Add(this.lblGlobalMessage);
            this.gbxLicenseDetails.Controls.Add(this.txtGlobalMessage);
            this.gbxLicenseDetails.Controls.Add(this.txtUsersCount);
            this.gbxLicenseDetails.Controls.Add(this.txtExpirationDate);
            this.gbxLicenseDetails.Controls.Add(this.txtPointsCount);
            this.gbxLicenseDetails.Controls.Add(this.txtPrivateKeyBase64);
            this.gbxLicenseDetails.Controls.Add(this.txtPrivateKey);
            this.gbxLicenseDetails.Controls.Add(this.txtPublicToken);
            this.gbxLicenseDetails.Controls.Add(this.txtRemainingTime);
            this.gbxLicenseDetails.Controls.Add(this.txtLicenseType);
            this.gbxLicenseDetails.Controls.Add(this.txtUpdateAvaliable);
            this.gbxLicenseDetails.Controls.Add(this.txtUsersOnline);
            this.gbxLicenseDetails.Controls.Add(this.lblUsersCount);
            this.gbxLicenseDetails.Controls.Add(this.lblExpirationDate);
            this.gbxLicenseDetails.Controls.Add(this.lblPointsCount);
            this.gbxLicenseDetails.Controls.Add(this.lblPrivateKeyBase64);
            this.gbxLicenseDetails.Controls.Add(this.lblPrivateKey);
            this.gbxLicenseDetails.Controls.Add(this.lblPublicToken);
            this.gbxLicenseDetails.Controls.Add(this.lblRemainingTime);
            this.gbxLicenseDetails.Controls.Add(this.lblLicenseType);
            this.gbxLicenseDetails.Controls.Add(this.lblUpdateAvailable);
            this.gbxLicenseDetails.Controls.Add(this.lblUsersOnline);
            this.gbxLicenseDetails.Location = new System.Drawing.Point(8, 96);
            this.gbxLicenseDetails.Name = "gbxLicenseDetails";
            this.gbxLicenseDetails.Size = new System.Drawing.Size(637, 342);
            this.gbxLicenseDetails.TabIndex = 11;
            this.gbxLicenseDetails.TabStop = false;
            this.gbxLicenseDetails.Text = "Details";
            // 
            // lblGlobalMessage
            // 
            this.lblGlobalMessage.AutoSize = true;
            this.lblGlobalMessage.Location = new System.Drawing.Point(12, 269);
            this.lblGlobalMessage.Name = "lblGlobalMessage";
            this.lblGlobalMessage.Size = new System.Drawing.Size(96, 13);
            this.lblGlobalMessage.TabIndex = 3;
            this.lblGlobalMessage.Text = "Global Message";
            // 
            // txtGlobalMessage
            // 
            this.txtGlobalMessage.BackColor = System.Drawing.SystemColors.Control;
            this.txtGlobalMessage.Location = new System.Drawing.Point(118, 230);
            this.txtGlobalMessage.Multiline = true;
            this.txtGlobalMessage.Name = "txtGlobalMessage";
            this.txtGlobalMessage.ReadOnly = true;
            this.txtGlobalMessage.Size = new System.Drawing.Size(513, 95);
            this.txtGlobalMessage.TabIndex = 2;
            // 
            // txtUsersCount
            // 
            this.txtUsersCount.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsersCount.Location = new System.Drawing.Point(118, 20);
            this.txtUsersCount.Name = "txtUsersCount";
            this.txtUsersCount.ReadOnly = true;
            this.txtUsersCount.Size = new System.Drawing.Size(193, 21);
            this.txtUsersCount.TabIndex = 1;
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtExpirationDate.Location = new System.Drawing.Point(118, 101);
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.ReadOnly = true;
            this.txtExpirationDate.Size = new System.Drawing.Size(193, 21);
            this.txtExpirationDate.TabIndex = 1;
            // 
            // txtPointsCount
            // 
            this.txtPointsCount.BackColor = System.Drawing.SystemColors.Control;
            this.txtPointsCount.Location = new System.Drawing.Point(431, 20);
            this.txtPointsCount.Name = "txtPointsCount";
            this.txtPointsCount.ReadOnly = true;
            this.txtPointsCount.Size = new System.Drawing.Size(193, 21);
            this.txtPointsCount.TabIndex = 1;
            // 
            // txtPrivateKeyBase64
            // 
            this.txtPrivateKeyBase64.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrivateKeyBase64.Location = new System.Drawing.Point(118, 192);
            this.txtPrivateKeyBase64.Name = "txtPrivateKeyBase64";
            this.txtPrivateKeyBase64.ReadOnly = true;
            this.txtPrivateKeyBase64.Size = new System.Drawing.Size(513, 21);
            this.txtPrivateKeyBase64.TabIndex = 1;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrivateKey.Location = new System.Drawing.Point(118, 165);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.Size = new System.Drawing.Size(513, 21);
            this.txtPrivateKey.TabIndex = 1;
            // 
            // txtPublicToken
            // 
            this.txtPublicToken.BackColor = System.Drawing.SystemColors.Control;
            this.txtPublicToken.Location = new System.Drawing.Point(118, 138);
            this.txtPublicToken.Name = "txtPublicToken";
            this.txtPublicToken.ReadOnly = true;
            this.txtPublicToken.Size = new System.Drawing.Size(513, 21);
            this.txtPublicToken.TabIndex = 1;
            // 
            // txtRemainingTime
            // 
            this.txtRemainingTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtRemainingTime.Location = new System.Drawing.Point(431, 74);
            this.txtRemainingTime.Name = "txtRemainingTime";
            this.txtRemainingTime.ReadOnly = true;
            this.txtRemainingTime.Size = new System.Drawing.Size(193, 21);
            this.txtRemainingTime.TabIndex = 1;
            // 
            // txtLicenseType
            // 
            this.txtLicenseType.BackColor = System.Drawing.SystemColors.Control;
            this.txtLicenseType.Location = new System.Drawing.Point(118, 74);
            this.txtLicenseType.Name = "txtLicenseType";
            this.txtLicenseType.ReadOnly = true;
            this.txtLicenseType.Size = new System.Drawing.Size(193, 21);
            this.txtLicenseType.TabIndex = 1;
            // 
            // txtUpdateAvaliable
            // 
            this.txtUpdateAvaliable.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdateAvaliable.Location = new System.Drawing.Point(431, 47);
            this.txtUpdateAvaliable.Name = "txtUpdateAvaliable";
            this.txtUpdateAvaliable.ReadOnly = true;
            this.txtUpdateAvaliable.Size = new System.Drawing.Size(193, 21);
            this.txtUpdateAvaliable.TabIndex = 1;
            // 
            // txtUsersOnline
            // 
            this.txtUsersOnline.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsersOnline.Location = new System.Drawing.Point(118, 47);
            this.txtUsersOnline.Name = "txtUsersOnline";
            this.txtUsersOnline.ReadOnly = true;
            this.txtUsersOnline.Size = new System.Drawing.Size(193, 21);
            this.txtUsersOnline.TabIndex = 1;
            // 
            // lblUsersCount
            // 
            this.lblUsersCount.AutoSize = true;
            this.lblUsersCount.Location = new System.Drawing.Point(12, 23);
            this.lblUsersCount.Name = "lblUsersCount";
            this.lblUsersCount.Size = new System.Drawing.Size(77, 13);
            this.lblUsersCount.TabIndex = 0;
            this.lblUsersCount.Text = "Users Count";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(12, 104);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(95, 13);
            this.lblExpirationDate.TabIndex = 0;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // lblPointsCount
            // 
            this.lblPointsCount.AutoSize = true;
            this.lblPointsCount.Location = new System.Drawing.Point(322, 23);
            this.lblPointsCount.Name = "lblPointsCount";
            this.lblPointsCount.Size = new System.Drawing.Size(79, 13);
            this.lblPointsCount.TabIndex = 0;
            this.lblPointsCount.Text = "Points Count";
            // 
            // lblPrivateKeyBase64
            // 
            this.lblPrivateKeyBase64.AutoSize = true;
            this.lblPrivateKeyBase64.Location = new System.Drawing.Point(12, 195);
            this.lblPrivateKeyBase64.Name = "lblPrivateKeyBase64";
            this.lblPrivateKeyBase64.Size = new System.Drawing.Size(100, 13);
            this.lblPrivateKeyBase64.TabIndex = 0;
            this.lblPrivateKeyBase64.Text = "P. Key (Base64)";
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Location = new System.Drawing.Point(12, 168);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(80, 13);
            this.lblPrivateKey.TabIndex = 0;
            this.lblPrivateKey.Text = "P. Key (Hex)";
            // 
            // lblPublicToken
            // 
            this.lblPublicToken.AutoSize = true;
            this.lblPublicToken.Location = new System.Drawing.Point(12, 141);
            this.lblPublicToken.Name = "lblPublicToken";
            this.lblPublicToken.Size = new System.Drawing.Size(79, 13);
            this.lblPublicToken.TabIndex = 0;
            this.lblPublicToken.Text = "Public Token";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Location = new System.Drawing.Point(322, 77);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(99, 13);
            this.lblRemainingTime.TabIndex = 0;
            this.lblRemainingTime.Text = "Remaining Time";
            // 
            // lblLicenseType
            // 
            this.lblLicenseType.AutoSize = true;
            this.lblLicenseType.Location = new System.Drawing.Point(12, 77);
            this.lblLicenseType.Name = "lblLicenseType";
            this.lblLicenseType.Size = new System.Drawing.Size(81, 13);
            this.lblLicenseType.TabIndex = 0;
            this.lblLicenseType.Text = "License Type";
            // 
            // lblUpdateAvailable
            // 
            this.lblUpdateAvailable.AutoSize = true;
            this.lblUpdateAvailable.Location = new System.Drawing.Point(322, 50);
            this.lblUpdateAvailable.Name = "lblUpdateAvailable";
            this.lblUpdateAvailable.Size = new System.Drawing.Size(103, 13);
            this.lblUpdateAvailable.TabIndex = 0;
            this.lblUpdateAvailable.Text = "Update Available";
            // 
            // lblUsersOnline
            // 
            this.lblUsersOnline.AutoSize = true;
            this.lblUsersOnline.Location = new System.Drawing.Point(12, 50);
            this.lblUsersOnline.Name = "lblUsersOnline";
            this.lblUsersOnline.Size = new System.Drawing.Size(79, 13);
            this.lblUsersOnline.TabIndex = 0;
            this.lblUsersOnline.Text = "Users Online";
            // 
            // tbpExchange
            // 
            this.tbpExchange.Controls.Add(this.gbxICrypt);
            this.tbpExchange.Controls.Add(this.gbxExchange);
            this.tbpExchange.Location = new System.Drawing.Point(4, 22);
            this.tbpExchange.Name = "tbpExchange";
            this.tbpExchange.Padding = new System.Windows.Forms.Padding(3);
            this.tbpExchange.Size = new System.Drawing.Size(651, 514);
            this.tbpExchange.TabIndex = 1;
            this.tbpExchange.Text = "Exchange";
            this.tbpExchange.UseVisualStyleBackColor = true;
            // 
            // gbxICrypt
            // 
            this.gbxICrypt.Controls.Add(this.btnExchangeDecrypt);
            this.gbxICrypt.Controls.Add(this.btnExchangeEncrypt);
            this.gbxICrypt.Controls.Add(this.lblExchangeICryptResult);
            this.gbxICrypt.Controls.Add(this.txtExchangeICryptResult);
            this.gbxICrypt.Controls.Add(this.wtxtExchangeKey);
            this.gbxICrypt.Controls.Add(this.wtxtExchangeDataToEncryptDecrypt);
            this.gbxICrypt.Controls.Add(this.lblExchangeKey);
            this.gbxICrypt.Controls.Add(this.lblExchangeDataToCryptDecrypt);
            this.gbxICrypt.Location = new System.Drawing.Point(6, 290);
            this.gbxICrypt.Name = "gbxICrypt";
            this.gbxICrypt.Size = new System.Drawing.Size(639, 218);
            this.gbxICrypt.TabIndex = 0;
            this.gbxICrypt.TabStop = false;
            this.gbxICrypt.Text = "Cryptography";
            // 
            // btnExchangeDecrypt
            // 
            this.btnExchangeDecrypt.Location = new System.Drawing.Point(517, 187);
            this.btnExchangeDecrypt.Name = "btnExchangeDecrypt";
            this.btnExchangeDecrypt.Size = new System.Drawing.Size(116, 23);
            this.btnExchangeDecrypt.TabIndex = 14;
            this.btnExchangeDecrypt.Text = "Decrypt";
            this.btnExchangeDecrypt.UseVisualStyleBackColor = true;
            this.btnExchangeDecrypt.Click += new System.EventHandler(this.btnExchangeDecrypt_Click);
            // 
            // btnExchangeEncrypt
            // 
            this.btnExchangeEncrypt.Location = new System.Drawing.Point(395, 187);
            this.btnExchangeEncrypt.Name = "btnExchangeEncrypt";
            this.btnExchangeEncrypt.Size = new System.Drawing.Size(116, 23);
            this.btnExchangeEncrypt.TabIndex = 13;
            this.btnExchangeEncrypt.Text = "Encrypt";
            this.btnExchangeEncrypt.UseVisualStyleBackColor = true;
            this.btnExchangeEncrypt.Click += new System.EventHandler(this.btnExchangeEncrypt_Click);
            // 
            // lblExchangeICryptResult
            // 
            this.lblExchangeICryptResult.AutoSize = true;
            this.lblExchangeICryptResult.Location = new System.Drawing.Point(6, 133);
            this.lblExchangeICryptResult.Name = "lblExchangeICryptResult";
            this.lblExchangeICryptResult.Size = new System.Drawing.Size(42, 13);
            this.lblExchangeICryptResult.TabIndex = 12;
            this.lblExchangeICryptResult.Text = "Result";
            // 
            // txtExchangeICryptResult
            // 
            this.txtExchangeICryptResult.Location = new System.Drawing.Point(51, 118);
            this.txtExchangeICryptResult.Multiline = true;
            this.txtExchangeICryptResult.Name = "txtExchangeICryptResult";
            this.txtExchangeICryptResult.Size = new System.Drawing.Size(582, 63);
            this.txtExchangeICryptResult.TabIndex = 11;
            // 
            // lblExchangeKey
            // 
            this.lblExchangeKey.AutoSize = true;
            this.lblExchangeKey.Location = new System.Drawing.Point(6, 22);
            this.lblExchangeKey.Name = "lblExchangeKey";
            this.lblExchangeKey.Size = new System.Drawing.Size(85, 13);
            this.lblExchangeKey.TabIndex = 8;
            this.lblExchangeKey.Text = "Key (Base64)";
            // 
            // lblExchangeDataToCryptDecrypt
            // 
            this.lblExchangeDataToCryptDecrypt.AutoSize = true;
            this.lblExchangeDataToCryptDecrypt.Location = new System.Drawing.Point(6, 75);
            this.lblExchangeDataToCryptDecrypt.Name = "lblExchangeDataToCryptDecrypt";
            this.lblExchangeDataToCryptDecrypt.Size = new System.Drawing.Size(34, 13);
            this.lblExchangeDataToCryptDecrypt.TabIndex = 9;
            this.lblExchangeDataToCryptDecrypt.Text = "Data";
            // 
            // gbxExchange
            // 
            this.gbxExchange.Controls.Add(this.btnSaveLastData);
            this.gbxExchange.Controls.Add(this.btnExchangeSaveLastDataAsAscii);
            this.gbxExchange.Controls.Add(this.btnExchangeSaveLastData);
            this.gbxExchange.Controls.Add(this.wtxtExchangeResult);
            this.gbxExchange.Controls.Add(this.btnExchangeViewLastData);
            this.gbxExchange.Controls.Add(this.btnExchangeDecryptLastData);
            this.gbxExchange.Controls.Add(this.btnExchangeClearCookies);
            this.gbxExchange.Controls.Add(this.btnExchangeDownloadData);
            this.gbxExchange.Controls.Add(this.btnExchangeUploadValues);
            this.gbxExchange.Controls.Add(this.wtxtExchangeRequest);
            this.gbxExchange.Controls.Add(this.wtxtExchangeUrl);
            this.gbxExchange.Location = new System.Drawing.Point(6, 6);
            this.gbxExchange.Name = "gbxExchange";
            this.gbxExchange.Size = new System.Drawing.Size(639, 278);
            this.gbxExchange.TabIndex = 1;
            this.gbxExchange.TabStop = false;
            this.gbxExchange.Text = "Exchange";
            // 
            // btnSaveLastData
            // 
            this.btnSaveLastData.Location = new System.Drawing.Point(489, 217);
            this.btnSaveLastData.Name = "btnSaveLastData";
            this.btnSaveLastData.Size = new System.Drawing.Size(144, 23);
            this.btnSaveLastData.TabIndex = 11;
            this.btnSaveLastData.Text = "Save Last Data Bytes";
            this.btnSaveLastData.UseVisualStyleBackColor = true;
            this.btnSaveLastData.Click += new System.EventHandler(this.btnSaveLastData_Click);
            // 
            // btnExchangeSaveLastDataAsAscii
            // 
            this.btnExchangeSaveLastDataAsAscii.Location = new System.Drawing.Point(297, 246);
            this.btnExchangeSaveLastDataAsAscii.Name = "btnExchangeSaveLastDataAsAscii";
            this.btnExchangeSaveLastDataAsAscii.Size = new System.Drawing.Size(186, 23);
            this.btnExchangeSaveLastDataAsAscii.TabIndex = 10;
            this.btnExchangeSaveLastDataAsAscii.Text = "Save Last Data as ASCII";
            this.btnExchangeSaveLastDataAsAscii.UseVisualStyleBackColor = true;
            this.btnExchangeSaveLastDataAsAscii.Click += new System.EventHandler(this.btnExchangeSaveLastDataAsAscii_Click);
            // 
            // btnExchangeSaveLastData
            // 
            this.btnExchangeSaveLastData.Location = new System.Drawing.Point(297, 217);
            this.btnExchangeSaveLastData.Name = "btnExchangeSaveLastData";
            this.btnExchangeSaveLastData.Size = new System.Drawing.Size(186, 23);
            this.btnExchangeSaveLastData.TabIndex = 9;
            this.btnExchangeSaveLastData.Text = "Save Last Data as UTF8";
            this.btnExchangeSaveLastData.UseVisualStyleBackColor = true;
            this.btnExchangeSaveLastData.Click += new System.EventHandler(this.btnExchangeSaveLastDataAsUtf8_Click);
            // 
            // btnExchangeViewLastData
            // 
            this.btnExchangeViewLastData.Location = new System.Drawing.Point(146, 217);
            this.btnExchangeViewLastData.Name = "btnExchangeViewLastData";
            this.btnExchangeViewLastData.Size = new System.Drawing.Size(145, 23);
            this.btnExchangeViewLastData.TabIndex = 7;
            this.btnExchangeViewLastData.Text = "View Last Data";
            this.btnExchangeViewLastData.UseVisualStyleBackColor = true;
            this.btnExchangeViewLastData.Click += new System.EventHandler(this.btnExchangeViewLastData_Click);
            // 
            // btnExchangeDecryptLastData
            // 
            this.btnExchangeDecryptLastData.Location = new System.Drawing.Point(146, 246);
            this.btnExchangeDecryptLastData.Name = "btnExchangeDecryptLastData";
            this.btnExchangeDecryptLastData.Size = new System.Drawing.Size(145, 23);
            this.btnExchangeDecryptLastData.TabIndex = 6;
            this.btnExchangeDecryptLastData.Text = "Decrypt Last Data";
            this.btnExchangeDecryptLastData.UseVisualStyleBackColor = true;
            this.btnExchangeDecryptLastData.Click += new System.EventHandler(this.btnExchangeDecryptLastData_Click);
            // 
            // btnExchangeClearCookies
            // 
            this.btnExchangeClearCookies.Location = new System.Drawing.Point(489, 246);
            this.btnExchangeClearCookies.Name = "btnExchangeClearCookies";
            this.btnExchangeClearCookies.Size = new System.Drawing.Size(144, 23);
            this.btnExchangeClearCookies.TabIndex = 5;
            this.btnExchangeClearCookies.Text = "Clear Cookies";
            this.btnExchangeClearCookies.UseVisualStyleBackColor = true;
            this.btnExchangeClearCookies.Click += new System.EventHandler(this.btnExchangeClearCookies_Click);
            // 
            // btnExchangeDownloadData
            // 
            this.btnExchangeDownloadData.Location = new System.Drawing.Point(6, 246);
            this.btnExchangeDownloadData.Name = "btnExchangeDownloadData";
            this.btnExchangeDownloadData.Size = new System.Drawing.Size(134, 23);
            this.btnExchangeDownloadData.TabIndex = 3;
            this.btnExchangeDownloadData.Text = "Download";
            this.btnExchangeDownloadData.UseVisualStyleBackColor = true;
            this.btnExchangeDownloadData.Click += new System.EventHandler(this.btnExchangeDownloadData_Click);
            // 
            // btnExchangeUploadValues
            // 
            this.btnExchangeUploadValues.Location = new System.Drawing.Point(6, 217);
            this.btnExchangeUploadValues.Name = "btnExchangeUploadValues";
            this.btnExchangeUploadValues.Size = new System.Drawing.Size(134, 23);
            this.btnExchangeUploadValues.TabIndex = 2;
            this.btnExchangeUploadValues.Text = "Upload Values";
            this.btnExchangeUploadValues.UseVisualStyleBackColor = true;
            this.btnExchangeUploadValues.Click += new System.EventHandler(this.btnExchangeUploadValues_Click);
            // 
            // tbpLicenseManager
            // 
            this.tbpLicenseManager.Controls.Add(this.btnLicenseManagerSearchProgramName);
            this.tbpLicenseManager.Controls.Add(this.wtxtLicenseManagerSearchProgramName);
            this.tbpLicenseManager.Controls.Add(this.ltvLicenses);
            this.tbpLicenseManager.Location = new System.Drawing.Point(4, 22);
            this.tbpLicenseManager.Name = "tbpLicenseManager";
            this.tbpLicenseManager.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLicenseManager.Size = new System.Drawing.Size(651, 514);
            this.tbpLicenseManager.TabIndex = 2;
            this.tbpLicenseManager.Text = "License Manager";
            this.tbpLicenseManager.UseVisualStyleBackColor = true;
            // 
            // btnLicenseManagerSearchProgramName
            // 
            this.btnLicenseManagerSearchProgramName.Location = new System.Drawing.Point(519, 485);
            this.btnLicenseManagerSearchProgramName.Name = "btnLicenseManagerSearchProgramName";
            this.btnLicenseManagerSearchProgramName.Size = new System.Drawing.Size(126, 23);
            this.btnLicenseManagerSearchProgramName.TabIndex = 2;
            this.btnLicenseManagerSearchProgramName.Text = "Get Program Name";
            this.btnLicenseManagerSearchProgramName.UseVisualStyleBackColor = true;
            this.btnLicenseManagerSearchProgramName.Click += new System.EventHandler(this.btnLicenseManagerSearchProgramName_Click);
            // 
            // ltvLicenses
            // 
            this.ltvLicenses.ContextMenuStrip = this.cmsLicenseManager;
            this.ltvLicenses.FullRowSelect = true;
            this.ltvLicenses.Location = new System.Drawing.Point(6, 6);
            this.ltvLicenses.Name = "ltvLicenses";
            this.ltvLicenses.Size = new System.Drawing.Size(639, 473);
            this.ltvLicenses.TabIndex = 0;
            this.ltvLicenses.UseCompatibleStateImageBehavior = false;
            this.ltvLicenses.View = System.Windows.Forms.View.Details;
            // 
            // cmsLicenseManager
            // 
            this.cmsLicenseManager.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsLicenseManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getLicensesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.copyIDToolStripMenuItem,
            this.copyProgramNameToolStripMenuItem,
            this.copyGUIDToolStripMenuItem,
            this.copyUsernameToolStripMenuItem,
            this.copyPasswordToolStripMenuItem,
            this.toolStripMenuItem1,
            this.changeGUIDToolStripMenuItem,
            this.exportLicenseToolStripMenuItem});
            this.cmsLicenseManager.Name = "contextMenuStrip1";
            this.cmsLicenseManager.Size = new System.Drawing.Size(174, 192);
            // 
            // getLicensesToolStripMenuItem
            // 
            this.getLicensesToolStripMenuItem.Name = "getLicensesToolStripMenuItem";
            this.getLicensesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.getLicensesToolStripMenuItem.Text = "Get Licenses";
            this.getLicensesToolStripMenuItem.Click += new System.EventHandler(this.getLicensesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(170, 6);
            // 
            // copyIDToolStripMenuItem
            // 
            this.copyIDToolStripMenuItem.Name = "copyIDToolStripMenuItem";
            this.copyIDToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.copyIDToolStripMenuItem.Text = "Copy ID";
            this.copyIDToolStripMenuItem.Click += new System.EventHandler(this.copyIDToolStripMenuItem_Click);
            // 
            // copyProgramNameToolStripMenuItem
            // 
            this.copyProgramNameToolStripMenuItem.Name = "copyProgramNameToolStripMenuItem";
            this.copyProgramNameToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.copyProgramNameToolStripMenuItem.Text = "Copy Name";
            this.copyProgramNameToolStripMenuItem.Click += new System.EventHandler(this.copyProgramNameToolStripMenuItem_Click);
            // 
            // copyGUIDToolStripMenuItem
            // 
            this.copyGUIDToolStripMenuItem.Name = "copyGUIDToolStripMenuItem";
            this.copyGUIDToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.copyGUIDToolStripMenuItem.Text = "Copy GUID";
            this.copyGUIDToolStripMenuItem.Click += new System.EventHandler(this.copyGUIDToolStripMenuItem_Click);
            // 
            // copyUsernameToolStripMenuItem
            // 
            this.copyUsernameToolStripMenuItem.Name = "copyUsernameToolStripMenuItem";
            this.copyUsernameToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.copyUsernameToolStripMenuItem.Text = "Copy Username";
            this.copyUsernameToolStripMenuItem.Click += new System.EventHandler(this.copyUsernameToolStripMenuItem_Click);
            // 
            // copyPasswordToolStripMenuItem
            // 
            this.copyPasswordToolStripMenuItem.Name = "copyPasswordToolStripMenuItem";
            this.copyPasswordToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.copyPasswordToolStripMenuItem.Text = "Copy Password";
            this.copyPasswordToolStripMenuItem.Click += new System.EventHandler(this.copyPasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // changeGUIDToolStripMenuItem
            // 
            this.changeGUIDToolStripMenuItem.Name = "changeGUIDToolStripMenuItem";
            this.changeGUIDToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.changeGUIDToolStripMenuItem.Text = "Change GUID";
            this.changeGUIDToolStripMenuItem.Click += new System.EventHandler(this.changeGUIDToolStripMenuItem_Click);
            // 
            // exportLicenseToolStripMenuItem
            // 
            this.exportLicenseToolStripMenuItem.Name = "exportLicenseToolStripMenuItem";
            this.exportLicenseToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exportLicenseToolStripMenuItem.Text = "Export License(s)";
            this.exportLicenseToolStripMenuItem.Click += new System.EventHandler(this.exportLicenseToolStripMenuItem_Click);
            // 
            // tbpSettings
            // 
            this.tbpSettings.Controls.Add(this.gbpSourceAndLatestRelease);
            this.tbpSettings.Controls.Add(this.gbpTutorials);
            this.tbpSettings.Controls.Add(this.gbpSettingsUpdater);
            this.tbpSettings.Controls.Add(this.gbxCredentials);
            this.tbpSettings.Controls.Add(this.gbxSettingsLogger);
            this.tbpSettings.Location = new System.Drawing.Point(4, 22);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSettings.Size = new System.Drawing.Size(651, 514);
            this.tbpSettings.TabIndex = 3;
            this.tbpSettings.Text = "Settings";
            this.tbpSettings.UseVisualStyleBackColor = true;
            // 
            // gbpSourceAndLatestRelease
            // 
            this.gbpSourceAndLatestRelease.Controls.Add(this.llblOpenGitHub);
            this.gbpSourceAndLatestRelease.Controls.Add(this.pbxMe);
            this.gbpSourceAndLatestRelease.Location = new System.Drawing.Point(6, 354);
            this.gbpSourceAndLatestRelease.Name = "gbpSourceAndLatestRelease";
            this.gbpSourceAndLatestRelease.Size = new System.Drawing.Size(257, 154);
            this.gbpSourceAndLatestRelease.TabIndex = 5;
            this.gbpSourceAndLatestRelease.TabStop = false;
            this.gbpSourceAndLatestRelease.Text = "Source and Latest Release";
            // 
            // llblOpenGitHub
            // 
            this.llblOpenGitHub.AutoSize = true;
            this.llblOpenGitHub.Location = new System.Drawing.Point(161, 20);
            this.llblOpenGitHub.Name = "llblOpenGitHub";
            this.llblOpenGitHub.Size = new System.Drawing.Size(79, 13);
            this.llblOpenGitHub.TabIndex = 1;
            this.llblOpenGitHub.TabStop = true;
            this.llblOpenGitHub.Text = "Open GitHub";
            this.llblOpenGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblOpenGitHub_LinkClicked);
            // 
            // pbxMe
            // 
            this.pbxMe.Image = ((System.Drawing.Image)(resources.GetObject("pbxMe.Image")));
            this.pbxMe.Location = new System.Drawing.Point(6, 20);
            this.pbxMe.Name = "pbxMe";
            this.pbxMe.Size = new System.Drawing.Size(149, 128);
            this.pbxMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMe.TabIndex = 0;
            this.pbxMe.TabStop = false;
            // 
            // gbpTutorials
            // 
            this.gbpTutorials.Controls.Add(this.llblNetsealTutorial3);
            this.gbpTutorials.Controls.Add(this.llblNetsealTutorial2);
            this.gbpTutorials.Controls.Add(this.llblNetsealTutorial1);
            this.gbpTutorials.Location = new System.Drawing.Point(6, 245);
            this.gbpTutorials.Name = "gbpTutorials";
            this.gbpTutorials.Size = new System.Drawing.Size(639, 100);
            this.gbpTutorials.TabIndex = 4;
            this.gbpTutorials.TabStop = false;
            this.gbpTutorials.Text = "Tutorials";
            // 
            // llblNetsealTutorial3
            // 
            this.llblNetsealTutorial3.AutoSize = true;
            this.llblNetsealTutorial3.Location = new System.Drawing.Point(6, 72);
            this.llblNetsealTutorial3.Name = "llblNetsealTutorial3";
            this.llblNetsealTutorial3.Size = new System.Drawing.Size(212, 13);
            this.llblNetsealTutorial3.TabIndex = 2;
            this.llblNetsealTutorial3.TabStop = true;
            this.llblNetsealTutorial3.Text = "Cracking NetSeal Part 3 - Exchange";
            this.llblNetsealTutorial3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNetsealTutorial3_LinkClicked);
            // 
            // llblNetsealTutorial2
            // 
            this.llblNetsealTutorial2.AutoSize = true;
            this.llblNetsealTutorial2.Location = new System.Drawing.Point(6, 47);
            this.llblNetsealTutorial2.Name = "llblNetsealTutorial2";
            this.llblNetsealTutorial2.Size = new System.Drawing.Size(210, 13);
            this.llblNetsealTutorial2.TabIndex = 1;
            this.llblNetsealTutorial2.TabStop = true;
            this.llblNetsealTutorial2.Text = "Cracking NetSeal Part 2 - Variables";
            this.llblNetsealTutorial2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNetsealTutorial2_LinkClicked);
            // 
            // llblNetsealTutorial1
            // 
            this.llblNetsealTutorial1.AutoSize = true;
            this.llblNetsealTutorial1.Location = new System.Drawing.Point(6, 23);
            this.llblNetsealTutorial1.Name = "llblNetsealTutorial1";
            this.llblNetsealTutorial1.Size = new System.Drawing.Size(299, 13);
            this.llblNetsealTutorial1.TabIndex = 0;
            this.llblNetsealTutorial1.TabStop = true;
            this.llblNetsealTutorial1.Text = "Cracking NetSeal Part 1 - Cracking a Simple Client";
            this.llblNetsealTutorial1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNetsealTutorial1_LinkClicked);
            // 
            // gbpSettingsUpdater
            // 
            this.gbpSettingsUpdater.Controls.Add(this.cbxCheckDataBaseUpdate);
            this.gbpSettingsUpdater.Location = new System.Drawing.Point(6, 175);
            this.gbpSettingsUpdater.Name = "gbpSettingsUpdater";
            this.gbpSettingsUpdater.Size = new System.Drawing.Size(314, 55);
            this.gbpSettingsUpdater.TabIndex = 3;
            this.gbpSettingsUpdater.TabStop = false;
            this.gbpSettingsUpdater.Text = "Updater";
            // 
            // cbxCheckDataBaseUpdate
            // 
            this.cbxCheckDataBaseUpdate.AutoSize = true;
            this.cbxCheckDataBaseUpdate.Location = new System.Drawing.Point(9, 25);
            this.cbxCheckDataBaseUpdate.Name = "cbxCheckDataBaseUpdate";
            this.cbxCheckDataBaseUpdate.Size = new System.Drawing.Size(212, 17);
            this.cbxCheckDataBaseUpdate.TabIndex = 0;
            this.cbxCheckDataBaseUpdate.Text = "Auto Check DataBase at Startup";
            this.cbxCheckDataBaseUpdate.UseVisualStyleBackColor = true;
            // 
            // gbxCredentials
            // 
            this.gbxCredentials.Controls.Add(this.cbxSaveCredentials);
            this.gbxCredentials.Location = new System.Drawing.Point(331, 175);
            this.gbxCredentials.Name = "gbxCredentials";
            this.gbxCredentials.Size = new System.Drawing.Size(314, 55);
            this.gbxCredentials.TabIndex = 2;
            this.gbxCredentials.TabStop = false;
            this.gbxCredentials.Text = "Credentials";
            // 
            // cbxSaveCredentials
            // 
            this.cbxSaveCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSaveCredentials.AutoSize = true;
            this.cbxSaveCredentials.Enabled = false;
            this.cbxSaveCredentials.Location = new System.Drawing.Point(7, 20);
            this.cbxSaveCredentials.Name = "cbxSaveCredentials";
            this.cbxSaveCredentials.Size = new System.Drawing.Size(124, 17);
            this.cbxSaveCredentials.TabIndex = 1;
            this.cbxSaveCredentials.Text = "Save Credentials";
            this.cbxSaveCredentials.UseVisualStyleBackColor = true;
            // 
            // gbxSettingsLogger
            // 
            this.gbxSettingsLogger.Controls.Add(this.btnClearLog);
            this.gbxSettingsLogger.Controls.Add(this.btnTestErrorMessage);
            this.gbxSettingsLogger.Controls.Add(this.btnRestoreSettings);
            this.gbxSettingsLogger.Controls.Add(this.brnTestWarnMessage);
            this.gbxSettingsLogger.Controls.Add(this.btnTestInfo);
            this.gbxSettingsLogger.Controls.Add(this.cpcmbErrorColor);
            this.gbxSettingsLogger.Controls.Add(this.cpcmbWarningColor);
            this.gbxSettingsLogger.Controls.Add(this.cpcmbInformationColor);
            this.gbxSettingsLogger.Controls.Add(this.btnSaveSettings);
            this.gbxSettingsLogger.Controls.Add(this.cpcmbBackColor);
            this.gbxSettingsLogger.Controls.Add(this.cpcmbTimeColor);
            this.gbxSettingsLogger.Controls.Add(this.lvlErrorColor);
            this.gbxSettingsLogger.Controls.Add(this.lvlWarningColor);
            this.gbxSettingsLogger.Controls.Add(this.lblInformationColor);
            this.gbxSettingsLogger.Controls.Add(this.lvlBackColor);
            this.gbxSettingsLogger.Controls.Add(this.lblTimeColor);
            this.gbxSettingsLogger.Location = new System.Drawing.Point(6, 6);
            this.gbxSettingsLogger.Name = "gbxSettingsLogger";
            this.gbxSettingsLogger.Size = new System.Drawing.Size(639, 163);
            this.gbxSettingsLogger.TabIndex = 0;
            this.gbxSettingsLogger.TabStop = false;
            this.gbxSettingsLogger.Text = "Logger";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(492, 124);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(141, 28);
            this.btnClearLog.TabIndex = 7;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnTestErrorMessage
            // 
            this.btnTestErrorMessage.Location = new System.Drawing.Point(492, 90);
            this.btnTestErrorMessage.Name = "btnTestErrorMessage";
            this.btnTestErrorMessage.Size = new System.Drawing.Size(141, 29);
            this.btnTestErrorMessage.TabIndex = 6;
            this.btnTestErrorMessage.Text = "Test Error Message";
            this.btnTestErrorMessage.UseVisualStyleBackColor = true;
            this.btnTestErrorMessage.Click += new System.EventHandler(this.btnTestErrorMessage_Click);
            // 
            // btnRestoreSettings
            // 
            this.btnRestoreSettings.Location = new System.Drawing.Point(343, 20);
            this.btnRestoreSettings.Name = "btnRestoreSettings";
            this.btnRestoreSettings.Size = new System.Drawing.Size(143, 29);
            this.btnRestoreSettings.TabIndex = 5;
            this.btnRestoreSettings.Text = "Restore Settings";
            this.btnRestoreSettings.UseVisualStyleBackColor = true;
            this.btnRestoreSettings.Click += new System.EventHandler(this.btnRestoreSettings_Click);
            // 
            // brnTestWarnMessage
            // 
            this.brnTestWarnMessage.Location = new System.Drawing.Point(492, 55);
            this.brnTestWarnMessage.Name = "brnTestWarnMessage";
            this.brnTestWarnMessage.Size = new System.Drawing.Size(141, 29);
            this.brnTestWarnMessage.TabIndex = 6;
            this.brnTestWarnMessage.Text = "Test Warn Message";
            this.brnTestWarnMessage.UseVisualStyleBackColor = true;
            this.brnTestWarnMessage.Click += new System.EventHandler(this.brnTestWarnMessage_Click);
            // 
            // btnTestInfo
            // 
            this.btnTestInfo.Location = new System.Drawing.Point(492, 20);
            this.btnTestInfo.Name = "btnTestInfo";
            this.btnTestInfo.Size = new System.Drawing.Size(141, 29);
            this.btnTestInfo.TabIndex = 6;
            this.btnTestInfo.Text = "Test Info Message";
            this.btnTestInfo.UseVisualStyleBackColor = true;
            this.btnTestInfo.Click += new System.EventHandler(this.btnTestInfo_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(343, 55);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(143, 28);
            this.btnSaveSettings.TabIndex = 3;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lvlErrorColor
            // 
            this.lvlErrorColor.AutoSize = true;
            this.lvlErrorColor.Location = new System.Drawing.Point(6, 135);
            this.lvlErrorColor.Name = "lvlErrorColor";
            this.lvlErrorColor.Size = new System.Drawing.Size(71, 13);
            this.lvlErrorColor.TabIndex = 1;
            this.lvlErrorColor.Text = "Error Color";
            // 
            // lvlWarningColor
            // 
            this.lvlWarningColor.AutoSize = true;
            this.lvlWarningColor.Location = new System.Drawing.Point(6, 107);
            this.lvlWarningColor.Name = "lvlWarningColor";
            this.lvlWarningColor.Size = new System.Drawing.Size(72, 13);
            this.lvlWarningColor.TabIndex = 1;
            this.lvlWarningColor.Text = "Warn Color";
            // 
            // lblInformationColor
            // 
            this.lblInformationColor.AutoSize = true;
            this.lblInformationColor.Location = new System.Drawing.Point(6, 79);
            this.lblInformationColor.Name = "lblInformationColor";
            this.lblInformationColor.Size = new System.Drawing.Size(65, 13);
            this.lblInformationColor.TabIndex = 1;
            this.lblInformationColor.Text = "Info Color";
            // 
            // lvlBackColor
            // 
            this.lvlBackColor.AutoSize = true;
            this.lvlBackColor.Location = new System.Drawing.Point(6, 51);
            this.lvlBackColor.Name = "lvlBackColor";
            this.lvlBackColor.Size = new System.Drawing.Size(70, 13);
            this.lvlBackColor.TabIndex = 1;
            this.lvlBackColor.Text = "Back Color";
            // 
            // lblTimeColor
            // 
            this.lblTimeColor.AutoSize = true;
            this.lblTimeColor.Location = new System.Drawing.Point(6, 23);
            this.lblTimeColor.Name = "lblTimeColor";
            this.lblTimeColor.Size = new System.Drawing.Size(70, 13);
            this.lblTimeColor.TabIndex = 1;
            this.lblTimeColor.Text = "Time Color";
            // 
            // wtxtVariables
            // 
            this.wtxtVariables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wtxtVariables.Location = new System.Drawing.Point(6, 22);
            this.wtxtVariables.Name = "wtxtVariables";
            this.wtxtVariables.Size = new System.Drawing.Size(430, 21);
            this.wtxtVariables.TabIndex = 2;
            this.wtxtVariables.WaterMarkColor = System.Drawing.SystemColors.GrayText;
            this.wtxtVariables.WaterMarkFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
            this.wtxtVariables.WaterMarkText = "Variable1, Variable2..";
            // 
            // wtxtTargetPath
            // 
            this.wtxtTargetPath.AllowDrop = true;
            this.wtxtTargetPath.Location = new System.Drawing.Point(6, 20);
            this.wtxtTargetPath.Name = "wtxtTargetPath";
            this.wtxtTargetPath.Size = new System.Drawing.Size(538, 21);
            this.wtxtTargetPath.TabIndex = 9;
            this.wtxtTargetPath.WaterMarkColor = System.Drawing.SystemColors.GrayText;
            this.wtxtTargetPath.WaterMarkFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
            this.wtxtTargetPath.WaterMarkText = "Original Target Path | Drag and Drop the file or press browse";
            this.wtxtTargetPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.wtxtTargetPath_DragDrop);
            this.wtxtTargetPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.wtxtTargetPath_DragEnter);
            // 
            // wtxtPassword
            // 
            this.wtxtPassword.Location = new System.Drawing.Point(187, 47);
            this.wtxtPassword.Name = "wtxtPassword";
            this.wtxtPassword.Size = new System.Drawing.Size(175, 21);
            this.wtxtPassword.TabIndex = 7;
            this.wtxtPassword.UseSystemPasswordChar = true;
            this.wtxtPassword.WaterMarkColor = System.Drawing.SystemColors.GrayText;
            this.wtxtPassword.WaterMarkFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
            this.wtxtPassword.WaterMarkText = "Password";
            // 
            // wtxtId
            // 
            this.wtxtId.Location = new System.Drawing.Point(368, 47);
            this.wtxtId.MaxLength = 8;
            this.wtxtId.Name = "wtxtId";
            this.wtxtId.Size = new System.Drawing.Size(175, 21);
            this.wtxtId.TabIndex = 8;
            this.wtxtId.WaterMarkColor = System.Drawing.SystemColors.GrayText;
            this.wtxtId.WaterMarkFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
            this.wtxtId.WaterMarkText = "ID";
            // 
            // wtxtUsername
            // 
            this.wtxtUsername.Location = new System.Drawing.Point(6, 47);
            this.wtxtUsername.MaxLength = 14;
            this.wtxtUsername.Name = "wtxtUsername";
            this.wtxtUsername.Size = new System.Drawing.Size(175, 21);
            this.wtxtUsername.TabIndex = 6;
            this.wtxtUsername.WaterMarkColor = System.Drawing.SystemColors.GrayText;
            this.wtxtUsername.WaterMarkFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
            this.wtxtUsername.WaterMarkText = "Username";
            // 
            // wtxtExchangeKey
            // 
            this.wtxtExchangeKey.Location = new System.Drawing.Point(97, 22);
            this.wtxtExchangeKey.Name = "wtxtExchangeKey";
            this.wtxtExchangeKey.Size = new System.Drawing.Size(536, 21);
            this.wtxtExchangeKey.TabIndex = 7;
            this.wtxtExchangeKey.WaterMarkColor = System.Drawing.SystemColors.GrayText;
            this.wtxtExchangeKey.WaterMarkFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
            this.wtxtExchangeKey.WaterMarkText = "Empty if you want to use the default key (the one you got in License after log in" +
    ")";
            // 
            // wtxtExchangeDataToEncryptDecrypt
            // 
            this.wtxtExchangeDataToEncryptDecrypt.Location = new System.Drawing.Point(51, 49);
            this.wtxtExchangeDataToEncryptDecrypt.Multiline = true;
            this.wtxtExchangeDataToEncryptDecrypt.Name = "wtxtExchangeDataToEncryptDecrypt";
            this.wtxtExchangeDataToEncryptDecrypt.Size = new System.Drawing.Size(582, 63);
            this.wtxtExchangeDataToEncryptDecrypt.TabIndex = 10;
            this.wtxtExchangeDataToEncryptDecrypt.WaterMarkColor = System.Drawing.SystemColors.GrayText;
            this.wtxtExchangeDataToEncryptDecrypt.WaterMarkFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
            this.wtxtExchangeDataToEncryptDecrypt.WaterMarkText = "Data to encrypt/decrypt";
            // 
            // wtxtExchangeResult
            // 
            this.wtxtExchangeResult.Location = new System.Drawing.Point(6, 136);
            this.wtxtExchangeResult.Multiline = true;
            this.wtxtExchangeResult.Name = "wtxtExchangeResult";
            this.wtxtExchangeResult.Size = new System.Drawing.Size(627, 75);
            this.wtxtExchangeResult.TabIndex = 8;
            this.wtxtExchangeResult.WaterMarkColor = System.Drawing.SystemColors.GrayText;
            this.wtxtExchangeResult.WaterMarkFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
            this.wtxtExchangeResult.WaterMarkText = "Result";
            // 
            // wtxtExchangeRequest
            // 
            this.wtxtExchangeRequest.Location = new System.Drawing.Point(6, 47);
            this.wtxtExchangeRequest.Multiline = true;
            this.wtxtExchangeRequest.Name = "wtxtExchangeRequest";
            this.wtxtExchangeRequest.Size = new System.Drawing.Size(627, 83);
            this.wtxtExchangeRequest.TabIndex = 1;
            this.wtxtExchangeRequest.WaterMarkColor = System.Drawing.SystemColors.GrayText;
            this.wtxtExchangeRequest.WaterMarkFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
            this.wtxtExchangeRequest.WaterMarkText = "Example:\r\n\r\nt = 0123456789\r\nn = Alcatraz";
            // 
            // wtxtExchangeUrl
            // 
            this.wtxtExchangeUrl.Location = new System.Drawing.Point(6, 20);
            this.wtxtExchangeUrl.Name = "wtxtExchangeUrl";
            this.wtxtExchangeUrl.Size = new System.Drawing.Size(627, 21);
            this.wtxtExchangeUrl.TabIndex = 0;
            this.wtxtExchangeUrl.WaterMarkColor = System.Drawing.SystemColors.GrayText;
            this.wtxtExchangeUrl.WaterMarkFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
            this.wtxtExchangeUrl.WaterMarkText = "http://www.example.com/example.php";
            // 
            // wtxtLicenseManagerSearchProgramName
            // 
            this.wtxtLicenseManagerSearchProgramName.Location = new System.Drawing.Point(6, 487);
            this.wtxtLicenseManagerSearchProgramName.Name = "wtxtLicenseManagerSearchProgramName";
            this.wtxtLicenseManagerSearchProgramName.Size = new System.Drawing.Size(507, 21);
            this.wtxtLicenseManagerSearchProgramName.TabIndex = 1;
            this.wtxtLicenseManagerSearchProgramName.WaterMarkColor = System.Drawing.SystemColors.GrayText;
            this.wtxtLicenseManagerSearchProgramName.WaterMarkFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
            this.wtxtLicenseManagerSearchProgramName.WaterMarkText = "Netseal ID";
            // 
            // cpcmbErrorColor
            // 
            this.cpcmbErrorColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cpcmbErrorColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpcmbErrorColor.FormattingEnabled = true;
            this.cpcmbErrorColor.Location = new System.Drawing.Point(82, 132);
            this.cpcmbErrorColor.Name = "cpcmbErrorColor";
            this.cpcmbErrorColor.Size = new System.Drawing.Size(255, 22);
            this.cpcmbErrorColor.TabIndex = 4;
            // 
            // cpcmbWarningColor
            // 
            this.cpcmbWarningColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cpcmbWarningColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpcmbWarningColor.FormattingEnabled = true;
            this.cpcmbWarningColor.Location = new System.Drawing.Point(82, 104);
            this.cpcmbWarningColor.Name = "cpcmbWarningColor";
            this.cpcmbWarningColor.Size = new System.Drawing.Size(255, 22);
            this.cpcmbWarningColor.TabIndex = 4;
            // 
            // cpcmbInformationColor
            // 
            this.cpcmbInformationColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cpcmbInformationColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpcmbInformationColor.FormattingEnabled = true;
            this.cpcmbInformationColor.Location = new System.Drawing.Point(82, 76);
            this.cpcmbInformationColor.Name = "cpcmbInformationColor";
            this.cpcmbInformationColor.Size = new System.Drawing.Size(255, 22);
            this.cpcmbInformationColor.TabIndex = 4;
            // 
            // cpcmbBackColor
            // 
            this.cpcmbBackColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cpcmbBackColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpcmbBackColor.FormattingEnabled = true;
            this.cpcmbBackColor.Location = new System.Drawing.Point(82, 48);
            this.cpcmbBackColor.Name = "cpcmbBackColor";
            this.cpcmbBackColor.Size = new System.Drawing.Size(255, 22);
            this.cpcmbBackColor.TabIndex = 2;
            // 
            // cpcmbTimeColor
            // 
            this.cpcmbTimeColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cpcmbTimeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpcmbTimeColor.FormattingEnabled = true;
            this.cpcmbTimeColor.Location = new System.Drawing.Point(82, 20);
            this.cpcmbTimeColor.Name = "cpcmbTimeColor";
            this.cpcmbTimeColor.Size = new System.Drawing.Size(255, 22);
            this.cpcmbTimeColor.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 563);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.rtbLogger);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::NetSeal_Helper.Properties.Resources.SkullIcon;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetSeal Helper - Alcatraz3222";
            this.tbcMain.ResumeLayout(false);
            this.tbpLicense.ResumeLayout(false);
            this.gbxExtras.ResumeLayout(false);
            this.gbxExtras.PerformLayout();
            this.gbxLicense.ResumeLayout(false);
            this.gbxLicense.PerformLayout();
            this.gbxLicenseDetails.ResumeLayout(false);
            this.gbxLicenseDetails.PerformLayout();
            this.tbpExchange.ResumeLayout(false);
            this.gbxICrypt.ResumeLayout(false);
            this.gbxICrypt.PerformLayout();
            this.gbxExchange.ResumeLayout(false);
            this.gbxExchange.PerformLayout();
            this.tbpLicenseManager.ResumeLayout(false);
            this.tbpLicenseManager.PerformLayout();
            this.cmsLicenseManager.ResumeLayout(false);
            this.tbpSettings.ResumeLayout(false);
            this.gbpSourceAndLatestRelease.ResumeLayout(false);
            this.gbpSourceAndLatestRelease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMe)).EndInit();
            this.gbpTutorials.ResumeLayout(false);
            this.gbpTutorials.PerformLayout();
            this.gbpSettingsUpdater.ResumeLayout(false);
            this.gbpSettingsUpdater.PerformLayout();
            this.gbxCredentials.ResumeLayout(false);
            this.gbxCredentials.PerformLayout();
            this.gbxSettingsLogger.ResumeLayout(false);
            this.gbxSettingsLogger.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLogger;
        private System.Windows.Forms.Button btnInitialize;
        private Controls.WaterMarkTextBox wtxtUsername;
        private Controls.WaterMarkTextBox wtxtPassword;
        private Controls.WaterMarkTextBox wtxtId;
        private Controls.WaterMarkTextBox wtxtTargetPath;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpLicense;
        private System.Windows.Forms.TabPage tbpExchange;
        private System.Windows.Forms.Button btnBrowseTarget;
        private System.Windows.Forms.GroupBox gbxLicenseDetails;
        private System.Windows.Forms.Label lblUsersOnline;
        private System.Windows.Forms.TextBox txtUsersOnline;
        private System.Windows.Forms.TextBox txtUsersCount;
        private System.Windows.Forms.Label lblUsersCount;
        private System.Windows.Forms.TextBox txtUpdateAvaliable;
        private System.Windows.Forms.Label lblUpdateAvailable;
        private System.Windows.Forms.TextBox txtLicenseType;
        private System.Windows.Forms.Label lblLicenseType;
        private System.Windows.Forms.TextBox txtRemainingTime;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.TextBox txtExpirationDate;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.TextBox txtPublicToken;
        private System.Windows.Forms.Label lblPublicToken;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.TextBox txtPrivateKeyBase64;
        private System.Windows.Forms.Label lblPrivateKeyBase64;
        private System.Windows.Forms.TextBox txtPointsCount;
        private System.Windows.Forms.Label lblPointsCount;
        private System.Windows.Forms.Button btnGetVariable;
        private Controls.WaterMarkTextBox wtxtVariables;
        private System.Windows.Forms.Button btnViewNews;
        private System.Windows.Forms.GroupBox gbxLicense;
        private System.Windows.Forms.GroupBox gbxExtras;
        private System.Windows.Forms.Label lblGlobalMessage;
        private System.Windows.Forms.TextBox txtGlobalMessage;
        private Controls.WaterMarkTextBox wtxtExchangeUrl;
        private System.Windows.Forms.GroupBox gbxExchange;
        private System.Windows.Forms.Button btnExchangeUploadValues;
        private Controls.WaterMarkTextBox wtxtExchangeRequest;
        private System.Windows.Forms.Button btnExchangeDownloadData;
        private System.Windows.Forms.Button btnExchangeClearCookies;
        private System.Windows.Forms.Button btnExchangeDecryptLastData;
        private System.Windows.Forms.Label lblExchangeKey;
        private Controls.WaterMarkTextBox wtxtExchangeKey;
        private System.Windows.Forms.GroupBox gbxICrypt;
        private System.Windows.Forms.Button btnExchangeDecrypt;
        private System.Windows.Forms.Button btnExchangeEncrypt;
        private System.Windows.Forms.Label lblExchangeICryptResult;
        private System.Windows.Forms.TextBox txtExchangeICryptResult;
        private Controls.WaterMarkTextBox wtxtExchangeDataToEncryptDecrypt;
        private System.Windows.Forms.Label lblExchangeDataToCryptDecrypt;
        private System.Windows.Forms.Button btnExchangeViewLastData;
        private Controls.WaterMarkTextBox wtxtExchangeResult;
        private System.Windows.Forms.TabPage tbpLicenseManager;
        private System.Windows.Forms.ListView ltvLicenses;
        private System.Windows.Forms.Button btnLicenseManagerSearchProgramName;
        private Controls.WaterMarkTextBox wtxtLicenseManagerSearchProgramName;
        private System.Windows.Forms.ContextMenuStrip cmsLicenseManager;
        private System.Windows.Forms.ToolStripMenuItem getLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem copyIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyProgramNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyGUIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyUsernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeGUIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportLicenseToolStripMenuItem;
        private System.Windows.Forms.Button btnExchangeSaveLastData;
        private System.Windows.Forms.Button btnExchangeSaveLastDataAsAscii;
        private System.Windows.Forms.TabPage tbpSettings;
        private System.Windows.Forms.GroupBox gbxSettingsLogger;
        private System.Windows.Forms.Label lblTimeColor;
        private System.Windows.Forms.Label lvlBackColor;
        private Controls.ColorPickerComboBox cpcmbTimeColor;
        private Controls.ColorPickerComboBox cpcmbBackColor;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblInformationColor;
        private Controls.ColorPickerComboBox cpcmbInformationColor;
        private Controls.ColorPickerComboBox cpcmbErrorColor;
        private Controls.ColorPickerComboBox cpcmbWarningColor;
        private System.Windows.Forms.Label lvlErrorColor;
        private System.Windows.Forms.Label lvlWarningColor;
        private System.Windows.Forms.Button btnRestoreSettings;
        private System.Windows.Forms.Button btnTestErrorMessage;
        private System.Windows.Forms.Button brnTestWarnMessage;
        private System.Windows.Forms.Button btnTestInfo;
        private System.Windows.Forms.GroupBox gbxCredentials;
        private System.Windows.Forms.CheckBox cbxSaveCredentials;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.GroupBox gbpSettingsUpdater;
        private System.Windows.Forms.GroupBox gbpTutorials;
        private System.Windows.Forms.GroupBox gbpSourceAndLatestRelease;
        private System.Windows.Forms.Button btnSaveLastData;
        private System.Windows.Forms.CheckBox cbxCheckDataBaseUpdate;
        private System.Windows.Forms.LinkLabel llblNetsealTutorial1;
        private System.Windows.Forms.LinkLabel llblNetsealTutorial2;
        private System.Windows.Forms.LinkLabel llblNetsealTutorial3;
        private System.Windows.Forms.PictureBox pbxMe;
        private System.Windows.Forms.LinkLabel llblOpenGitHub;
    }
}