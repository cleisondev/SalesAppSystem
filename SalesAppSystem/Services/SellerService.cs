using SalesAppSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesAppSystem.Services
{
    public class SellerService
    {
        private readonly SalesAppSystemContext _context;

        public SellerService(SalesAppSystemContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
