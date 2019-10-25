using Edura.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Models
{
    public class ProductsDetailsModel
    {
        public Product Product { get; set; }
        public List<Image> ProductImages { get; set; }
        public List<ProductAttribute> ProductAttributes { get; set; }
        public List<Category>  Categories { get; set; }
    }
}
