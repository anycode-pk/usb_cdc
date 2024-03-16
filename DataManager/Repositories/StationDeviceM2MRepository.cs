using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace DataManager.Repositories
{
    public class StationDeviceM2MRepository : IDataRepository<StationDeviceM2M>
    {
        public StationDeviceM2M Get(int id)
        {
            return (from item in DataContext.Instance.DbContext.StationDeviceM2M where item.Id == id select item).FirstOrDefault();
        }

        public IList<StationDeviceM2M> GetAll()
        {
            return (from item in DataContext.Instance.DbContext.StationDeviceM2M select item).ToList();
        }

        public IList<StationDeviceM2M> Get(MeasureStation station)
        {
            if (station == null)
                return null;

            var stDevices = (from sd in DataContext.Instance.DbContext.StationDeviceM2M where sd.StationId == station.Id select sd);
                return stDevices.ToList();

        }

        public void InsertOrUpdate(StationDeviceM2M item)
        {
            if (item != null)
            {
                if (item.Id == 0 || item.Id == null)
                {
                    DataContext.Instance.DbContext.AddToStationDeviceM2M(item);
                }
                DataContext.Instance.DbContext.SaveChanges();
            }
        }

        public bool Remove(StationDeviceM2M item)
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
        
        public void RejectChanges(StationDeviceM2M item)
        {
            if (item.Id == 0 || item == null)
                return;
            DataContext.Instance.DbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, item);

        }
    }
}
