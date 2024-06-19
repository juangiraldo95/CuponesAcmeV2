using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cuponesv2.Models;
using CuponesV2.Services.Rol;
using Microsoft.AspNetCore.Mvc;

namespace CuponesV2.Controllers.Rol
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateRoleController : ControllerBase
    {
        public readonly IRolRespository _rolesRepository;
        public CreateRoleController(IRolRespository rolesRepository)
        {
            _rolesRepository = rolesRepository;
        }
        [HttpPost]
        public IActionResult Post([FromBody] Role role)
        {

            if (role == null)
            {
                return BadRequest();
            } 
              
            try{

                _rolesRepository.Create(role);
                return CreatedAtAction(nameof(Post),new{Message = "creado",Role = role});
                
            }catch(Exception e){
                return BadRequest(e.Message);
            }

            
        }
    }
}