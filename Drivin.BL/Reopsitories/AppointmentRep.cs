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
    public class AppointmentRep :IAppointmentRep
    {
        private readonly DrivinContext db;

        public AppointmentRep(DrivinContext db)
        {
            this.db = db;
        }

        #region Get 
        public IEnumerable<Appointment> Get()
        {
            var data = db.Appointment.Select(a => a);
            return data;
        }
        #endregion

        #region Get By Id
        public Appointment GetById(int id)
        {
            var data = db.Appointment.Where(a => a.Id == id).FirstOrDefault();
            return data;
        }
        #endregion

        #region Create 
        public void Create(Appointment obj)
        {
            db.Appointment.Add(obj);
            db.SaveChanges();
        }
        #endregion



        #region Edit 
        public void Edit(Appointment obj)
        {
            var oldData = db.Appointment.Find(obj.Id);
            oldData.Id = obj.Id;
            oldData.Header = obj.Header;
          

            db.SaveChanges();

        }
        #endregion

        #region Delete 
        public void Delete(Appointment obj)
        {
            db.Appointment.Remove(obj);
            db.SaveChanges();
        }
        #endregion


    }
}
