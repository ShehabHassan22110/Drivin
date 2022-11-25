using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Drivin.DAL.Entity;
using Drivin.DAL.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivin.DAL.Database
{
    public class DrivinContext : IdentityDbContext<ApplicationUser>
    {

        public DrivinContext(DbContextOptions<DrivinContext> opt) : base(opt)
        {

        }


        public DbSet<Contact> Contact { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<OurTeam> OurTeam { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }

    }
}
