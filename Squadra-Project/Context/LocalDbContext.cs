using Microsoft.EntityFrameworkCore;
using Squadra_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.Context
{
    public class LocalDbContext : DbContext
    {
        public LocalDbContext(DbContextOptions<LocalDbContext> opt ): base(opt)
        {

        }

        public DbSet<Carro> carro { get; set; }


            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
