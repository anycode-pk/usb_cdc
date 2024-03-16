using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace DataManager.Repositories
{
    public class CmdListRepository : IDataRepository<CmdList>
    {
        public CmdList Get(int id)
        {
            return (from item in DataContext.Instance.DbContext.CmdList where item.Id == id select item).FirstOrDefault();
        }

        public IList<CmdList> Get(ConfDevice configuration)
        {
            return (from items in DataContext.Instance.DbContext.CmdList where items.ConfDevice.Id == configuration.Id
                    orderby items.NumberInOrder ascending select items).ToList();
        }

        public IList<CmdList> GetAll()
        {
            return (from items in DataContext.Instance.DbContext.CmdList select items).ToList(); 
        }

        public void InsertOrUpdate(CmdList item)
        {
            if (item != null)
            {
                if (item.Id == 0 || item.Id == null)
                {
                    DataContext.Instance.DbContext.AddToCmdList(item);
                }
                DataContext.Instance.DbContext.SaveChanges();
            }
        }

        public bool Remove(CmdList item)
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

        public void RejectChanges(CmdList item)
        {
            if (item.Id == 0 || item == null)
                return;
             DataContext.Instance.DbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, item);
        }
    }
}
