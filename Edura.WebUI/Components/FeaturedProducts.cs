using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Components
{
    public class FeaturedProducts : ViewComponent
    {
        private IProductRepository product;
        public FeaturedProducts(IProductRepository _product)
        {
            product = _product;
        }
        public IViewComponentResult Invoke()
        {
            return View(product
                .GetAll()
                .Where(x => x.IsFeatured &&x.IsApproved)
                .ToList());
        }
    }
}
