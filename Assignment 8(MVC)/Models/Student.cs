using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Student
    {
        [Key]
        public int ID {get; set;}
        
        [Required]
        public string Name{get; set;}
        
        [Required]
        public string Class{get; set;}

        [ForeignKey("Teacher")]
        [Display(Name="Teacher")]

        public int TID{get; set;}

        public virtual Teacher Teacher{get; set;}
    }
}