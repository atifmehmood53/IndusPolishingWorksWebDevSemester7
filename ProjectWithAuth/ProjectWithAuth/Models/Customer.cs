using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectWithAuth.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [DisplayName("User ID")]
        public string ApplicationUserId { get; set; }

        [Required]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DisplayName("Address")]
        public string Address { get; set; }

       
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ApplicationUser User { get; set; }


    }
}