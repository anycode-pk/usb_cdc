using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationLogic.Helpers
{
    /// <summary>
    /// Plik konfiguracji.
    /// </summary>
    [Serializable()]
    internal class FileConfig
    {
        /// <summary>
        /// Konstruktor tworzący obiekt z zserializowanej tablicy bajtów.
        /// </summary>
        internal FileConfig(byte[] rawBytes)
        {
            FileConfig tempThis = (FileConfig)ByteArrayToObject(rawBytes);
            if (tempThis != null)
            {
                this.connectionString = tempThis.connectionString;
                this.stationName = tempThis.stationName;
            }
          
            // Przykładowy connections string, dla MS SQL Server
            //                         metadata=res://*/Entities.ModelEF.csdl|res://*/Entities.ModelEF.ssdl|res://*/Entities.ModelEF.msl;provider=System.Data.SqlClient;provider connection string="data source=KOMPUTER\SQL2008R2;initial catalog=UsbCdcDb;integrated security=True;"
        }

        internal FileConfig(string stationName, string connection)
        {
            this.stationName = stationName;
            this.connectionString = connection;
        }

        private string stationName;

        internal string StationName
        {
            get { return stationName; }
            set { stationName = value; }
        }

        private string connectionString;

        internal string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }


        /// <summary>
        /// Zwraca obiekt w postaci tablicy bajtów.
        /// </summary>
        /// <returns>Tablica bajtów.</returns>
        public byte[] GetBytes()
        {
            try
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter
                            = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, this);
                return memoryStream.ToArray();
            }
            catch (Exception ex)
            {
                CommonModel.CommonContext.Instance.LogException(ex);
            }

            return null;
        }

        /// <summary>
        /// Metoda zwraca obiekt z tablicy bajtów.
        /// </summary>
        private object ByteArrayToObject(byte[] byteArray)
        {
            try
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(byteArray);
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter
                            = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                memoryStream.Position = 0;
                return binaryFormatter.Deserialize(memoryStream);
            }
            catch (Exception ex)
            {
                CommonModel.CommonContext.Instance.LogException(ex);
            }

            return null;
        }

    }
}
