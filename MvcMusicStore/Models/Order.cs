using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Username { get; set; }
        [Required]
        [StringLength (160,MinimumLength=3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength (160,MinimumLength=3)]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+ \. [A-za-z]{2,4}")]
        public string Email { get; set; }
        public decimal Total { get; set; }
       // public List<OrderDetail> OrderDetail { get; set; }
    }
}