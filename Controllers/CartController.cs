using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcMusicStore.Helpers;
using Microsoft.AspNetCore.Http;
using PhotoScape.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Stripe;

namespace shoppingCart.Controllers
{
    public class CartController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            List<Item> cart = HttpContext.Session.GetObjectFromJson<List<Item>>("cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);
            return View();
        }

        [Authorize]
        public IActionResult StripePay()
        {
            List<Item> cart = HttpContext.Session.GetObjectFromJson<List<Item>>("cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);
            return View();
        }

        [Authorize]
        public IActionResult Charge(string stripeEmail, string stripeToken)
        {
            var customers = new CustomerService();
            var charges = new ChargeService();

            List<Item> cart = HttpContext.Session.GetObjectFromJson<List<Item>>("cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);

            var customer = customers.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                SourceToken = stripeToken
            });

            var charge = charges.Create(new ChargeCreateOptions
            {
                Amount = (long)(ViewBag.total * 100),
                Description = "Sample Charge",
                Currency = "usd",
                CustomerId = customer.Id
            });

            return View();
        }

        [Authorize]
        public IActionResult Buy(string id)
        {
            ProductModel productModel = new ProductModel();
            if (HttpContext.Session.GetObjectFromJson<List<Item>>("cart") == null)
            {
                List<Item> cart = new List<Item>
                {
                    new Item { Product = productModel.Find(id), Quantity = 1 }
                };
                HttpContext.Session.SetObjectAsJson("cart", cart);
            }
            else
            {
                List<Item> cart = HttpContext.Session.GetObjectFromJson<List<Item>>("cart");
                int index = IsExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = productModel.Find(id), Quantity = 1 });
                }
                HttpContext.Session.SetObjectAsJson("cart", cart);
            }
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult Remove(string id)
        {
            List<Item> cart = HttpContext.Session.GetObjectFromJson<List<Item>>("cart");
            int index = IsExist(id);
            cart.RemoveAt(index);
            HttpContext.Session.SetObjectAsJson("cart", cart);
            return RedirectToAction("Index");
        }

        [Authorize]
        private int IsExist(string id)
        {
            List<Item> cart = HttpContext.Session.GetObjectFromJson<List<Item>>("cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

    }
}