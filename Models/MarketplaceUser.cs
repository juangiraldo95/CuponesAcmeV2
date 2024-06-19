using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace  Cuponesv2.Models
{
    public class MarketplaceUser
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "El campo UserName es requerido.")]
        public int UserName { get; set;}
        [Required(ErrorMessage = "El campo Password es requerido.")]
        public int Password { get; set;}
        [Required(ErrorMessage = "El campo Email es requerido.")]
        public int Email { get; set;}

        [JsonIgnore]
        public List<UserRole>? UserRoles { get; set; }

        [JsonIgnore]
        public List<Purchase>? Purchases { get; set; }
         [JsonIgnore]
        public List<CouponUsage>? CouponsUsages { get; set; }
    }
}