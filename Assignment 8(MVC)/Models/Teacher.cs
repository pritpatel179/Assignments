using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Teacher
    {
        [Key]
        public int TID {get; set;}
        
        [Required]
        public string TName{get; set;}

        [Required]
        public string Subject{get; set;}

        [Range(1,5)]

        public int Credits{get; set;}
    
    }
}