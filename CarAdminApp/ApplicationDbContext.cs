using CarAdminApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarAdminApp
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor die opties doorgeeft aan de DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets voor je modellen: Dit maakt tabellen voor je data
        public DbSet<Auto> Autos { get; set; }  // Voor Auto's
        public DbSet<Klant> Klanten { get; set; }  // Voor Klanten
        public DbSet<Betaling> Betalingen { get; set; }  // Voor Betalingen
    }
}
