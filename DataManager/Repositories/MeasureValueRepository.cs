using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace DataManager.Repositories
{
    public class MeasureValueRepository : IDataRepository<MeasureValue>
    {
        public MeasureValue Get(int id)
        {
            return (from item in DataContext.Instance.DbContext.MeasureValue where item.Id == id select item).FirstOrDefault();
        }

        public IList<MeasureValue> GetAll()
        {
            return (from items in DataContext.Instance.DbContext.MeasureValue select items).ToList(); 
        }

        public void InsertOrUpdate(MeasureValue item)
        {
            if (item != null)
            {
                if (item.Id == 0 || item.Id == null)
                {
                    DataContext.Instance.DbContext.AddToMeasureValue(item);
                }
                DataContext.Instance.DbContext.SaveChanges();
            }
        }

        public bool Remove(MeasureValue item)
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
        
        public void RejectChanges(MeasureValue item)
        {
            if (item.Id == 0 || item == null)
                return;
            DataContext.Instance.DbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, item);
        }
    }
}
