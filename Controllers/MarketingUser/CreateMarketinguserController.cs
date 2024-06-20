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
    [Route("api/[controller]")]
    public class CreateMarketinguserController : ControllerBase
    {
        public readonly IMarketingUserRepository _marketingUserRepository;
        public CreateMarketinguserController(IMarketingUserRepository marketingUserRepository)
        {
            _marketingUserRepository = marketingUserRepository;
        }

        [HttpPost]
        public IActionResult CreateMarketinguser([FromBody] MarketingUser user)
        {
            _marketingUserRepository.CreateMarketingUser(user);
            return CreatedAtAction(nameof(CreateMarketinguser),new{Message = "Usuario de marketing creado",User = user});
        }
    }
}