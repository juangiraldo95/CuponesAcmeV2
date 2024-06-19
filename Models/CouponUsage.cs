using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace  Cuponesv2.Models
{
    public class CouponUsage
    {
        
        public int Id { get; set;}
        [Required(ErrorMessage = "El campo CouponId es requerido.")]
        public int CouponId { get; set;}
        [Required(ErrorMessage = "El campo UserId es requerido.")]
        public int UserId { get; set;}
        [Required(ErrorMessage = "El campo UsageDate es requerido.")]
        public DateOnly UsageDate { get; set;}
        [Required(ErrorMessage = "El campo TransactionAmount es requerido.")]
        public decimal TransactionAmount { get; set;}

        public Coupon? Coupons { get; set; }
        public MarketplaceUser? MarketplaceUsers { get; set; }

    }
}