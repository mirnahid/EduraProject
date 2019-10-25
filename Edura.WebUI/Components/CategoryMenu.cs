using Edura.WebUI.Models;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Components
{
    public class CategoryMenu:ViewComponent 
    {
        private IUnitOfWork uow;
        public CategoryMenu(IUnitOfWork _uow)
        {
            uow = _uow;
        }
        public IViewComponentResult Invoke()
        {
            return View(uow.Categories.GetAllWithProductCount());
        }
    }
}
