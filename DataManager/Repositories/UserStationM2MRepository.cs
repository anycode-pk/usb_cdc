using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace DataManager.Repositories
{
    public class UserStationM2MRepository : IDataRepository<UserStationM2M>
    {
        public UserStationM2M Get(int id)
        {
            return (from item in DataContext.Instance.DbContext.UserStationM2M where item.Id == id select item).FirstOrDefault();
        }

        public UserStationM2M Get(User usr, MeasureStation station)
        {
            if (usr == null || station == null)
                return null;

            var ustation = (from ustat in DataContext.Instance.DbContext.UserStationM2M where ustat.User.Id == usr.Id &&
                                 ustat.MeasureStation.Id == station.Id select ustat).FirstOrDefault();
             return ustation as UserStationM2M;
        }

        public IList<UserStationM2M> GetAll()
        {
            return (from items in DataContext.Instance.DbContext.UserStationM2M select items).ToList();
        }

        public void InsertOrUpdate(UserStationM2M item)
        {
            if (item != null)
            {
                if (item.Id == 0 || item.Id == null)
                {
                    DataContext.Instance.DbContext.AddToUserStationM2M(item);
                }
                DataContext.Instance.DbContext.SaveChanges();
            }
        }

        public bool Remove(UserStationM2M item)
        {
            bool result = false;
            if (item != null)
            {
                try
                {
                    DataContext.Instance.DbContext.DeleteObject(item);
                    DataContext.Instance.DbContext.SaveChanges();
                    result = true;
                }
                catch (Exception ex)
                {
                    CommonModel.CommonContext.Instance.LogException(ex);
                    result = false;
                }
            }
            return result;
        }
        
        public void RejectChanges(UserStationM2M item)
        {
            if (item.Id == 0 || item == null)
                return;
            DataContext.Instance.DbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, item);
        }
    }
}
