using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Enums;

namespace App.Models
{
    public class Material
    {
        public int Id { get; set; }
        
        public MaterialType Type { get; set; }
        
        public Teacher Teacher { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Url)]
        public string Url { get; set; }

        [DataType(DataType.DateTime)]
        public string CreatedAt { get; set; }

        [DataType(DataType.DateTime)]
        public string UpdatedAt { get; set; }
    }
}