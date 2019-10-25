using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Models;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Edura.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public int PageSize = 3;
        private IProductRepository repository;
        public ProductController(IProductRepository _repository)
        {
            repository = _repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            return View(repository
                .GetAll()
                .Where(x => x.ProductId == id)
                .Include(x => x.Images)
                .Include(x => x.ProductAttributes)
                .Include(x => x.ProductCategories)
                .ThenInclude(x => x.Category)
                .Select(x => new ProductsDetailsModel()
                {
                    Product = x,
                    ProductImages=x.Images,
                    ProductAttributes=x.ProductAttributes,
                    Categories=x.ProductCategories.Select(i=>i.Category).ToList()
                })
                .FirstOrDefault());
        }
        public IActionResult List(string category,int page=1)
        {
            var products = repository.GetAll();
            if (!string.IsNullOrEmpty(category))
            {
                products = products
                    .Include(x => x.ProductCategories)
                .ThenInclude(x => x.Category)
                .Where(x => x.ProductCategories.Any(a=>a.Category.CategoryName==category));
            }
            products = products.Skip((page-1)*PageSize  ).Take(PageSize);
            return View(products);
        }
    }
}