using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Student Name")]
        [Required]
        public string FullName { get; set; }

        [DisplayName("Symbol No.")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Symbol No. cannot be negative!")]
        public int SymbolNo { get; set; }
        [Required]
        public string Faculty { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Year cannot be negative!")]
        public int Batch { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Range(1000000000,9999999999,ErrorMessage = "Invalid Phone Number!")]
        public long Phone { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",ErrorMessage ="Invalid Email Format")]
        public string Email { get; set; }
    }
}
