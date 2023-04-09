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

        public DbSet<SalesAppSystem.Models.Department> Department { get; set; }
    }
}
