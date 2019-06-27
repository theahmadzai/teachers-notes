using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Resource> Resource { get; set; }

        public DbSet<File> Files { get; set; }

        public DbContext() : base() { }
    }
}