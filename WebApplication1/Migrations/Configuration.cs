using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    public class Configuration : DbMigrationsConfiguration<GestionDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    }
}