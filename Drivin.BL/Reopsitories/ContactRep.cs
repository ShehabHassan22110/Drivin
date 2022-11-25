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
    public class ContactRep : IContactRep
    {
        private readonly DrivinContext db;

        public ContactRep(DrivinContext db)
        {
            this.db = db;
        }
        //-----------------------------------------------------------------------------------  
        public IEnumerable<Contact> Get()
        {
            var data = db.Contact.Select(a => a);
            return data;
        }
        //-----------------------------------------------------------------------------------  
        public Contact GetById(int id)
        {
            var data = db.Contact.Where(a => a.Id == id).FirstOrDefault();
            return data;
        }
        //-----------------------------------------------------------------------------------  
        public void Create(Contact obj)
        {
            db.Contact.Add(obj);
            db.SaveChanges();
        }
        //-----------------------------------------------------------------------------------  
        public void Edit(Contact obj)
        {
            var oldData = db.Contact.Find(obj.Id);

            oldData.Header = obj.Header;
            oldData.Caption = obj.Caption;
        }

   //-----------------------------------------------------------------------------------  
        public void Delete(Contact obj)
        {

            db.Contact.Remove(obj);
            db.SaveChanges();
        }

    }
}
