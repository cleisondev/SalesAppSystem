using SalesAppSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesAppSystem.Services
{
    public class DepartmentService
    {
        private readonly SalesAppSystemContext _context;

        public DepartmentService(SalesAppSystemContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
