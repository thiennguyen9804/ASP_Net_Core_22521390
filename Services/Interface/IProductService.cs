using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NETMVC.Models;

namespace NETMVC.Services.Interface
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetAllProduct();
    }
}