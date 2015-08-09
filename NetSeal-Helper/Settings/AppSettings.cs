using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Drawing;

namespace NetSeal_Helper.Settings
{
    [Serializable]
    public class AppSettings
    {
        [NonSerialized]
        private const string DEFAULT_SETTINGS_NAME = "Settings.xml";

        public static readonly string DEFAULT_TIME_COLOR = SystemColors.GradientInactiveCaption.Name;
        public static readonly string DEFAULT_INFORMATION_COLOR = Color.DeepSkyBlue.Name;
        public static readonly string DEFAULT_WARNING_COLOR = Color.LightGoldenrodYellow.Name;
        public static readonly string DEFAULT_ERROR_COLOR = Color.Peru.Name;
        public static readonly string DEFAULT_BACK_COLOR = SystemColors.WindowFrame.Name;

        public LoggerSettings Logger;
        public LicenseSettings License;
        public bool DataBaseAutoUpdateCheck;

        public static AppSettings Default 
        {
            get
            {
                return new AppSettings()
                {
                    Logger = new LoggerSettings()
                    {
                        TimeColor = DEFAULT_TIME_COLOR,
                        InformationColor = DEFAULT_INFORMATION_COLOR,
                        WarningColor = DEFAULT_WARNING_COLOR,
                        ErrorColor = DEFAULT_ERROR_COLOR,
                        BackColor = DEFAULT_BACK_COLOR,
                    },
                    License = new LicenseSettings()
                    {
                        UserName = string.Empty,
                        Password = string.Empty,
                    },
                    DataBaseAutoUpdateCheck = false,
                };
            }
        }

        public void Save(string filePath = DEFAULT_SETTINGS_NAME)
        {
            var xmlSerializer = new XmlSerializer(typeof(AppSettings));
            var streamWriter = new StreamWriter(filePath, false);
            xmlSerializer.Serialize(streamWriter, this);

            streamWriter.Dispose();
        }
        public static AppSettings Load(string filePath = DEFAULT_SETTINGS_NAME)
        {
            if (File.Exists(filePath))
            {
                var xmlSerializer = new XmlSerializer(typeof(AppSettings));
                var streamReader = new StreamReader(filePath);
                AppSettings appSettings = (AppSettings)xmlSerializer.Deserialize(streamReader);

                streamReader.Dispose();

                return appSettings;
            }
            else
                return null;
        }
    }
}
