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

        internal static List<IdsDataBaseFormat> IDsDataBase = new List<IdsDataBaseFormat>();

        internal static bool IsDataBaseLoaded
        {
            get;
            set;
        }

        internal static void OnDataBaseLoaded()
        {
            IsDataBaseLoaded = true;

            if (DataBaseLoaded != null)
            {
                DataBaseLoaded();
            }
        }

        internal async static void LoadIds(string filePath)
        {
            if (IsDataBaseLoaded)
                return;

            if (!File.Exists(filePath))
                throw new FileNotFoundException("Failed to locate " + Path.GetFileName(filePath));

            await Task.Run(() =>
            {
                foreach (var line in File.ReadLines(filePath))
                {
                    var splitted = line.Split('|');

                    var idDataBase = new IdsDataBaseFormat();
                    idDataBase.MD5Hash = splitted[0];
                    idDataBase.ID = splitted[1];

                    if (splitted.Length > 2)
                    {
                        idDataBase.ProgramName = splitted[2];
                    }
                    IDsDataBase.Add(idDataBase);
                }
            });
            OnDataBaseLoaded();
        }
        internal static string GetProgramNameById(string id)
        {
            string upperId = id.ToUpper();

            if (IsDataBaseLoaded)
                return IDsDataBase.FirstOrDefault(x => x.ID == upperId).ProgramName;
            else
                throw new Exception("The database is not yet loaded");
        }
        internal static string GetIdByMd5Hash(string hash)
        {
            string upperHah = hash.ToUpper();

            if (IsDataBaseLoaded)
                return IDsDataBase.FirstOrDefault(x => x.MD5Hash == upperHah).ID;
            else
                throw new Exception("The database is not yet loaded");
        }
    }
}
