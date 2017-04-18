using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DBAquarium.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DBAquarium.DataContext
{
    class OceansContext : DbContext
    {
        
        public OceansContext() : base()
        {

        }

        public DbSet<Oceans> Ocean { get; set; }
        public DbSet<Aquariums> Aquarium { get; set; }
        public DbSet<AquaticLife> Fish { get; set; }
    }



}
