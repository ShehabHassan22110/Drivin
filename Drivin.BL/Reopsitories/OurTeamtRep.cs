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
    public class OurTeamRep : IOurTeamRep
    {
        private readonly DrivinContext db;

        public OurTeamRep(DrivinContext db)
        {
            this.db = db;
        }

        #region Get 
        public IEnumerable<OurTeam> Get()
        {
            var data = db.OurTeam.Select(a => a);
            return data;
        }
        #endregion

        #region Get By Id
        public OurTeam GetById(int id)
        {
            var data = db.OurTeam.Where(a => a.Id == id).FirstOrDefault();
            return data;
        }
        #endregion

        #region Create 
        public void Create(OurTeam obj)
        {
            db.OurTeam.Add(obj);
            db.SaveChanges();
        }
        #endregion



        #region Edit 
        public void Edit(OurTeam obj)
        {
            var oldData = db.OurTeam.Find(obj.Id);
            oldData.Id = obj.Id;
            oldData.Name = obj.Name;
           
           
            oldData.PhotoName = obj.PhotoName;
            db.SaveChanges();

        }
        #endregion

        #region Delete 
        public void Delete(OurTeam obj)
        {
            db.OurTeam.Remove(obj);
            db.SaveChanges();
        }
        #endregion


    }
}
