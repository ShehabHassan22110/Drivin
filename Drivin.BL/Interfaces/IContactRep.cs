using Drivin.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivin.BL.Interfaces
{
    public interface IContactRep
    {
        IEnumerable<Contact> Get();

        Contact GetById(int id);

        void Create(Contact obj);

        void Edit(Contact obj);
        void Delete(Contact obj);


    }
}
