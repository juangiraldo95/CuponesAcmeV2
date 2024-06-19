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
    public class ListRoleController : ControllerBase
    {
        public readonly IRolRespository _rolesRepository;
        public ListRoleController(IRolRespository rolesRepository)
        {
            _rolesRepository = rolesRepository;
        }

        [HttpGet]
        public IEnumerable<Role> GetRoles(){

            return _rolesRepository.GetAll();
            
        }
        
        
    }
}