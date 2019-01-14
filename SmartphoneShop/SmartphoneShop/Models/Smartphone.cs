using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartphoneShop.Models
{
    public class Smartphone
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Brand { get; set; }
        [Required]
        [StringLength(50)]
        public string Model { get; set; }
        [Required]
        [StringLength(30)]
        public string OS { get; set; }
        [Required]
        [Range(0.1,8)]
        public decimal ScreenDiagonal { get; set; }
        [Required]
        [StringLength(50)]
        public string Chipset { get; set; }
        [Required]
        [Range(0.5,32)]
        public decimal Ram { get; set; }
        [Required]
        [Range(1,50)]
        public decimal FrontCamera { get; set; }
        [Required]
        [Range(1,50)]
        public decimal BackCamera { get; set; }
        [Required]
        [Range(1, 8000)]
        public int BatteryCapacity {get; set; }
        [Required]
        [Range(1,2000)]
        public decimal Price { get; set; }

        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}