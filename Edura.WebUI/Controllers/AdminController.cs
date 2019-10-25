using Edura.WebUI.Entity;
using Edura.WebUI.Models;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IUnitOfWork uow;
        public AdminController(IUnitOfWork _uow)
        {
            uow = _uow;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var entity = uow.Categories.GetAll()
                .Include(x => x.ProductCategories)
                .ThenInclude(x => x.Product)
                .Where(x => x.CategoryId == id)
                .Select(x => new AdminEditCategoryModel()
                {
                    CategoryId=x.CategoryId,
                    CategoryName=x.CategoryName,
                    Products=x.ProductCategories.Select(a=>new AdminEditCategoryProduct()
                    {
                        ProductId=a.ProductId,
                        ProductName=a.Product.ProductName,
                        Image=a.Product.Image,
                        IsApproved=a.Product.IsApproved,
                        IsHome=a.Product.IsHome,
                        IsFeatured=a.Product.IsFeatured
                    }).ToList()
                }).FirstOrDefault();
            return View(entity); 
        }
        [HttpPost]
        public IActionResult EditCategory(Category entity)
        {
            if (ModelState.IsValid)
            {
                uow.Categories.Edit(entity);
                uow.SaveChanges();
                return RedirectToAction("CatalogList");
            }
            return View("Error");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveFromCategory(int productid,int categoryid)
        {
            if (ModelState.IsValid)
            {
                uow.Categories.RemoveFromCategoey(productid, categoryid);
                return Ok();
            }
            return BadRequest();
        }
        public IActionResult CatalogList()
        {
            var model = new CatalogListModel()
            {
                Categories = uow.Categories.GetAll().ToList(),
                Products = uow.Products.GetAll().ToList()
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCategory(Category entity)
        {
            if (ModelState.IsValid)
            {
                uow.Categories.Add(entity);
                uow.SaveChanges();
                return Ok(entity);
            }
            return BadRequest();
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product entity,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file!=null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//images/products",file.FileName);
                    var path_small = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//images/products/small",file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        entity.Image = file.FileName;
                    }
                    using (var stream = new FileStream(path_small, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                entity.DateAdded = DateTime.Now;
                uow.Products.Add(entity);
                uow.SaveChanges();
               return RedirectToAction("CatalogList");
            }
            return View(entity);
        }
    }
}