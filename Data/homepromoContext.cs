using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotnet_NewProject.Models;

    public class homepromoContext : DbContext
    {
        public homepromoContext (DbContextOptions<homepromoContext> options)
            : base(options)
        {
        }

        public DbSet<dotnet_NewProject.Models.modelHomePromo> modelHomePromo { get; set; }
        public DbSet<dotnet_NewProject.Models.modelStoreList> modelStoreList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=homepromoContext-f6bd92f5-7781-42ff-b027-9d367d769bc1.db");
        }
    }
