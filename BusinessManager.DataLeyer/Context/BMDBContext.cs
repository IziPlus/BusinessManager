using BusinessManager.DomainClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.DataLeyer
{
    public class BMDBContext:DbContext
    {
        public BMDBContext(DbContextOptions<BMDBContext> options):base(options)
        {

        }

        public DbSet<Frooshande> Frooshandes { get; set; }
        public DbSet<HesabFrooshande> HesabFrooshandes { get; set; }
        public DbSet<HesabMoshtari> hesabMoshtaris { get; set; }
        public DbSet<Moshtari> Moshtaris { get; set; }
        public DbSet<RizFroosh> RizFrooshs { get; set; }
        public DbSet<RizKharid> RizKharids { get; set; }
    }
}
