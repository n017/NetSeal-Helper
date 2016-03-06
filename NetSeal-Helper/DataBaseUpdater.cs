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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using NetSeal_Helper.Extensions;

namespace NetSeal_Helper
{
    class DataBaseUpdater
    {
        //Pastebin is locked in some countries
        private const string UPDATE_ADDRESS = "http://pastebin.com/raw.php?i=ZgJ54Kdj";
        private const string MD5_CHEKSUM = "http://pastebin.com/raw.php?i=tdtX0vVT";

        public DataBaseUpdater()
        {

        }

        [Obsolete("Use UpdateDataBase Instead", true)]
        internal Task<bool> CheckForUpdate(string databasePath)
        {
            return Task.Run(() =>
            {
                try
                {
                    var client = new WebClient();
                    var checksum = client.DownloadString(MD5_CHEKSUM);

                    //this way sucks, since the user must be able to change the database

                    if (checksum.ToUpper() != File.ReadAllBytes(databasePath).GetMD5("X2"))
                        return true; 

                    return false;
                }
                catch
                {
                    return false;
                }
            });
        }
        internal Task<int> UpdateDataBase(string databasePath)
        {
            return Task<int>.Run(() => 
            {
                int changedLines = 0;

                try
                {
                    var client = new WebClient();
                    var dataToUpdate = client.DownloadString(UPDATE_ADDRESS).Split(new string[] { "\r\n" }, StringSplitOptions.None);
                                        
                    while (!IdsDataBase.IsDataBaseLoaded) { } //wait until the database is loaded

                    var dbLines = File.ReadAllLines(databasePath);
                    foreach (var lineToUpdate in dataToUpdate)
                    {
                        var split = lineToUpdate.Split('-');

                        var line = int.Parse(split[0]);
                        var content = split[1];

                        if (dbLines[line] == content)
                            continue;

                        dbLines[line] = content;
                        changedLines++;
                    }
                    if (changedLines > 0)
                        File.WriteAllLines(databasePath, dbLines);
                    return changedLines;
                }
                catch
                {
                    return changedLines;
                }
            });
        }
    }
}