using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesAppSystem.Models;

namespace SalesAppSystem.Data
{
    public class SalesAppSystemContext : DbContext
    {
        public SalesAppSystemContext (DbContextOptions<SalesAppSystemContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        
    }
}
