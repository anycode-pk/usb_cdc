using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace DataManager.Repositories
{
    public class UnitRepository : IDataRepository<Unit>
    {
        public Unit Get(int id)
        {
            return (from item in DataContext.Instance.DbContext.Unit where item.Id == id select item).FirstOrDefault();
        }

        public Unit GetDefault()
        {
            return (from item in DataContext.Instance.DbContext.Unit orderby item.Id select item).FirstOrDefault();
        }

        public IList<Unit> GetAll()
        {
            return (from unt in DataContext.Instance.DbContext.Unit select unt).ToList();
        }

        public void InsertOrUpdate(Unit item)
        {
            if (item != null)
            {
                if (item.Id == 0 || item.Id == null)
                {
                    DataContext.Instance.DbContext.AddToUnit(item);

                }
                DataContext.Instance.DbContext.SaveChanges();
            }
        }

        public bool Remove(Unit item)
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

        public void RejectChanges(Unit item)
        {
            if (item.Id == 0 || item == null)
                return;
            DataContext.Instance.DbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, item);

        }
    }
}
