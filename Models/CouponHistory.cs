using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace  Cuponesv2.Models
{
    public class CouponHistory
    {
        public int Id { get; set;}
        
        [Required(ErrorMessage = "El campo CouponId es requerido.")]
        public int CouponId { get; set;}

        [Required(ErrorMessage = "El campo ChangeDate es requerido.")]

        public DateOnly ChangeDate { get; set;}

        [Required(ErrorMessage = "El campo FieldChanged es requerido.")]
        public string? FieldChanged { get; set;}

        [Required(ErrorMessage = "El campo OldValue es requerido.")]
        public string? OldValue { get; set;}

        [Required(ErrorMessage = "El campo NewValue es requerido.")]
        public string? NewValue { get; set;}


        public Coupon? Coupons { get; set; }
    
    }
}