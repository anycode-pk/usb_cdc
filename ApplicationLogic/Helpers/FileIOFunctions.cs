using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ApplicationLogic.Helpers
{
    /// <summary>
    /// Klasa odpowiedzialna za tworzenie i odczytywanie pliku kofniguraji.
    /// </summary>
    internal class FileIOFunctions
    {
        private FileInfo fileInfo;

        internal FileIOFunctions(string fileName)
        {
            fileInfo = new FileInfo(fileName);
        }

        private string filePath = "";

        /// <summary>
        /// Zwraca zawartość tekstową pliku.
        /// </summary>
        /// <returns></returns>
        internal string ReadFileContent()
        {
            FileStream fs = new FileStream(fileInfo.Name, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string str = sr.ReadLine();
            sr.Close();
            fs.Close();
            return str;
        }

        /// <summary>
        /// Zapisuje zawartość tekstową do pliku.
        /// </summary>
        /// <returns>Prawda jeśli zapis przebiegnie prawidłowo.</returns>
        internal bool WriteFile(string text)
        {
            bool result = true;
            try
            {
                FileStream fs = new FileStream(fileInfo.FullName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.Write(text);
                sw.Flush();
                sw.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                CommonModel.CommonContext.Instance.LogException(ex);
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Sprawdza czy plik istnieje.
        /// </summary>
        /// <returns>Prawda jeśli plik istnieje.</returns>
        internal bool FileExist()
        {
            return this.fileInfo.Exists;
        }

    }
}
