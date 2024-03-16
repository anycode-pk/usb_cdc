using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;


namespace DataManager.Repositories
{
    public class DeviceRepository : IDataRepository<Device>
    {
        public Device Get(int id)
        {
            return (from dev in DataContext.Instance.DbContext.Device where dev.Id == id select dev).FirstOrDefault();
        }

        public IList<Device> Get(MeasureStation station)
        {
            if (station == null)
                return null;

            IList<StationDeviceM2M> sd = new StationDeviceM2MRepository().Get(station);
            IList<Device> devices = sd.Select(p => p.Device).ToList();
            return devices;
        }

        public Device GetDefault()
        {
            return (from item in DataContext.Instance.DbContext.Device orderby item.Id select item).FirstOrDefault();
        }

        public IList<Device> GetOther(IList<Device> currentDev)
        {
            IList<Device> all = this.GetAll();
            IList<Device> otherDevice = new List<Device>();

            foreach (Device d in all)
            {
                if (currentDev.Where(p => p.Id == d.Id).Any())
                { }
                else
                {
                    otherDevice.Add(d);
                }
            }
            return otherDevice;
        }

        public IList<Device> GetActive(MeasureStation station)
        {
            if (station == null)
                return null;

            return this.Get(station).Where(p => p.IsActive == true).ToList();
        }

        public IList<Device> GetAll()
        {
            return (from dev in DataContext.Instance.DbContext.Device select dev).ToList();
        }

        public void InsertOrUpdate(Device item)
        {
            if (item != null)
            {
                if (item.Id == 0 || item.Id == null)
                    {
                        DataContext.Instance.DbContext.AddToDevice(item);
                    }
                DataContext.Instance.DbContext.SaveChanges();
            }
        }

        public bool Remove(Device item)
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
        
        public void RejectChanges(Device item)
        {
            if (item.Id == 0 || item == null)
                return;
            DataContext.Instance.DbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, item);
        }
    }
}
