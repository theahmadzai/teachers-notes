using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using App.Enums;

namespace App.Models
{
    public class File
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        [StringLength(100)]
        public string ContentType { get; set; }

        public byte[] Content { get; set; }

        public FileType FileType { get; set; }

        public int ResourceId { get; set; }

        public virtual Resource Resource { get; set; }
    }
}