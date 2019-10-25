using Edura.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public class EfUnifOfWork : IUnitOfWork
    {
        private readonly EduraContext dbContext;
        public EfUnifOfWork(EduraContext _dbContext)
        {
            dbContext = _dbContext??throw new ArgumentNullException("DbContext cannot be null");
        }
       private IProductRepository _product;
       private ICategoryRepository _categories;
        private IOrderRepository _orders;
        public IProductRepository Products
        {
            get
            {
                return _product ?? (_product = new EfProductRepository(dbContext));
            }
        }

        public IOrderRepository Orders
        {
            get
            {
                return _orders ?? (_orders = new EfOrderRepository(dbContext));
            }
        }
        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new EfCategoryRepository(dbContext));
            }
        }



        public int SaveChanges()
        {
            try
            {
              return  dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }

        
    }
}
