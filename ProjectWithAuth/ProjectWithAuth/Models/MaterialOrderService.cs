using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ProjectWithAuth.Models
{
    public class MaterialOrderService
    {
        public int ID { get; set; }

        //F-key of Services 
        [Required]
        public int ServiceID { get; set; }
        // F-Key of Orders
        [Required]
        public int OrderID { get; set; }

        [Required]
        public int MaterialID { get; set; }

        public virtual Service Service { get; set; }
        public virtual Material Material { get; set; }
        public virtual Order Order { get; set; }
        

    }
}