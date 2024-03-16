using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace DataManager.Repositories
{
    public class StationRepository : IDataRepository<MeasureStation>
    {
        public MeasureStation Get(int id)
        {
            return (from item in DataContext.Instance.DbContext.MeasureStation where item.Id == id select item).FirstOrDefault();
        }

        public MeasureStation Get(string name)
        {
            var station = (from stat in DataContext.Instance.DbContext.MeasureStation where stat.Name == name && stat.IsActive == true select stat).FirstOrDefault();
            return station as MeasureStation;

        }

        public IList<MeasureStation> GetAll()
        {
            return (from stat in DataContext.Instance.DbContext.MeasureStation select stat).ToList();
        }

        public IList<MeasureStation> GetAll(User authorizedUser)
        {
            return (from us in DataContext.Instance.DbContext.UserStationM2M where us.UserId == authorizedUser.Id select us.MeasureStation).ToList();
        }

        public void InsertOrUpdate(MeasureStation item)
        {
            if (item != null)
            {
                if (item.Id == 0 || item.Id == null)
                {
                    DataContext.Instance.DbContext.AddToMeasureStation(item);
                }
                DataContext.Instance.DbContext.SaveChanges();
            }
        }

        public bool Remove(MeasureStation item)
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
        
        public void RejectChanges(MeasureStation item)
        {
            if (item.Id == 0 || item == null)
                return;
            DataContext.Instance.DbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, item);

        }
    }
}
