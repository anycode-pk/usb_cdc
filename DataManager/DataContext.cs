using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace DataManager
{
    /// <summary>
    /// Wspólny kontekst dla repozytoriów.
    /// </summary>
    public class DataContext
    {
        private static DataContext instance;

        public static DataContext Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataContext();

                return instance;
            }
        }

        private CommonModel.Entities.UsbCdcDbEntities dbContext;
        /// <summary>
        /// Dostęp do bazy danych - kontekst Entity Framework.
        /// </summary>
        public UsbCdcDbEntities DbContext
        {
            get { return dbContext; }
        }

        private DataContext()
        {
            dbContext = new UsbCdcDbEntities(CommonModel.CommonContext.Instance.ConnectionString);
        }

    }
}
