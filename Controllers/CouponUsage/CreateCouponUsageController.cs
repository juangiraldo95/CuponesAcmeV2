using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cuponesv2.Models;
using CuponesV2.Services;
using Microsoft.AspNetCore.Mvc;

namespace CuponesV2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateCouponUsageController : ControllerBase
    {
        public readonly ICouponsUsagesRepository _couponsUsagesRepository;

        public CreateCouponUsageController(ICouponsUsagesRepository couponsUsagesRepository)
        {
            _couponsUsagesRepository = couponsUsagesRepository;
        }
        [HttpPost]
        public IActionResult Post([FromBody] CouponUsage couponUsage)
        {
            if (couponUsage == null)
            {
                return BadRequest();
            }
            try
            {
                _couponsUsagesRepository.Create(couponUsage);
                return CreatedAtAction(nameof(Post), new { Message = "creado", CouponUsage = couponUsage });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}