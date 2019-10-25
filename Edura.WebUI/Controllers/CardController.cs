using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Edura.WebUI.Infracture;
using Edura.WebUI.Models;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Controllers
{
    public class CardController : Controller
    {
        private IUnitOfWork uow;
        public CardController(IUnitOfWork _uow)
        {
            uow = _uow;
        }
        public IActionResult Index()
        {
            return View(GetCard());
        }
        public  IActionResult AddToCard(int ProductId,int quantity=1)
        {
            var product = uow.Products.Get(ProductId);
            if (product!=null)
            {
                var cart = GetCard();
                cart.AddProduct(product, quantity);
                SaveCart(cart);
            }
            return RedirectToAction("Index");
        }
        public IActionResult RemoveFromCard(int ProductId)
        {
            var product = uow.Products.Get(ProductId);
            if (product!=null)
            {
                var cart = GetCard();
                cart.RemoveProduct(product);
                SaveCart(cart);
            }
            return RedirectToAction("Index");
        }
        [Authorize]
        public IActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult CheckOut(OrderDetails od)
        {
            var cart = GetCard();
            if (cart.Products.Count==0)
            {
                ModelState.AddModelError("","Sizin səbətinizdə heç bir məhsul yoxdur");
            }
            if (ModelState.IsValid)
            {
                SaveOrder(cart, od);
                cart.ClearAll();
                SaveCart(cart);
                return View("Completed");
            }
            return View(od);
        }
        private void SaveOrder(Card cart,OrderDetails od)
        {
            var order = new Order();
            order.OrderNumber = "A" + (new Random()).Next(12121, 321323233).ToString();
            order.Total = cart.TotalPrce();
            order.OrderDate = DateTime.Now;
            order.OrderState = EnumOrderState.Waiting;
            order.UserName = User.Identity.Name;
            order.Unvan = od.Unvan;
            order.Adres = od.Adres;
            order.Seher = od.Seher;
            order.Erazi = od.Erazi;
            order.Telefon = od.Telefon;
            foreach (var product in cart.Products)
            {
                var orderline = new OrderLine();
                orderline.Quantity = product.Quantity;
                orderline.Price = product.Quantity * product.Product.Price;
                orderline.ProductId = product.Product.ProductId;
                order.orderLines.Add(orderline);
            }
            uow.Orders.Add(order);
            uow.SaveChanges();
        }
        private void SaveCart(Card cart)
        {
            HttpContext.Session.SetJson("Card", cart);
        }

        private Card GetCard()
        {
            return HttpContext.Session.GetJson<Card>("Card") ?? new Card();
        }
    }
}