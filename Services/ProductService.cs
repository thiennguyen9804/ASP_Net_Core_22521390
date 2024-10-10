using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NETMVC.Models;
using NETMVC.Services.Interface;

namespace NETMVC.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context){
            _context = context;
        }
        public async Task<List<ProductModel>> GetAllProduct()
        {
            return await _context.Product.ToListAsync();
        }
    }
}