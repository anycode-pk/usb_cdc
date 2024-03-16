using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataManager
{
    /// <summary>
    /// Klasa testująca połączenie z serwerem bazodanowym.
    /// </summary>
    public class ConnectionTester
    {
        public bool Test(string testConnString)
        {
            bool result = true;
            CommonModel.Entities.UsbCdcDbEntities database;
            try
            {
                database = new CommonModel.Entities.UsbCdcDbEntities(testConnString);
                result = database.DatabaseExists();
                var nothing = from us in database.User select us;
            }
            catch (Exception ex)
            {
                CommonModel.CommonContext.Instance.LogException(ex);
                result = false;
            }

            return result;
        }
    }
}
