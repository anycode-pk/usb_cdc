using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;


namespace DataManager.Repositories
{
    public class UserRepository : IDataRepository<User>
    {
        public User Get(int id)
        {
            var user = (from us in DataContext.Instance.DbContext.User where us.Id == id select us).First();
            return user as User;
        }

        public User Get(string login)
        {
            var user = (from us in DataContext.Instance.DbContext.User where us.Login == login select us).FirstOrDefault();
            return user as User;
        }

        public IList<User> GetOther(MeasureStation station)
        {
            IList<User> users = station.UserStationM2M.Select(p => p.User).ToList();
            return GetOther(users);
        }

        public IList<User> GetOther(IList<User> currentUsers)
        {
            IList<User> all = this.GetAll();
            IList<User> otherUser = new List<User>();

            foreach (User u in all)
            {
                if (currentUsers.Where(p => p.Id == u.Id).Any())
                { }
                else
                {
                    otherUser.Add(u);
                }
            }
            return otherUser;
        }

        public IList<User> GetAll()
        {
            return (from usr in DataContext.Instance.DbContext.User select usr).ToList();
        }

        public void InsertOrUpdate(User item)
        {
            if (item != null)
            {
                if (item.Id == 0 || item.Id == null)
                {
                    DataContext.Instance.DbContext.AddToUser(item);

                }
                DataContext.Instance.DbContext.SaveChanges();
            }
        }

        public bool Remove(User item)
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
                
        public void RejectChanges(User item)
        {
            if (item.Id == 0 || item == null)
                return;

            DataContext.Instance.DbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, item);
        }
    }
}
