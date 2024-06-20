using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuponesAcmeV2.Dtos
{
    public class MarketingUserDto
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "El campo UserName es requerido.")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "El campo Password es requerido.")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "El campo Email es requerido.")]
        public string? Email { get; set; }    
    }
}