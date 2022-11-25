using Drivin.BL.Interfaces;
using Drivin.DAL.Database;
using Drivin.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivin.BL.Reopsitories
{
    public class AboutRep : IAboutRep
    {
        private readonly DrivinContext db;

        public AboutRep(DrivinContext db)
        {
            this.db = db;
        }

        #region Get 
        public IEnumerable<About> Get()
        {
            var data = db.About.Select(a => a);
            return data;
        }
        #endregion

        #region Get By Id
        public About GetById(int id)
        {
            var data = db.About.Where(a => a.Id == id).FirstOrDefault();
            return data;
        }
        #endregion

        #region Create 
        public void Create(About obj)
        {
            db.About.Add(obj);
            db.SaveChanges();
        }
        #endregion



        #region Edit 
        public void Edit(About obj)
        {
            var oldData = db.About.Find(obj.Id);
            oldData.Id = obj.Id;
            oldData.Header = obj.Header;
            oldData.Caption = obj.Caption;
            oldData.Phone = obj.Phone;
            oldData.Point1 = obj.Point1;
            oldData.Point2 = obj.Point2;
            oldData.Point3 = obj.Point3;
            oldData.Point4 = obj.Point4;
            oldData.PhotoName = obj.PhotoName;

            db.SaveChanges();

        }
        #endregion

        #region Delete 
        public void Delete(About obj)
        {
            db.About.Remove(obj);
            db.SaveChanges();
        }
        #endregion


    }
}
