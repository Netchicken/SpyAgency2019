using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SpyAgency.Data
{
    static class FileOperations
    {


        /// <summary>
        /// List all the files in the current directory  = Read
        /// </summary>
        /// <returns>list of files</returns>
        public static List<string> ListAllFiles()
        {
            List<string> details = new List<string>();
            try
            {
                String Path = Application.StartupPath + @"\";
                // loop through the directory and get all the file names with a .txt suffix
                foreach (String file in Directory.GetFiles(Path))
                {
                    FileInfo info = new FileInfo(file);
                    if (info.Extension == ".txt")
                    {
                        details.Add(info.Name);
                    }
                }

                if (details.Count == 0)
                {
                    details.Add("No Spies");

                }

                return details;
            }
            catch (Exception)
            {
                details.Add("No Spies");
                return details;
            }
        }
        /// <summary>
        ///  Read in lines from file.
        /// </summary>
        /// <returns>List of file details</returns>
        public static List<string> ReturnFileData(string ChosenFileName)
        {
            List<string> details = new List<string>();
            try
            {
                string filename = Application.StartupPath + @"\" + ChosenFileName;
                foreach (string line in File.ReadLines(filename))
                {
                    details.Add(line);
                }
                return details;
            }
            catch (Exception)
            {
                details.Add("No Spies");
                return details;
            }



        }

        //save the file
        public static void SaveFile(string filename, IEnumerable<string> FileData)
        {
            File.WriteAllLines(Application.StartupPath + @"\" + filename + ".txt", FileData);
        }

        public static void DeleteFile(string filename)
        {
            File.Delete(Application.StartupPath + @"\" + filename);
        }






    }
}
