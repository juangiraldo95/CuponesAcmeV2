using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cuponesv2.Models;

namespace CuponesAcmeV2.Services
{
    public interface IMarketingUserRepository
    {
        IEnumerable<MarketingUser> GetAllMarketingUser ();
        MarketingUser GetByIdMarketingUser (int id);
        void CreateMarketingUser(MarketingUser user);
        void UpdateMarketingUser(MarketingUser user);

    }
}