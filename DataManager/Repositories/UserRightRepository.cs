using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace DataManager.Repositories
{
    public class UserRightRepository : IDataRepository<UserRight>
    {
        public UserRight Get(int id)
        {
            return (from item in DataContext.Instance.DbContext.UserRight where item.Id == id select item).FirstOrDefault();
        }

        public IList<UserRight> GetAll()
        {
            return (from items in DataContext.Instance.DbContext.UserRight select items).ToList();
        }

        public void InsertOrUpdate(UserRight item)
        {
            if (item != null)
            {
                if (item.Id == 0 || item.Id == null)
                {
                    DataContext.Instance.DbContext.AddToUserRight(item);
                }
                DataContext.Instance.DbContext.SaveChanges();
            }
        }  

        public bool Remove(UserRight item)
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
                catch
                {
                    result = false;
                }

            }
            return result;
        }

        public void RejectChanges(UserRight item)
        {
            if (item.Id == 0 || item == null)
                return;
            DataContext.Instance.DbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, item);
        }
    }
}
