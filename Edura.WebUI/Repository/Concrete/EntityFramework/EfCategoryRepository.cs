using Edura.WebUI.Entity;
using Edura.WebUI.Models;
using Edura.WebUI.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(EduraContext context) : base(context)
        {
        }
        public EduraContext EduraContext
        {
            get { return context as EduraContext; }
        }

        public IEnumerable<CategoryModel> GetAllWithProductCount()
        {
            return GetAll().Select(x => new CategoryModel()
            {
                CategryId = x.CategoryId,
                CategoryName = x.CategoryName,
                CategoryCount = x.ProductCategories.Count()
            });
        }

        public Category GetByName(string name)
        {
            return EduraContext.Categories.Where(x => x.CategoryName == name).FirstOrDefault();
        }

        public void RemoveFromCategoey(int productId, int CategoryId)
        {
            var cmd = $"delete from ProductCategory where ProductId={productId} and CategoryId={CategoryId}";
#pragma warning disable EF1000 // Possible SQL injection vulnerability.
            context.Database.ExecuteSqlCommand(cmd);
#pragma warning restore EF1000 // Possible SQL injection vulnerability.
        }
    }
}
