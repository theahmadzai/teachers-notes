using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Enums;

namespace App.Models
{
    public class Material
    {
        public int Id { get; set; }
        public MaterialType Type { get; set; }
        public Teacher Teacher { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}