using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivin.DAL.Entity
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Header { get; set; }
        [Required]
        public string Caption { get; set; }
        public string Point1 { get; set; }
        public string Point2 { get; set; }
        public string Point3 { get; set; }
        public string Point4 { get; set; }
        public string Phone { get; set; }
        public string PhotoName { get; set; }
    }
}
