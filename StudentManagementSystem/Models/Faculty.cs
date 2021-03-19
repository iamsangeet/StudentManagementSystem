using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Faculty Name")]
        [Required]
        public string FacultyName { get; set; }

        [DisplayName("Affilated University")]
        [Required]
        public string Affilation { get; set; }
    }
}
