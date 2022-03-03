using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bookstore.Controllers
{
    public class CheckoutController : Controller
    {
        private ICheckoutRepository repo { get; set; }
        private Cart cart { get; set; }

        public CheckoutController(ICheckoutRepository temp, Cart crt)
        {
            repo = temp;
            cart = crt;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Checkout());
        }

        [HttpPost]
        public IActionResult Checkout(Checkout checkout)
        {
            if (cart.Items.Count() == 0)
            {
                ModelState.AddModelError("", "There are currently no items in your cart");

            }

            if (ModelState.IsValid)
            {
                checkout.Lines = cart.Items.ToArray();
                repo.SaveCheckout(checkout);
                cart.ClearCart();

                return RedirectToPage("/CheckoutComplete");
            }
            else
            {
                return View();
            }
        }
    }
}
