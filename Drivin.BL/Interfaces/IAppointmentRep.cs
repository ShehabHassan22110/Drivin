using Drivin.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivin.BL.Interfaces
{
    public interface IAppointmentRep
    {
        IEnumerable<Appointment> Get();
        Appointment GetById(int id);

        void Create(Appointment obj);
        void Edit(Appointment obj);
        void Delete(Appointment obj);
    }
}
