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
    }
