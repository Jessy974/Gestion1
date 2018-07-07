using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class GestionDbContext : DbContext
    {
        public GestionDbContext() : base("Gestion")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Application> Applications { get; set; }
    }
}