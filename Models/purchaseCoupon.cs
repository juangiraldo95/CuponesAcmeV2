using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace  Cuponesv2.Models
{
    public class PurchaseCoupon
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "El campo PurchaseId es requerido.")]
        public int PurchaseId { get; set;}
        [Required(ErrorMessage = "El campo CouponId es requerido.")]
        public int CouponId { get; set;}

        public Purchase? Purchases { get; set; }
    }
}