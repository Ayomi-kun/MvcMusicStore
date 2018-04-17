using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Display(Name="Order Date")]
        public DateTime OrderDate { get; set; }
        [Remote ("CheckUserName", "Account")]
        [Display(Name = "User Name")]
        public string Username { get; set; }
        [Required]
        [StringLength (160,MinimumLength=3)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength (160,MinimumLength=3)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+ \. [A-za-z]{2,4}", ErrorMessage="{0} does not look like a valid {0} address.")]
        public string Email { get; set; }
        [DisplayFormat(ApplyFormatInEditMode=true,DataFormatString="{0:c}")]
        public decimal Total { get; set; }
       // public List<OrderDetail> OrderDetail { get; set; }
    }
}