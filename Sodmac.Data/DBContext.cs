using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sodmac.Data.Entities;
using Sodmac.Data.Entities.Seeders;

namespace Sodmac.Data
{
	public class DBContext : DbContext
    {
		public DBContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Seed_TBL_INV_NP_COMPROMETIDAS_N.Seed(modelBuilder);
            Seed_TBL_INV_CO_DESPACHADAS_N.Seed(modelBuilder);
            Seed_TBL_INV_UBICACIONES_N.Seed(modelBuilder);
        }

        public DbSet<TBL_INV_NP_COMPROMETIDAS_N> TBL_INV_NP_COMPROMETIDAS_N => Set<TBL_INV_NP_COMPROMETIDAS_N>();
        public DbSet<TBL_INV_CO_DESPACHADAS_N> TBL_INV_CO_DESPACHADAS_N => Set<TBL_INV_CO_DESPACHADAS_N>();
        public DbSet<TBL_INV_UBICACIONES_N> TBL_INV_UBICACIONES_N => Set<TBL_INV_UBICACIONES_N>();
    }
}
