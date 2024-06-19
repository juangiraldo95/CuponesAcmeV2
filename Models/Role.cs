using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace  Cuponesv2.Models
{
    public class Role
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        [StringLength(20, ErrorMessage = "El campo Nombre debe tener entre 1 y 20 caracteres.", MinimumLength = 1)]
        public string? Name { get; set; }

        [JsonIgnore]
        public List<UserRole>? UserRoles { get; set; }
    }
}