using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Bookstore.Models
{
    public class Cart
    {
        // first part declares = second part instantiates
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();

        // virtual --> allows the method to be overwritten when we inherit from it
        public virtual void AddItem (Book bk, int qty)
        {
            CartLineItem line = Items
                .Where(x => x.Book.BookId == bk.BookId) //x.BookId
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new CartLineItem
                {
                    Book = bk,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public virtual void RemoveItem(Book bk)
        {
            Items.RemoveAll(x => x.Book.BookId == bk.BookId);
        }

        public virtual void ClearCart()
        {
            Items.Clear();
        }

        public decimal CalculateTotal()
        {
            decimal sum = Items.Sum(x => x.Quantity * x.Book.Price); //x.Book.Price
            return sum;
        }

    }

    public class CartLineItem
    {
        [Key]
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }

    }
}
