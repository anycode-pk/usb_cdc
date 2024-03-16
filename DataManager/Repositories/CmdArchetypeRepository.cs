using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace DataManager.Repositories
{
    public class CmdArchetypeRepository : IDataRepository<CmdArchetype>
    {
        public CmdArchetype Get(int id)
        {
            return (from item in DataContext.Instance.DbContext.CmdArchetype where item.Id == id select item).FirstOrDefault();
        }

        public CmdArchetype GetDefault()
        {
            return (from item in DataContext.Instance.DbContext.CmdArchetype orderby item.Id select item).FirstOrDefault();
        }

        public IList<CmdArchetype> GetAll()
        {
            return (from items in DataContext.Instance.DbContext.CmdArchetype select items).ToList();
        }

        public IList<CmdArchetype> GetAll(Device device)
        {
            return (from items in DataContext.Instance.DbContext.CmdArchetype where items.DeviceId == device.Id select items).ToList();
        }

        public void InsertOrUpdate(CmdArchetype item)
        {
            if (item != null)
            {
                if (item.Id == 0 || item.Id == null)
                {
                    DataContext.Instance.DbContext.AddToCmdArchetype(item);
                }
                DataContext.Instance.DbContext.SaveChanges();
            }
        }

        public bool Remove(CmdArchetype item)
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

        public void RejectChanges(CmdArchetype item)
        {
            if (item.Id == 0 || item == null)
                return;
            DataContext.Instance.DbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, item);
        }
    }
}
