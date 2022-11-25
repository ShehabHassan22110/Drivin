using AutoMapper;
using Drivin.BL.ViewModels;
using Drivin.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivin.BL.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Contact, ContactVM>();
            CreateMap<ContactVM, Contact>();

            CreateMap<About, AboutVM>();
            CreateMap<AboutVM, About>();

            CreateMap<Courses, CoursesVM>();
            CreateMap<CoursesVM, Courses>();

            CreateMap<Appointment, AppointmentVM>();
            CreateMap<AppointmentVM, Appointment>();

            CreateMap<OurTeam, OurTeamVM>();
            CreateMap<OurTeamVM, OurTeam>();

            CreateMap<Testimonial, TestimonialVM>();
            CreateMap<TestimonialVM, Testimonial>();

        }
    }
}
