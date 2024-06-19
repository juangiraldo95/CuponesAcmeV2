using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace  Cuponesv2.Models
{
    public class Coupon
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "El campo Description es requerido.")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "El campo StartDate es requerido.")]
        public DateOnly StartDate { get; set; }
        [Required(ErrorMessage = "El campo EndDate es requerido.")]
        public DateOnly EndDate { get; set; }
        [Required(ErrorMessage = "El campo DiscountType es requerido.")]
        public string? DiscountType { get; set; }
        [Required(ErrorMessage = "El campo DiscountValue es requerido.")]
        public decimal DiscountValue { get; set; }
        [Required(ErrorMessage = "El campo UsageLimit es requerido.")]
        public int UsageLimit { get; set; }
        [Required(ErrorMessage = "El campo MinPurchaseAmount es requerido.")]
        public decimal MinPurchaseAmount { get; set; }
        [Required(ErrorMessage = "El campo MaxPurchaseAmount es requerido.")]
        public decimal MaxPurchaseAmount { get; set; }
        [Required(ErrorMessage = "El campo Status es requerido.")]
        public string? Status { get; set; }
        [Required(ErrorMessage = "El campo CreatedBy es requerido.")]
       
        public int CreatedBy { get; set; }//esto va a dar error

        public MarketplaceUser? MarketplaceUser { get; set; }
        
        [JsonIgnore]
        public List<Coupon>? Coupons { get; set; }
       

       [JsonIgnore]
        public List<CouponHistory>? CouponHistories { get; set; }

        

    } 
}