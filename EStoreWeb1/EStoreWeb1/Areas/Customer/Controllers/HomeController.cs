using EStoreWeb1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EStoreWeb1.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index(int? page)
        {
            int PageSize = 6;
            int PageIndex;
            PageIndex = page == null ? 1 : (int)page;
            var lstProduct = db.Products.Include(x => x.Category).ToList();
            var pagecount = lstProduct.Count() / PageSize + (lstProduct.Count() % PageSize > 0 ? 1 : 0);
            ViewBag.pageSum = pagecount;
            ViewBag.PageIndex = PageIndex;
            return View(lstProduct.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList());
        }
        public IActionResult Detail(int id)
        {
            var obj = db.Products.Find(id);
            if (obj == null)
                return NotFound();
            return View(obj);
        }
    }
}
