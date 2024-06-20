using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CuponesAcmeV2.Services;
using Cuponesv2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CuponesV2.Controllers
{
    [ApiController]
    
    public class ListMarketinguserController : ControllerBase
    {
        public readonly IMarketingUserRepository _rolesRepository;
        public ListMarketinguserController(IMarketingUserRepository rolesRepository)
        {
            _rolesRepository = rolesRepository;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IEnumerable<MarketingUser> GetMarketingUser(){

            return _rolesRepository.GetAllMarketingUser();
            
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public MarketingUser GetMarketingUserById(int id){

            return _rolesRepository.GetByIdMarketingUser(id);
            
        }


    }
}