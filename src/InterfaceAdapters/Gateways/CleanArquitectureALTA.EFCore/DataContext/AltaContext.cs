using Alta.EFCore.TypeConfigurations;
using Alta.Entities.POCOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.EFCore.DataContext
{
    public class AltaContext : DbContext
    {
        public AltaContext(DbContextOptions<AltaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AltaContext).Assembly);
        }

        public DbSet<RequestInitiate> RequestInitiate { get; set; }
        public DbSet<HeartbeatInitiate> HeartbeatInitiate { get; set; }
        public DbSet<DataFromPrime> DataFromPrime { get; set; }
        public DbSet<DataToPrime> DataToPrime { get; set; }
        public DbSet<User> User { get; set; }

    }
}
