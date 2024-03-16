using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace DataManager.Repositories
{
    public class RightRepository : IDataRepository<Right>
    {
        public Right Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Right> GetOther(User usr)
        {          
            IList<Right> userRight = usr.UserRight.Select(p=> p.Right).ToList();
            return this.GetOther(userRight);
        }

        public IList<Right> GetOther(IList<Right> currentRigth)
        {
            IList<Right> all = this.GetAll();
            IList<Right> otherRight = new List<Right>();

            foreach (Right r in all)
            {
                if (currentRigth.Where(p => p.Id == r.Id).Any())
                { }
                else
                {
                    otherRight.Add(r);
                }
            }
            return otherRight;
        }

        public IList<Right> GetAll()
        {
            return (from rig in DataContext.Instance.DbContext.Right select rig).ToList();
        }

        public void InsertOrUpdate(Right item)
        {
            throw new ApplicationException("You can not add data permanently.");
        }

        public bool Remove(Right item)
        {
            throw new ApplicationException("You can not delete data permanently.");
        }


        public void RejectChanges(Right item)
        {
            if (item.Id == 0 || item == null)
                return;
            DataContext.Instance.DbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, item);
        }
    }
}
