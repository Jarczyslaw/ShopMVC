using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopMVC.DataAccess.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }

        [Required(ErrorMessage = "Insert name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Insert surname")]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Insert address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Insert city")]
        [StringLength(100)]
        public string City { get; set; }

        [Required(ErrorMessage = "Insert postal code")]
        [StringLength(6)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Insert phone number")]
        [StringLength(20)]
        [RegularExpression(@"(\+\d{2})*[\d\s-]+", ErrorMessage = "Incorrect phone number format")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Insert email")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        public string Comments { get; set; }

        public DateTime AddedDate { get; set; }

        public OrderState OrderState { get; set; }

        public decimal Value { get; set; }

        public virtual List<OrderItem> OrderItems { get; set; }
    }
}