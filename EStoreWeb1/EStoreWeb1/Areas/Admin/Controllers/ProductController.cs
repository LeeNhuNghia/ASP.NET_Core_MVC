using EStoreWeb1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EStoreWeb1.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly IHostingEnvironment host;

        public ProductController(ApplicationDbContext _db, IHostingEnvironment _host)
        {
            db = _db;
            host = _host;
        }
        public IActionResult Index(int? page)
        {
            int pageSize = 5;
            int pageIndex;

            pageIndex = page == null ? 1 : (int)page;
            var lstProduct = db.Products.Include(x => x.Category).ToList();
            // var pageCount = Math.Ceiling((double)lstProduct.Count / pageSize);
            var pageCount = lstProduct.Count / pageSize + (lstProduct.Count % pageSize > 0 ? 1 : 0);
            //gửi qua View
            ViewBag.PageSum = pageCount;
            ViewBag.PageIndex = pageIndex;
            return View(lstProduct.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList());
        }

        public IActionResult Create()

        {
            //truyén danh sach thé loai cho view dé sinh ra điều khién DropDownList
            ViewBag.LstCategory = db.Categories.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name });
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product obj, IFormFile file)
        {
            if (ModelState.IsValid) //kiem tra hop le
            {
                if (file != null)
                {
                    //xu ly upload
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName); //tao tên file can luu
                    string path = Path.Combine(host.WebRootPath, @"Products/Imgs"); //lay duong dan luu tru tren server
                    using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                    {
                        file.CopyTo(filestream);
                    }
                    // file.CopyTo(new FileStream(Path.Combine(path, filename), FileMode.Create)); //sao chep len server
                    obj.ImageUrl = @"Products/Imgs/" + filename;
                }
                //thêm obj vao table Product
                db.Products.Add(obj);
                db.SaveChanges();
                TempData["success"] = "Product inserted success";
                    return RedirectToAction("Index");
            }

            ViewBag.LstCategory = db.Categories.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name });
            return View();
        }

        public IActionResult Edit(int id)
        {
            // Truy van category theo id
            var obj = db.Products.Find(id);
            if (obj == null)
                return NotFound();
            //trả về view edut
            ViewBag.LstCategory = db.Categories.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name });
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(Product obj, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    // Xu ly upload
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName); // tạo tên file cần lưu
                    string path = Path.Combine(host.WebRootPath, @"Products/Imgs");
                    using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                    {
                        file.CopyTo(filestream);// sao chép lên server

                    }
                    // xoa hinh cu cua san pham
                    if (!String.IsNullOrEmpty(obj.ImageUrl))
                    {
                        var oldFile = Path.Combine(host.WebRootPath, obj.ImageUrl);
                        if (System.IO.File.Exists(oldFile))
                        {
                            System.IO.File.Delete(oldFile);
                        }
                    }
                    obj.ImageUrl = @"Products/Imgs/" + filename;
                }
                // them obj vao table 
                db.Update<Product>(obj);
                db.SaveChanges();
                TempData["success"] = "Category Update success";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            ViewBag.lstCategory = db.Categories.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name });
            // Truy van category theo id
            var objproduct = db.Products.Find(id);
            if (objproduct == null)
                return NotFound();
            // xoa
            return View(objproduct);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            //truy van the loai theo id
            var objProduct = db.Products.Find(id);
            if (objProduct == null)
            {
                return NotFound();
            }
            if (!String.IsNullOrEmpty(objProduct.ImageUrl))
            {
                var oldFile = Path.Combine(host.WebRootPath, objProduct.ImageUrl);
                if (System.IO.File.Exists(oldFile))
                {
                    System.IO.File.Delete(oldFile);
                }
            }
            //xoá
            db.Products.Remove(objProduct);
            db.SaveChanges();
            TempData["success"] = "Products deleted success";
            return RedirectToAction("Index");
        }
    }
}
