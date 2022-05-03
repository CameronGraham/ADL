using Microsoft.EntityFrameworkCore;
using ADL.Data;
using System;

namespace ADL.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        }

        public DbSet<EngineerRequest> Requests { get; set; }
    }
}
