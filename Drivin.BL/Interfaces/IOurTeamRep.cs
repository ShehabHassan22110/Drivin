using Drivin.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivin.BL.Interfaces
{
    public interface IOurTeamRep
    {
        IEnumerable<OurTeam> Get();
        OurTeam GetById(int id);

        void Create(OurTeam obj);
        void Edit(OurTeam obj);
        void Delete(OurTeam obj);
    }
}
