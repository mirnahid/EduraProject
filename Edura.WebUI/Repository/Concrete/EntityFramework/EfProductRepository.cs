using Edura.WebUI.Entity;
using Edura.WebUI.Repository.Abstract;
using Edura.WebUI.Repository.Concrete.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace Edura.WebUI.Repository.Concrete
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductRepository

    {
        public EfProductRepository(EduraContext context) : base(context)
        {

        }
        public EduraContext EduraContext
        {
            get { return context as EduraContext; }
        }

        public List<Product> GetTop5Products()
        {
            return EduraContext.Products.OrderByDescending(x => x.ProductId).Take(5).ToList();    
        }
    }
}
