using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ProjectWithAuth.Models
{
    public class Material
    {
        public int ID { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

    }
}