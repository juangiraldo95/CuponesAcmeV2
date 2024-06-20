using Cuponesv2.Models;

namespace CuponesV2.Services
{
    public interface ICouponsUsagesRepository
    {
        void Create (CouponUsage couponsusage);
        void Update (CouponUsage couponsusage);
        void Delete (CouponUsage couponsusage);
        IEnumerable <CouponUsage> GetAll ();
        Role GetById (int id);
    }
}