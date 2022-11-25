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
	public class TestimonialRep : ITestimonialRep
	{
		private readonly DrivinContext db;

		public TestimonialRep(DrivinContext db)
		{
			this.db = db;
		}

        #region Get 
        public IEnumerable<Testimonial> Get()
        {
            var data = db.Testimonial.Select(a => a);
            return data;
        }
        #endregion

        #region Get By Id
        public Testimonial GetById(int id)
        {
            var data = db.Testimonial.Where(a => a.Id == id).FirstOrDefault();
            return data;
        }
        #endregion

        #region Create 
        public void Create(Testimonial obj)
        {
            db.Testimonial.Add(obj);
            db.SaveChanges();
        }
        #endregion



        #region Edit 
        public void Edit(Testimonial obj)
        {
            var oldData = db.Testimonial.Find(obj.Id);
            oldData.Id = obj.Id;
            oldData.Name = obj.Name;
            oldData.Comment = obj.Comment;      
            oldData.PhotoName = obj.PhotoName;

            db.SaveChanges();

        }
        #endregion

        #region Delete 
        public void Delete(Testimonial obj)
        {
            db.Testimonial.Remove(obj);
            db.SaveChanges();
        }
        #endregion
    }
}
