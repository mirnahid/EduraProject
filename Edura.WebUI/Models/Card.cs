using Edura.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Models
{
    public class Card
    {
        private List<CardLine> products = new List<CardLine>();
        public List<CardLine> Products => products;
        public void AddProduct(Product product,int quantity)
        {
            var prd = products.Where(x => x.Product.ProductId == product.ProductId).FirstOrDefault();
            if (prd==null)
            {
                products.Add(new CardLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                prd.Quantity += quantity;
            }
        }
        public void RemoveProduct(Product product)
        {
            products.RemoveAll(x => x.Product.ProductId == product.ProductId);
        }
        public double TotalPrce()
        {
            return products.Sum(x => x.Product.ProductId * x.Quantity);
        }
        public void ClearAll()
        {
            products.Clear();
        }
    }
    public class CardLine
    {
        public int CardLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
