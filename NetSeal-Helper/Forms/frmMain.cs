//    Copyright(C) 2015/2016 Alcatraz Developer
//
//    This file is part of NetSeal Helper
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.If not, see<http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetSeal_Helper.NetSeal;
using NetSeal_Helper.NetSeal.Exchange;
using NetSeal_Helper.NetSeal.LicenseManager;
using NetSeal_Helper.Extensions;
using NetSeal_Helper.Logger;
using NetSeal_Helper.Settings;

namespace NetSeal_Helper.Forms
{
    public partial class frmMain : Form
    {
        private const string LICENSE_PATH = "Nimoru\\LicenseSE";
        private const string DATABASE_PATH = "IDs.db";

        private const string GITHUB_PROJECT_URL = "https://github.com/Alcatraz3222/NetSeal-Helper";

        private const string FIRST_TUTORIAL_URL = "https://www.youtube.com/watch?v=BOu2Yrmq7V0";  //Cracking a simple client
        private const string SECOND_TUTORIAL_URL = "https://www.youtube.com/watch?v=pcKD45U61VI"; //Variables
        private const string THIRD_TUTORIAL_URL = "https://www.youtube.com/watch?v=_zN4uq-3TEU";  //Exchange

        private readonly Version AssemblyVersion;

        private List<LicenseFile> Licenses = new List<LicenseFile>();

        RichTextBoxLogger Logger = null;
        License License = null;
        Exchange ExchangeHelper = new Exchange();


        public frmMain()
        {
            InitializeComponent();
            InitializeColumnsAndItems();
            InitializeColorPickers();

            AssemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;

            Logger = new RichTextBoxLogger(rtbLogger);
            LoadSettings();
            
            IdsDataBase.DataBaseLoaded += IdsDataBase_DataBaseLoaded;
            IdsDataBase.DataBaseLoaded += LoadLocalLicenses;

            Logger.LogInformation("The netseal database is being loaded");
            IdsDataBase.LoadIds(DATABASE_PATH);

            this.cbxCheckDataBaseUpdate.CheckedChanged += cbxCheckDataBaseUpdate_CheckedChanged;
        }

        /// <summary>
        /// Occurs when the Netseal database is loaded
        /// </summary>
        private void IdsDataBase_DataBaseLoaded()
        {
            Logger.LogInformation("Netseal database loaded successfully");
        }
        /// <summary>
        /// Retrieves the possible ID of a netseal program by checking .log files
        /// </summary>
        private void RetrieveID()
        {
            var pathName = Path.GetDirectoryName(wtxtTargetPath.Text);

            if (pathName == null)
                return;

            var files = Directory.GetFiles(pathName).Where((x) =>
                {
                    var fileName = Path.GetFileName(x);
                    var regex = new Regex("^[A-Z0-9]{8}.log$");
                    var match = regex.Match(fileName);
                    return !string.IsNullOrEmpty(match.Value);
                }).ToArray<string>();

            if (files.Length == 1)
            {
                this.wtxtId.Text = Path.GetFileNameWithoutExtension(files[0]);
            }
        }
        /// <summary>
        /// Initializes the items of each ColorPickerTextBox
        /// </summary>
        private void InitializeColorPickers()
        {
            var colors = Enum.GetNames(typeof(KnownColor));

            this.cpcmbTimeColor.Items.AddRange(colors);
            this.cpcmbBackColor.Items.AddRange(colors);
            this.cpcmbInformationColor.Items.AddRange(colors);
            this.cpcmbWarningColor.Items.AddRange(colors);
            this.cpcmbErrorColor.Items.AddRange(colors);
        }

        private async void UpdateDataBase()
        {
            var dUpdater = new DataBaseUpdater();
            var updatedLines = await dUpdater.UpdateDataBase(DATABASE_PATH);
            dUpdater?.UpdateDataBase(DATABASE_PATH);
            Logger.LogInformation(updatedLines > 0 
                ? "Updated " + updatedLines + " lines" 
                : "No database update available");

            if (updatedLines > 0)
                IdsDataBase.LoadIds(DATABASE_PATH);
        }


        #region Settings Methods

        /// <summary>
        /// Load application settings
        /// </summary>
        private void LoadSettings()
        {
            var settings = AppSettings.Load() ?? AppSettings.Default;

            if (string.IsNullOrWhiteSpace(settings.SettingsVersion) || new Version(settings.SettingsVersion) < AssemblyVersion)
            {
                settings = AppSettings.Default;
                settings.Save();
            }

            var logger = settings.Logger;

            var timeColor = logger.TimeColor;
            var infoColor = logger.InformationColor;
            var warningColor =logger.WarningColor;
            var errorColor = logger.ErrorColor;
            var backColor = logger.BackColor;

            //Initialize the comboboxes index
            this.cpcmbTimeColor.SelectedIndex = this.cpcmbTimeColor.Items.IndexOf(timeColor);
            this.cpcmbInformationColor.SelectedIndex = this.cpcmbInformationColor.Items.IndexOf(infoColor);
            this.cpcmbWarningColor.SelectedIndex = this.cpcmbWarningColor.Items.IndexOf(warningColor);
            this.cpcmbErrorColor.SelectedIndex = this.cpcmbErrorColor.Items.IndexOf(errorColor);
            this.cpcmbBackColor.SelectedIndex = this.cpcmbBackColor.Items.IndexOf(backColor);

            //Set the logger colors
            if (backColor == "Transparent")
                backColor = Color.White.Name;

            this.rtbLogger.BackColor = Color.FromName(backColor);
            this.Logger.TimeColor = Color.FromName(timeColor);
            this.Logger.InformationColor = Color.FromName(infoColor);
            this.Logger.WarningColor = Color.FromName(warningColor);
            this.Logger.ErrorColor = Color.FromName(errorColor);

            //Database
            this.cbxCheckDataBaseUpdate.Checked = settings.LicenseManager.DataBaseAutoUpdateCheck;
            this.txtUnknownProgramName.Text = settings.LicenseManager.UnknownProgramName;

            Logger.LogInformation("Settings loaded successfully");

            if (cbxCheckDataBaseUpdate.Checked)
                UpdateDataBase();
        }
        /// <summary>
        /// Save current application settings
        /// </summary>
        private void SaveSettings()
        {
            //Logger colors
            var timeColor = this.cpcmbTimeColor.Items[this.cpcmbTimeColor.SelectedIndex].ToString();
            var infoColor = this.cpcmbInformationColor.Items[this.cpcmbInformationColor.SelectedIndex].ToString();
            var warningColor = this.cpcmbWarningColor.Items[this.cpcmbWarningColor.SelectedIndex].ToString();
            var errorColor = this.cpcmbErrorColor.Items[this.cpcmbErrorColor.SelectedIndex].ToString();
            var backColor = this.cpcmbBackColor.Items[this.cpcmbBackColor.SelectedIndex].ToString();

            var settings = new AppSettings();

            settings.SettingsVersion = AssemblyVersion.ToString();

            settings.Logger.TimeColor = timeColor;
            settings.Logger.InformationColor = infoColor;
            settings.Logger.WarningColor = warningColor;
            settings.Logger.ErrorColor = errorColor;
            settings.Logger.BackColor = backColor;

            //Database
            settings.LicenseManager.DataBaseAutoUpdateCheck = this.cbxCheckDataBaseUpdate.Checked;
            settings.LicenseManager.UnknownProgramName = this.txtUnknownProgramName.Text;

            settings.Save();
            Logger.LogInformation("Settins saved successfully, reloading settings");
            LoadSettings();
        }
        /// <summary>
        /// Save default settings
        /// </summary>
        private void SaveDefaultSettings()
        {
            AppSettings.Default.Save();
            Logger.LogInformation("Settins restored successfully, reloading settings");
            LoadSettings();
        }

        #endregion

        #region Settings Events

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
        private void btnRestoreSettings_Click(object sender, EventArgs e)
        {
            SaveDefaultSettings();
        }
        private void btnTestInfo_Click(object sender, EventArgs e)
        {
            Logger.LogInformation("Testing Info Color");
        }
        private void brnTestWarnMessage_Click(object sender, EventArgs e)
        {
            Logger.LogWarning("Testing Warn Color");
        }
        private void btnTestErrorMessage_Click(object sender, EventArgs e)
        {
            Logger.LogError("Testing Error Color");
        }
        private void btnClearLog_Click(object sender, EventArgs e)
        {
            this.Logger.Clear();
        }

        private void llblNetsealTutorial1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(FIRST_TUTORIAL_URL);
        }
        private void llblNetsealTutorial2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(SECOND_TUTORIAL_URL);
        }
        private void llblNetsealTutorial3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(THIRD_TUTORIAL_URL);
        }

        private void llblOpenGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(GITHUB_PROJECT_URL);
        }

        private void cbxCheckDataBaseUpdate_CheckedChanged(object sender, EventArgs e)
        {
            this.SaveSettings();
        }

        #endregion


        #region License Methods

        /// <summary>
        /// Check license status
        /// </summary>
        private void CheckStatus()
        {
            var value = License.LastData[0];
            string message = string.Empty;

            switch ((LoginStatus)value)
            {
                case LoginStatus.Success:
                    break;
                case LoginStatus.Failed:
                    message = "Failed to log in";
                    break;
                case LoginStatus.BadParams:
                    message = "Bad parameters, not sure what's this";
                    break;
                case LoginStatus.BadLength:
                    message = "Bad Length";
                    break;
                case LoginStatus.InvalidChars:
                    message = "Your username contains invalid characters";
                    break;
                case LoginStatus.NullValue:
                    message = "No license has been found, make sure you redeemed the code";
                    break;
                case LoginStatus.UsedValue:
                    message = "Used value";
                    break;
                case LoginStatus.AccessDenied:
                    message = "Access denied, check your username, password and ID";
                    break;
                case LoginStatus.LimitReached:
                    message = "Limit Reached";
                    break;
                case LoginStatus.Expired:
                    message = "Your license has expired";
                    break;
                case LoginStatus.Locked:
                    message = "Your license is locked";
                    break;
                case LoginStatus.Banned:
                    var data = new byte[License.LastData.Length - 1];
                    Buffer.BlockCopy(License.LastData, 1, data, 0, data.Length);

                    string banReason = data.ToUtf8String();
                    message = "Your account is banned by the following reason: " + banReason;
                    break;
                case LoginStatus.SystemOffline:
                    message = "Netseal system is offline or your IP is locked";
                    break;
                default:
                    if (value != 48 && //
                        value != 49 && //
                        value != 50 && // When get the LastData after Sanction, returns the license type, which are these
                        value != 51 && //
                        value != 52 && //
                        value != 53)   //
                    {
                        message = "Uknown error code, contact me for fix this issue";
                    }
                    break;
            }
            if (!string.IsNullOrEmpty(message))
            {
                Logger.LogWarning(message + ", error code: " + (byte)value);
            }
        }
        /// <summary>
        /// Initializes the netseal login process
        /// </summary>
        private async void Initialize()
        {
            try
            {
                this.btnInitialize.Enabled = false;

                if (File.Exists(LICENSE_PATH))
                    License = new License(LICENSE_PATH);
                else
                {
                    Logger.LogError("Failed to load the License library, make sure the file at " + LICENSE_PATH + " exists");
                    return;
                }

                var licenseReader = new LicenseReader();
                var licenseFile = licenseReader.ReadLocaLicense(wtxtId.Text);
                if (string.IsNullOrEmpty(licenseFile.GUID))
                {
                    Logger.LogWarning("No license found for this program, make sure you have a license of this program in your computer and try again");
                    return;
                }

                License.SetID(wtxtId.Text);
                License.SetGUID(licenseFile.GUID);
                License.RunWE(wtxtTargetPath.Text);
                Logger.LogInformation("RunWE initialized succesfully");

                var password = this.wtxtPassword.Text;

                if (!await Exchange())
                    return;
                if (!await SignIn(wtxtUsername.Text, password.GetSHA1("x2")))
                    return;
                if (!await GetStatus())
                    return;
                if (!await Sanction())
                    return;

                LoadLicenseDetails();
            }
            finally
            {
                this.btnInitialize.Enabled = true;
            }
        }
        /// <summary>
        /// Load Netseal License details
        /// </summary>
        private async void LoadLicenseDetails()
        {
            //Clear Textboxes
            txtUsersCount.Clear();
            txtUsersOnline.Clear();
            txtLicenseType.Clear();
            txtExpirationDate.Clear();
            txtPointsCount.Clear();
            txtUpdateAvaliable.Clear();
            txtRemainingTime.Clear();
            txtPublicToken.Clear();
            txtPrivateKey.Clear();
            txtPrivateKeyBase64.Clear();
            txtGlobalMessage.Clear();


            Logger.LogInformation("Loading licence details");

            //Users Online            
            var usersOnline = await Task.Run(() => License.UsersOnline.ToString());
            this.txtUsersOnline.Text = usersOnline;


            //Users Count
            var usersCount = await Task.Run(() => License.UsersCount.ToString());
            this.txtUsersCount.Text = usersCount;


            //Global Message
            var globalMessage = await Task.Run(() => License.GlobalMessage);
            this.txtGlobalMessage.Text = globalMessage;


            //Update Available
            var isUpdateAvailable = await Task.Run(() => License.UpdateAvailable.ToString());
            this.txtUpdateAvaliable.Text = isUpdateAvailable;


            //License Type
            var licenseType = await Task.Run(() => License.LicenseType.ToString());
            this.txtLicenseType.Text = licenseType;


            //Expiration Date
            var expiration = await Task.Run(() => License.Expiration);
            if (expiration.Year > 4000)
                this.txtExpirationDate.Text = "Never";
            else
                this.txtExpirationDate.Text = expiration.ToString();


            //Remaining Time
            var remaining = await Task.Run(() => License.RemainingTime.ToString());
            remaining = remaining == "00:00:00" ? "Unlimited" : remaining;
            this.txtRemainingTime.Text = remaining;


            //Public Token
            var publicToken = await Task.Run(() => License.PublicToken);
            this.txtPublicToken.Text = publicToken;


            //Private Key
            var finalKey = new StringBuilder();
            var privateKey = await Task.Run(() => License.PrivateKey);

            for (int index = 0; index < privateKey.Length; index++)
            {
                finalKey.Append(privateKey[index].ToString("X2"));

                if (privateKey.Length - 1 > index)
                    finalKey.Append(", ");
            }
            this.txtPrivateKey.Text = finalKey.ToString();
            this.txtPrivateKeyBase64.Text = privateKey.ToBase64String();


            //Points Count
            var pointsCount = await Task.Run(() => License.PointsCount.ToString());
            this.txtPointsCount.Text = pointsCount;


            Logger.LogInformation("License details loaded");
        }
        /// <summary>
        /// Get a netseal variable
        /// </summary>
        /// <param name="varName">Variable name</param>
        /// <returns></returns>
        private Task<string> GetVariable(string varName)
        {
            return Task.Run(() =>
            {
                return License.GetVariable(varName);
            });
        }

        /// <summary>
        /// Starts and checks if the Netseal Exchange is done successful
        /// </summary>
        /// <returns></returns>
        private Task<bool> Exchange()
        {
            return Task.Run(() =>
            {
                var exchange = License.Exchange();

                if (exchange)
                    Logger.LogInformation("Exchange done");
                else
                    Logger.LogError("Exchange failed");

                CheckStatus();
                return exchange;
            });
        }
        /// <summary>
        /// Sing In netseal
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        private Task<bool> SignIn(string username, string password)
        {
            return Task.Run(() =>
            {
                var joined = License.SignIn(username, password);

                if (joined)
                    Logger.LogInformation("Sign In done");
                else
                    Logger.LogError("Failed to SignIn");

                CheckStatus();
                return joined;
            });
        }
        /// <summary>
        /// Gets netseal status
        /// </summary>
        /// <returns></returns>
        private Task<bool> GetStatus()
        {
            return Task.Run(() =>
            {
                bool status = License.GetStatus();

                if (status)
                    Logger.LogInformation("Get status ok");
                else
                    Logger.LogError("Get status failed");

                CheckStatus();
                return status;
            });
        }
        /// <summary>
        /// Checks if your license is sanctioned
        /// </summary>
        /// <returns></returns>
        private Task<bool> Sanction()
        {
            return Task.Run(() =>
            {
                bool sanction = License.Sanction();

                if (sanction)
                    Logger.LogInformation("Sanction is ok");
                else
                    Logger.LogError("Sanction failed");

                CheckStatus();
                return sanction;
            });
        }

        #endregion

        #region License Events

        private void btnBrowseTarget_Click(object sender, EventArgs e)
        {
            using (var browseTarget = new OpenFileDialog())
            {
                browseTarget.Title = "Select the target";
                browseTarget.Multiselect = false;
                browseTarget.Filter = "Executable File|*.exe";

                var result = browseTarget.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.wtxtTargetPath.Text = browseTarget.FileName;
                    RetrieveID();
                }
            }
        }
        private void btnInitialize_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(wtxtUsername.Text) &&
                !string.IsNullOrWhiteSpace(wtxtPassword.Text) &&
                !string.IsNullOrWhiteSpace(wtxtId.Text) &&
                !string.IsNullOrWhiteSpace(wtxtTargetPath.Text))
            {
                Initialize();
            }
            else
                Logger.LogWarning("Some data is missing");
        }

        private void wtxtTargetPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
        private void wtxtTargetPath_DragDrop(object sender, DragEventArgs e)
        {
            var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0].ToString();

            if (Path.GetExtension(path).ToLower() == ".exe")
            {
                this.wtxtTargetPath.Text = path;
                RetrieveID();
            }
        }

        private async void btnGetVariable_Click(object sender, EventArgs e)
        {
            var variables = wtxtVariables.Text.Split(',');

            foreach(var variable in variables)
            {
                var variableName = variable.Trim();
                if (!string.IsNullOrWhiteSpace(variableName))
                {
                    Logger.LogInformation(
                        string.Format("Variable \"{0}\" = \"{1}\"", variableName, await GetVariable(variableName)));
                }
            }
        }
        private async void btnViewNews_Click(object sender, EventArgs e)
        {
            if(License == null)
                return;

            Logger.LogInformation("Getting news, this might take a while");

            var newsObjects = await Task.Run(() => License.GetNews());
            var newsList = new List<NewsPost>();

            if (newsObjects.Length % 3 == 0)
            {
                for (int index = 0; index < newsObjects.Length; index += 3)
                {
                    var newsPost = new NewsPost();
                    newsPost.ID = (int)newsObjects[index];
                    newsPost.Name = (string)newsObjects[index + 1];
                    newsPost.Time = (DateTime)newsObjects[index + 2];
                    newsPost.PostMessage = await Task.Run(() => License.GetPostMessage(newsPost.ID));
                    newsList.Add(newsPost);
                }
                var newsForm = new frmNews(newsList);
                newsForm.ShowDialog();
                newsForm.Dispose();
            }
            else
                Logger.LogError("Something went wrong getting the news");

            newsObjects = null;
            newsList.Clear();
        }

        #endregion


        #region Exchange Methods

        /// <summary>
        /// Makes a web connection through a POST method
        /// </summary>
        /// <param name="address"></param>
        /// <param name="collection"></param>
        private async void UploadValues(string address, NameValueCollection collection)
        {
            try
            {
                var result = await Task.Run(() => ExchangeHelper.UploadValues(address, collection));
                Logger.LogInformation("Upload done, received " + result.Length + " bytes");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
            }
        }
        /// <summary>
        /// Downloads data from a website
        /// </summary>
        /// <param name="address"></param>
        private async void DownloadData(string address)
        {
            try
            {
                var download = await Task.Run(() => ExchangeHelper.DownloadData(address));
                Logger.LogInformation("Downloaded " + download.Length + " bytes");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
            }
        }

        /// <summary>
        /// Save Exchange Last Data with any accepted encoding
        /// </summary>
        /// <param name="encoding"></param>
        private void SaveLastData(Encoding encoding)
        {
            if (ExchangeHelper.LastData == null)
            {
                Logger.LogWarning("Last data is null");
                return;
            }

            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Select where you want to save the last data";
                saveDialog.Filter = "Text File|*.txt|All Files|*.*";

                var result = saveDialog.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    using (var stream = new StreamWriter(saveDialog.FileName))
                    {
                        stream.Write(encoding.GetString(ExchangeHelper.LastData));
                        stream.Close();
                    }
                }
            }
        }
        /// <summary>
        /// Save Exchange Lasta Data Bytes
        /// </summary>
        private void SaveLastData()
        {
            if (ExchangeHelper.LastData == null)
            {
                Logger.LogWarning("Last data is null");
                return;
            }

            var saveDialog = new SaveFileDialog();
            saveDialog.Title = "Select where you want to save the last data";
            saveDialog.Filter = "Text File|*.txt|All Files|*.*";

            var result = saveDialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllBytes(saveDialog.FileName, ExchangeHelper.LastData);
            }
            saveDialog.Dispose();
        }
        #endregion

        #region Exchange Events

        private void btnExchangeUploadValues_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.wtxtExchangeRequest.Text) ||
                string.IsNullOrWhiteSpace(this.wtxtExchangeUrl.Text))
                return;

            var lines = this.wtxtExchangeRequest.Lines;
            var collection = new NameValueCollection();

            foreach (var line in lines)
            {
                var command = line.Split('=');
                collection.Add(command[0].Trim(), command[1].Trim());
            }
            this.UploadValues(wtxtExchangeUrl.Text, collection);
        }
        private void btnExchangeDownloadData_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(wtxtExchangeUrl.Text))
            {
                DownloadData(wtxtExchangeUrl.Text);
            }
        }
        private void btnExchangeClearCookies_Click(object sender, EventArgs e)
        {
            ExchangeHelper.ClearCookies();
            Logger.LogInformation("Cookies cleared");
        }
        private void btnExchangeDecryptLastData_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExchangeHelper.LastData == null)
                    return;

                var decrypted = ExchangeHelper.Decrypt(ExchangeHelper.LastData, License.PrivateKey);
                //this.wtxtExchangeResult.Text = decrypted.ToUtf8String(); //Press View last data instead
                Logger.LogInformation("Last data decrypted Successfully");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
            }
        }
        private void btnExchangeViewLastData_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExchangeHelper.LastData == null)
                    return;

                this.wtxtExchangeResult.Text = ExchangeHelper.LastData.ToAsciiString();
                Logger.LogInformation("Viewing last data");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
            }
        }
        private void btnExchangeSaveLastDataAsUtf8_Click(object sender, EventArgs e)
        {
            SaveLastData(new UTF8Encoding());
        }
        private void btnExchangeSaveLastDataAsAscii_Click(object sender, EventArgs e)
        {
            SaveLastData(new ASCIIEncoding());
        }
        private void btnSaveLastData_Click(object sender, EventArgs e)
        {
            SaveLastData();
        }

        private void btnExchangeEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                var key = License.PrivateKey;

                if (!string.IsNullOrWhiteSpace(this.wtxtExchangeKey.Text))
                    key = wtxtExchangeKey.Text.FromBase64String();

                this.txtExchangeICryptResult.Text = ExchangeHelper.Encrypt(wtxtExchangeDataToEncryptDecrypt.Text.GetAsciiBytes(), key);

                Logger.LogInformation("Text encrypted");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
            }
        }
        private void btnExchangeDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                var key = License.PrivateKey;

                if (!string.IsNullOrWhiteSpace(this.wtxtExchangeKey.Text))
                    key = wtxtExchangeKey.Text.FromBase64String();

                this.txtExchangeICryptResult.Text = ExchangeHelper.Decrypt(wtxtExchangeDataToEncryptDecrypt.Text.FromBase64String(), key).ToAsciiString();

                Logger.LogInformation("Text decrypted");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
            }
        }

        #endregion


        #region License Manager Methods

        /// <summary>
        /// Initializes the columns and sizes of the LicenseManager ListView
        /// </summary>
        private void InitializeColumnsAndItems()
        {
            //License Manager
            this.ltvLicenses.Columns.Add("ID").Width = 80;
            this.ltvLicenses.Columns.Add("Program Name").Width = 140;
            this.ltvLicenses.Columns.Add("GUID").Width = 105;
            this.ltvLicenses.Columns.Add("Remember").Width = 75;
            this.ltvLicenses.Columns.Add("Username").Width = 100;
            this.ltvLicenses.Columns.Add("Password (SHA1)").Width = 115;
        }
        /// <summary>
        /// Load your Netseal Licenses
        /// </summary>
        private void LoadLocalLicenses()
        {
            this.ltvLicenses.Items.Clear();

            Logger.LogInformation("Loading local license(s)");

            var licenseReader = new LicenseReader();
            if (!Directory.Exists(licenseReader.LocalPath))
            {
                Logger.LogWarning("No license(s) found");
                return;
            }

            var files = Directory.GetFiles(licenseReader.LocalPath).Where((x) =>
            {
                var fileName = Path.GetFileNameWithoutExtension(x);
                return fileName.Length == 32;
            });

            var counter = 0;

            foreach (var file in files)
            {
                try
                {
                    var fileName = Path.GetFileNameWithoutExtension(file);
                    var dbTuple = IdsDataBase.IDsDataBase[fileName];
                    var id = dbTuple.Item1; //Netseal ID
                    var programName = dbTuple.Item2; //Netseal program name

                    if (!string.IsNullOrEmpty(id))
                    {
                        var licenseFile = licenseReader.ReadLicenseFrom(file, id);
                        //Store the license
                        Licenses.Add(licenseFile);

                        programName = !string.IsNullOrEmpty(programName) ? programName : this.txtUnknownProgramName.Text;

                        ltvLicenses.Items.Add(id).SubItems.AddRange(new string[]
                        {
                            programName,
                            licenseFile.GUID,
                            licenseFile.Remember.ToString(),
                            licenseFile.Username,
                            licenseFile.Sha1Password,
                        });
                        counter++;
                    }
                }
                catch
                {
                    continue;
                }
            }
            Logger.LogInformation("Loaded " + counter + " license(s)");
        }
        /// <summary>
        /// Copy a subitem of the License Manger ListView at the selected index
        /// </summary>
        /// <param name="cellIndex">Index of the SubItem you want to get</param>
        private void CopyLicenseItemToClipboard(short cellIndex)
        {
            var columnName = ltvLicenses.Columns[cellIndex].Text;

            if (ltvLicenses.SelectedIndices.Count > 0)
            {
                var text = ltvLicenses.GetSubItemTextFromSelectedIndex(cellIndex);
                Clipboard.SetText(string.IsNullOrEmpty(text) ? "\0" : text);
                Logger.LogInformation(columnName + " copied to clipboard");
            }
            else
                Logger.LogError("Failed to copy " + columnName);
        }

        #endregion

        #region License Manager Events

        private void btnLicenseManagerSearchProgramName_Click(object sender, EventArgs e)
        {
            this.btnLicenseManagerSearchProgramName.Enabled = false;

            try
            {
                var id = wtxtLicenseManagerSearchProgramName.Text;
                var tuple = IdsDataBase.IDsDataBase.Values.FirstOrDefault(x => x.Item1 == id);
                var programName = string.Empty;

                if (tuple != null)
                    programName = tuple.Item2;

                if (!string.IsNullOrEmpty(programName))
                    Logger.LogInformation("Found: " + programName);
                else
                    Logger.LogWarning("No name found for: " + id);
            }
            finally
            {
                this.btnLicenseManagerSearchProgramName.Enabled = true;
            }
        }

        private void getLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLocalLicenses();
        }

        private void copyIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyLicenseItemToClipboard(0);
        }
        private void copyProgramNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyLicenseItemToClipboard(1);
        }
        private void copyGUIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyLicenseItemToClipboard(2);
        }
        private void copyUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyLicenseItemToClipboard(4);
        }
        private void copyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyLicenseItemToClipboard(5);
        }

        private void changeGUIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ltvLicenses.SelectedIndices.Count <= 0)
                return;

            if (MessageBox.Show("Are you sure you want to change your GUID, your license may stop working after", "GUID", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                return;


            var originalGuid = ltvLicenses.GetSubItemTextFromSelectedIndex(2);
            using (var guidForm = new frmGUIDChanger(originalGuid))
            {
                var result = guidForm.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    if (guidForm.NewGUID.Length != 32)
                    {
                        Logger.LogWarning("Invalid GUID");
                        return;
                    }
                    var index = ltvLicenses.SelectedIndices[0];
                    var licenseFile = Licenses[index];
                    licenseFile.GUID = guidForm.NewGUID;
                    Licenses[index] = licenseFile;

                    var writer = new LicenseWriter();
                    writer.WriteLicense(
                        writer.LocalPath + licenseFile.LicenseName,
                        licenseFile.ID,
                        licenseFile);

                    Logger.LogInformation("GUID changed, reloading licenses");
                    LoadLocalLicenses();
                }
            }

        }
        private void exportLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                var result = folderDialog.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    var path = folderDialog.SelectedPath;
                    var licenseWriter = new LicenseWriter();

                    int counter = 0;
                    for (int index = 0; index < ltvLicenses.SelectedIndices.Count; index++)
                    {
                        var license = this.Licenses[ltvLicenses.SelectedIndices[index]];
                        licenseWriter.WriteLicense(
                            path + "\\" + license.LicenseName,
                            license.ID,
                            license,
                            FileAttributes.Normal);

                        counter++;
                    }
                    Logger.LogInformation("Exported " + counter + " licenses");
                }
            }
        }

        #endregion


        #region Logger

        private void exportLogToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            using (var dialog = new SaveFileDialog())
            {
                dialog.ShowHelp = false;
                dialog.Filter = "Text File|.txt";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var log = this.rtbLogger.Text.Split('\n');
                    File.WriteAllLines(dialog.FileName, log);
                    Logger.LogInformation("Log Exported Successfully");
                }
            }
        }

        #endregion
        
    }
}