using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotnet_NewProject.Models;

    public class dotnet_NewProjectContext : DbContext
    {
        public dotnet_NewProjectContext (DbContextOptions<dotnet_NewProjectContext> options)
            : base(options)
        {
        }

        public DbSet<dotnet_NewProject.Models.modelBaru> modelBaru { get; set; }
    }
