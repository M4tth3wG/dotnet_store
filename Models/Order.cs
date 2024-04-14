using DotNet_lab_lista_10.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DotNet_lab_lista_10.Models
{
    public enum PaymentMethod
    {
        BLIK, CreditCard, PayPal, BankTransfer, GooglePay
    }
    [NotMapped]
    public class Order
    {
        [Required]
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Address")]
        public string Address { get; set; }
        [Required]
        [DisplayName("City")]
        public string City { get; set; }
        [Required]
        [DisplayName("Payment method")]
        public PaymentMethod PaymentMethod { get; set;}

        [Required]
        public ICollection<ArticleCartViewModel> Articles { get; set; }

    }
}
