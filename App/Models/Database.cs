using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class Database : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Material> Materials { get; set; }

        public Database() : base("name=App.Properties.Settings.Connection") { }
    }
}