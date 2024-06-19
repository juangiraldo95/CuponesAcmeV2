using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace  Cuponesv2.Models
{
    public class UserRole
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "El campo UserId es requerido.")]
        public int UserId { get; set;}
        [Required(ErrorMessage = "El campo RoleId es requerido.")]
        public int RoleId { get; set;}

        public MarketplaceUser? MarketplaceUsers { get; set; }

        public Role? Roles { get; set; }
       
        
    }
}