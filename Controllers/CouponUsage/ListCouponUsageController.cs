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
    public class ListCouponUsageController : ControllerBase
    {
        public readonly ICouponsUsagesRepository _couponUsageRepository;
        public ListCouponUsageController(ICouponsUsagesRepository couponUsageRepository)
        {
            _couponUsageRepository = couponUsageRepository;
        }

        [HttpGet]
        public IEnumerable<CouponUsage> GetCouponUsages(){
            
            return _couponUsageRepository.GetAll();
        }
    }

}