using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(30)] 
        [DataType(DataType.Password)]
        public string Password { get; set; }    
       
        [DataType(DataType.DateTime)]
        public string CreatedAt { get; set; }

        [DataType(DataType.DateTime)]
        public string UpdatedAt { get; set; }       
    }
}