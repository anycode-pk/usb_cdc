using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace DataManager.Repositories
{
    public class ConfigurationRepository : IDataRepository<ConfDevice>
    {
        public ConfDevice Get(int id)
        {
            var conf = (from cfg in DataContext.Instance.DbContext.ConfDevice where cfg.Id == id select cfg);
            return conf as ConfDevice;
        }

        public ConfDevice GetDefault()
        {
            return (from item in DataContext.Instance.DbContext.ConfDevice orderby item.Id select item).FirstOrDefault();
        }

        public IList<ConfDevice> Get(Device device)
        {
            if (device == null)
                return null;

            var conf = (from cfg in DataContext.Instance.DbContext.ConfDevice where cfg.DeviceId == device.Id select cfg);
                return conf.ToList();
        }

        public IList<ConfDevice> GetActive(Device device)
        {
            if (device == null)
                return null;

            return this.Get(device).Where(p => p.IsActive == true).ToList();
        }

        public IList<ConfDevice> GetAll()
        {
            return (from items in DataContext.Instance.DbContext.ConfDevice select items).ToList();
        }

        public void InsertOrUpdate(ConfDevice item)
        {
            if (item != null)
            {
                if (item.Id == 0 || item.Id == null)
                {
                    DataContext.Instance.DbContext.AddToConfDevice(item);
                }
                DataContext.Instance.DbContext.SaveChanges();
            }
        }

        public bool Remove(ConfDevice item)
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

        public void RejectChanges(ConfDevice item)
        {
            if (item.Id == 0 || item == null)
                return;
            DataContext.Instance.DbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, item);
        }
    }
}
