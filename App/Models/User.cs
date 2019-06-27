using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    public class User
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

        [Column(TypeName = "datetime2")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [Column(TypeName = "datetime2")]
        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }
    }
}