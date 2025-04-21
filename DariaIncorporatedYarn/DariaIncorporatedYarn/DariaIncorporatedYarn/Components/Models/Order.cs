//Name: Daria Green
//Email: Dgreen50@cnm.edu
//File: Orders.cs

using System.ComponentModel.DataAnnotations;

namespace DariaIncorporatedYarn.Components.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter the project you would like created along with the colors of yarn and when you need the project by.")]
        public string CustomOrderRequest { get; set; }

    }
}
