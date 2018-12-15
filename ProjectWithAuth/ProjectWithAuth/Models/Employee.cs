using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace ProjectWithAuth.Models
{
    public class Employee
    {

        public int ID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

       // [Required]
        [Display(Name="User ID")]
        public string ApplicationUserId { get; set; }

        [Required]
        [Display(Name = "Hire Date")]
        public string HireDate { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "CNIC")]
        public string CNIC { get; set; }

        [Required]
        [Display(Name = "Wage")]
        public string Wage { get; set; }

       
        //Navigation properties 
        public virtual ICollection<Order> Orders { get; set; }//Because this will be used as Forign key in Orders
        public virtual ApplicationUser User { get; set; }


    }
}