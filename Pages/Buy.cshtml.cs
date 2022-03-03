using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Models;
using Bookstore.Models.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookstore.Pages
{
    public class BuyModel : PageModel
    {
        private IBookstoreRepository repo { get; set; }
        public Cart cart { get; set; }
        public string ReturnUrl { get; set; }
        public BuyModel (IBookstoreRepository temp, Cart crt)
        {
            repo = temp;
            cart = crt;
        }



        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";

            //this line dealing with our cart session is no longer needed, will now be done in SessionCart.cs file
            //cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book x = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            //cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            cart.AddItem(x, 1);

            //HttpContext.Session.SetJson("cart", cart);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int bookId, string returnUrl)
        {
            cart.RemoveItem(cart.Items.First(x => x.Book.BookId == bookId).Book);

            return RedirectToPage(new {ReturnUrl = returnUrl} );
        }
    }
}
