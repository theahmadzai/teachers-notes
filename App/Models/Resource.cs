using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Enums;

namespace App.Models
{
    public class Resource
    {
        public int Id { get; set; }

        public Subject Subject { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "datetime2")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [Column(TypeName = "datetime2")]
        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<File> Files { get; set; }
    }
}