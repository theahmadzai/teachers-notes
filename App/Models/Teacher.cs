using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }    
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }       
    }
}