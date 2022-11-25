using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivin.BL.ViewModels
{
	public class OurTeamVM
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoName { get; set; }
        public IFormFile Photo { get; set; }
 
    }
}
