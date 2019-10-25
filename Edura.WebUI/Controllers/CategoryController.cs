using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository categoryRepository;
        public CategoryController(ICategoryRepository _categoryRepository)
        {
            categoryRepository = _categoryRepository;
        }
        public IActionResult Index()
        {
            return View(categoryRepository.GetByName("Electronics"));
        }
    }
}