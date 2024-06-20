
using Cuponesv2.Models;
using CuponesV2.Data;
using CuponesV2.Services;

namespace CuponesV2.Services
{
    public class CouponsUsagesRepository : ICouponsUsagesRepository
    {
        private readonly BaseContext _context;
        public CouponsUsagesRepository(BaseContext context)
        {
            _context = context;
        }
        public void Create (CouponUsage couponusage)
        {
            _context.Add(couponusage);
            _context.SaveChanges();
        }

        public void Delete(CouponUsage couponsusage)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CouponUsage> GetAll()
        {
            return _context.CouponsUsages.ToList();
        }

        public Role GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CouponUsage couponsusage)
        {
            throw new NotImplementedException();
        }
    }
}