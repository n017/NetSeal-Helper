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
using System.Xml.Serialization;
using System.IO;
using System.Drawing;
using System.Reflection;

namespace NetSeal_Helper.Settings
{
    [Serializable]
    public class AppSettings
    {
        [NonSerialized]
        private const string DEFAULT_SETTINGS_NAME = "Settings.xml";

        public static readonly string DEFAULT_TIME_COLOR = SystemColors.GradientInactiveCaption.Name;
        //public static readonly string DEFAULT_TIME_COLOR = Color.Salmon.Name;
        public static readonly string DEFAULT_INFORMATION_COLOR = Color.DeepSkyBlue.Name;
        public static readonly string DEFAULT_WARNING_COLOR = Color.LightGoldenrodYellow.Name;
        //public static readonly string DEFAULT_ERROR_COLOR = Color.Peru.Name;
        public static readonly string DEFAULT_ERROR_COLOR = Color.Tomato.Name;
        public static readonly string DEFAULT_BACK_COLOR = SystemColors.WindowFrame.Name;

        public string SettingsVersion = string.Empty;

        public LoggerSettings Logger;
        public LicenseSettings License;
        public LicenseManagerSettings LicenseManager;

        /// <summary>
        /// Returns the Default settings
        /// </summary>
        public static AppSettings Default 
        {
            get
            {
                return new AppSettings()
                {
                    SettingsVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString(),

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
                    LicenseManager = new LicenseManagerSettings()
                    {
                        DataBaseAutoUpdateCheck = false,
                        UnknownProgramName = "~"
                    }
                };
            }
        }

        /// <summary>
        /// Saves all the settings to a new file
        /// </summary>
        /// <param name="filePath">Path and name where the settings file will be saved</param>
        public void Save(string filePath = DEFAULT_SETTINGS_NAME)
        {
            var xmlSerializer = new XmlSerializer(typeof(AppSettings));
            using (var streamWriter = new StreamWriter(filePath, false))
            {
                xmlSerializer.Serialize(streamWriter, this);
            }            
        }
        /// <summary>
        /// Loads all the settings from a settings file
        /// </summary>
        /// <param name="filePath">Path and name from where the settings file will be loaded</param>
        /// <returns></returns>
        public static AppSettings Load(string filePath = DEFAULT_SETTINGS_NAME)
        {
            if (File.Exists(filePath))
            {
                var xmlSerializer = new XmlSerializer(typeof(AppSettings));
                using (var streamReader = new StreamReader(filePath))
                {
                    AppSettings appSettings = (AppSettings)xmlSerializer.Deserialize(streamReader);
                    return appSettings;
                }                
            }
            else
                return null;
        }
    }
}
