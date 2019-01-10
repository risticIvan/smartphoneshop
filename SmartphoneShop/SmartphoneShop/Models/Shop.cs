using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartphoneShop.Models
{
    public class Shop
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Adress { get; set; }
        [Required]
        [StringLength(60)]
        public string City { get; set; }
        [Required]
        [Range(10000,99999)]
        public int Postcode { get; set; }
        [Required]
        [Phone]
        public string Telephone { get; set; }
        [Required]
        [EmailAddress]
        public int Email { get; set; }
    }
}