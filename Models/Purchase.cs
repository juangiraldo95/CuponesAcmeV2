using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace  Cuponesv2.Models
{
    public class Purchase
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "El campo UserId es requerido.")]
        public int UserId { get; set;}
        [Required(ErrorMessage = "El campo Date es requerido.")]
        public DateOnly Date { get; set;}
        [Required(ErrorMessage = "El campo Amount es requerido.")]
        public decimal Amount { get; set;}

        public MarketplaceUser? MarketplaceUsers { get; set; }

        [JsonIgnore]
        public List<PurchaseCoupon>? PurchaseCoupons { get; set; }

        
    }
}