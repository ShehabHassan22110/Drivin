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
    public class CoursesRep : ICoursesRep
    {
        private readonly DrivinContext db;

        public CoursesRep(DrivinContext db)
        {
            this.db = db;
        }

        #region Get 
        public IEnumerable<Courses> Get()
        {
            var data = db.Courses.Select(a => a);
            return data;
        }
        #endregion

        #region Get By Id
        public Courses GetById(int id)
        {
            var data = db.Courses.Where(a => a.Id == id).FirstOrDefault();
            return data;
        }
        #endregion

        #region Create 
        public void Create(Courses obj)
        {
            db.Courses.Add(obj);
            db.SaveChanges();
        }
        #endregion



        #region Edit 
        public void Edit(Courses obj)
        {
            var oldData = db.Courses.Find(obj.Id);
            oldData.Id = obj.Id;
            oldData.Header = obj.Header;
            oldData.Caption = obj.Caption;
            oldData.Price = obj.Price;
            oldData.PhotoName = obj.PhotoName;
           

            db.SaveChanges();

        }
        #endregion

        #region Delete 
        public void Delete(Courses obj)
        {
            db.Courses.Remove(obj);
            db.SaveChanges();
        }
        #endregion


    }
}
