using Drivin.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivin.BL.Interfaces
{
    public interface ICoursesRep
    {
        IEnumerable<Courses> Get();
        Courses GetById(int id);
        void Create(Courses obj);
        void Edit(Courses obj);
        void Delete(Courses obj);
    }
}
