
using Cuponesv2.Models;
using CuponesV2.Data;

namespace CuponesAcmeV2.Services
{
    public class MarketingUserRepository : IMarketingUserRepository
    {
        
        private readonly BaseContext _context;
        public MarketingUserRepository(BaseContext context)
        {
            _context = context;
        }

        public void CreateMarketingUser(MarketingUser user)
        {
            _context.MarketingUsers.Add(user);
            _context.SaveChanges();
        }

        public IEnumerable<MarketingUser> GetAllMarketingUser()
        {
            return _context.MarketingUsers.ToList();
        }

        public MarketingUser GetByIdMarketingUser(int userId)
        {
            return _context.MarketingUsers.Find(userId);
        }


        public void UpdateMarketingUser(MarketingUser user)
        {
            _context.MarketingUsers.Update(user);
            _context.SaveChanges();
        }
    }
}