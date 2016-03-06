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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSeal_Helper
{
    class IdsDataBase
    {
        public static event Action DataBaseLoaded;

        internal static Dictionary<string, Tuple<string, string>> IDsDataBase = new Dictionary<string, Tuple<string, string>>();

        internal static bool IsDataBaseLoaded
        {
            get;
            set;
        }

        internal static void OnDataBaseLoaded()
        {
            IsDataBaseLoaded = true;
            DataBaseLoaded?.Invoke();
        }

        internal async static void LoadIds(string filePath)
        {
            if (IsDataBaseLoaded)
                return;

            if (!File.Exists(filePath))
            {
                System.Windows.Forms.MessageBox.Show("Failed to locate " + Path.GetFileName(filePath));
                return;
            }

            await Task.Run(() =>
            {
                foreach (var line in File.ReadLines(filePath))
                {
                    var splittedLine = line.Split('|');
                    var md5Hash = splittedLine[0];
                    var netsealId = splittedLine[1];
                    var programName = string.Empty;

                    if (splittedLine.Length > 2)
                        programName = splittedLine[2];

                    IDsDataBase[md5Hash] = new Tuple<string, string>(netsealId, programName);
                }
            });
            OnDataBaseLoaded();
        }
    }
}