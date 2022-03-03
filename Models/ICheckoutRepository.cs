using System;
using System.Linq;

namespace Bookstore.Models
{
    public interface ICheckoutRepository
    {
        IQueryable<Checkout> Checkouts { get; }

        //don't need "public" bc itt already defaultts to it
        void SaveCheckout(Checkout checkout);
    }
}
