using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;
        private IUnitOfWork unitOfWork;
        public HomeController(IProductRepository _productRepository, IUnitOfWork _unitOfWork)
        {
            productRepository = _productRepository;
            unitOfWork = _unitOfWork;
        }
        public IActionResult Index()
        {
            return View(unitOfWork.Products.GetAll().Where(x=>x.IsApproved&&x.IsHome).ToList());
        }
        public IActionResult Details(int id)
        {
            return View(productRepository.Get(id));
        }
        public IActionResult Create()
        {
            var prd = new Product()
            {
                ProductName="Test",Price=100
            };
            unitOfWork.Products.Add(prd);
            unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}