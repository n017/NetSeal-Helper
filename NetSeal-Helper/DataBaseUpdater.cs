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
                try
                {
                    var client = new WebClient();
                    var dataToUpdate = client.DownloadString(UPDATE_ADDRESS).Split(new string[] { "\r\n" }, StringSplitOptions.None);
                                        
                    while (!IdsDataBase.IsDataBaseLoaded) { } //wait until the database is loaded

                    int changedLines = 0;
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
                    return 0;
                }
            });
        }
    }
}