using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace ProjectWithAuth.Models
{
    public class Order
    {
        public int ID { get; set; }

        [Required]
        [DisplayName("Customer ID")]
        public int CustomerID { get; set; }

        [Required]
        [DisplayName("Employee ID")]
        public int EmployeeID { get; set; }

        [Required]
        [DisplayName("Order Date")]
        public DateTime OrderDate { get; set; }

        [Required]
        [DisplayName("Order Due-Date")]
        public DateTime OrderDueDate { get; set; }

        [DisplayName("Weight")]
        [Required]
        public int Weight { get; set; }

        [Required]
        [DisplayName("Total Price")]
        public int TotalPrice { get; set; }

        

        //Navigation properties 
        public virtual ICollection<MaterialOrderService> MaterialOrderServices { get; set; }//Because this will be used as Forign key in Orders
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
    }
}