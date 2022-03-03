using System;
using System.Text.Json.Serialization;
using Bookstore.Models.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();

            cart.Session = session;

            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        //overrides line 13 in Cart.cs file
        public override void AddItem(Book bk, int qty)
        {
            base.AddItem(bk, qty);

            // this --> refers to the current instance of the
                // class and is also used as a modifier of the first
                // parameter of an extension method
            Session.SetJson("Cart", this);
        }

        //overrides line 13 in Cart.cs file
        public override void RemoveItem(Book bk)
        {
            base.RemoveItem(bk);
            Session.SetJson("Cart", this);

        }

        //overrides line 13 in Cart.cs file
        public override void ClearCart()
        {
            base.ClearCart();
            Session.Remove("Cart");

        }

    }
}
