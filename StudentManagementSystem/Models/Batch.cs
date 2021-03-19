using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Batch
    {

        [Key]
        public int Id { get; set; }

       [DisplayName("Batch Year")]
       [Required]
       [Range(1,int.MaxValue,ErrorMessage ="Year cannot be negative!")]
        public int BatchYear { get; set; }

    }
}
