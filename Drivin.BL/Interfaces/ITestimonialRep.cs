using Drivin.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivin.BL.Interfaces
{
	public interface ITestimonialRep
	{
		IEnumerable<Testimonial> Get();
        Testimonial GetById(int id);
		void Create(Testimonial obj);
		void Edit(Testimonial obj);
		void Delete(Testimonial obj);


    }
}
