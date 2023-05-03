using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Sodmac.Data;

namespace Sodimac.API
{
    public class ContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<DBContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlite(connectionString, b => b.MigrationsAssembly("Sodimac.API"));

            return new DBContext(builder.Options);
        }
    }
}

