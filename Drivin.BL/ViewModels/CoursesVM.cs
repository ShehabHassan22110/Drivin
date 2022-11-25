using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivin.BL.ViewModels
{
    public class CoursesVM
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Caption { get; set; }
        public string Price { get; set; }
        public string PhotoName { get; set; }
        public IFormFile Photo { get; set; }

    }
}
