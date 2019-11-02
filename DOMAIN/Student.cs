using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DOMAIN
{
    public class Student
    {
        [Key]
        public int? studentID { get; set; }

        [Required]
        public string Codigo { get; set; }

        [Required]
        public string studentName { get; set; }

        [Required]
        public string studentAddress { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        [Required]
        public string StudentAddress { get; set; }

        public bool? Activo { get; set; }
    }
}
