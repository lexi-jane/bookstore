using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Bookstore.Models
{
    public class Checkout
    {
        [Key]
        [BindNever] //not binding it to form, not going to be info that's passed thorugh the url
        public int CheckoutId { get; set; }


        [BindNever]
        public ICollection<CartLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is Required")]
        public string State { get; set; }
        
        [Required(ErrorMessage = "Zip Code is Required")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Country is Required")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is Required")]
        public string Phone { get; set; }

        [BindNever]
        public bool OrderShipped { get; set; }
    }
}
