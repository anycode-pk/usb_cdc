using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;



namespace DataManager.Repositories
{
    public class SessionRepository : IDataRepository<MeasureSession>
    {
        public MeasureSession Get(int id)
        {
            return (from item in DataContext.Instance.DbContext.MeasureSession where item.Id == id select item).FirstOrDefault();
        }

        public IList<MeasureSession> GetLastOpen(User usr, MeasureStation station)
        {
            if (usr == null || station == null)
                return new List<MeasureSession>();

            var session = (from sess in DataContext.Instance.DbContext.MeasureSession
                           where sess.User.Id == usr.Id
                               && sess.MeasureStation.Id == station.Id
                               && sess.StopDate == null
                           select sess);

            return session.ToList();
        }

        public IList<MeasureSession> GetAll()
        {
            return (from items in DataContext.Instance.DbContext.MeasureSession select items).ToList();
        }

        public void InsertOrUpdate(MeasureSession item)
        {
            if (item != null)
            {
                if (item.Id == 0 || item.Id == null)
                {
                    item.StartDate = DateTime.Now;
                    DataContext.Instance.DbContext.AddToMeasureSession(item);
                }
                try
                {                    
                    DataContext.Instance.DbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    CommonModel.CommonContext.Instance.LogException(ex);
                }
            }
        }

        public bool Remove(MeasureSession item)
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


        public void RejectChanges(MeasureSession item)
        {
            if (item.Id == 0 || item == null)
                return;
            DataContext.Instance.DbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, item);
        }
    }
}
