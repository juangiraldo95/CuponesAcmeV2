using CuponesAcmeV2.Services;
using Cuponesv2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CuponesV2.Controllers
{
    [ApiController]

    public class UpdateMarketinguserController : ControllerBase
    {
        public readonly IMarketingUserRepository _marketingUserRepository;
        public UpdateMarketinguserController(IMarketingUserRepository marketingUserRepository)
        {
            _marketingUserRepository = marketingUserRepository;
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult UpdateMarketinguser([FromBody] MarketingUser user,int id )
        {

            var userById = _marketingUserRepository.GetByIdMarketingUser(id);

            if (userById == null)
            {
                return NotFound();
            }

            user.UserName = userById.UserName;
            user.Password = userById.Password;
            user.Email = userById.Email;

            _marketingUserRepository.UpdateMarketingUser(user);
            return Ok( "Usuario de marketing Actualizado");
        }
    }
}