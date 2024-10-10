using System;
using System.Collections.Generic;
using System.Linq;
using NETMVC.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NETMVC.Controllers;
public class CatalogController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CatalogController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<CatalogModel> dsCatalog = _context.Catalog.ToList();
            return View(dsCatalog);
        }
    }