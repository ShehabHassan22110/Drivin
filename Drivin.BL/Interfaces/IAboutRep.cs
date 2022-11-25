using Drivin.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivin.BL.Interfaces
{
    public interface IAboutRep
    {
        IEnumerable<About> Get();
        About GetById(int id);

        void Create(About obj);
        void Edit(About obj);
        void Delete(About obj);
    }
}
