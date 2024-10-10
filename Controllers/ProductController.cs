using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NETMVC.Models;
using System.Data.SqlClient;
using System.Linq;

namespace NETMVC.Controllers;
public class ProductController : Controller
{
    private readonly ApplicationDbContext _context;
    public ProductController(ApplicationDbContext context){
        _context = context;
    }
    public IActionResult Index()
    {
        List<ProductModel> dsProduct = _context.Product.ToList();
        return View(dsProduct);

    }
    public IActionResult Detail()
    {
        
        return View();
    }
}
