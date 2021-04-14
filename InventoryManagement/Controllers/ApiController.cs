using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoryManagement.Models;

namespace InventoryManagement.Controllers
{
    public class ApiController : Controller
    {
        private readonly InventoryContext _context;

        public ApiController(InventoryContext context)
        {
            _context = context;
        }

        // GET: Products
        public JsonResult Index()
        {
            var res = new {user = "hamilton", uatiszap = "981818153", CLT = 9000};
            return Json(res);
        }

        // GET: Products
        public JsonResult Rest()
        {
            var res = _context.Products;
            var display = new {data = res};
            return Json(display);
        }

    }
}
