using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivin.BL.ViewModels
{
    public class ContactVM
    {
        public int Id { get; set; }

        [Required]
        public string Header { get; set; }
        [Required]
        public string Caption { get; set; }
    }
}
