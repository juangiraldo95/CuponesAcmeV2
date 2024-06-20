using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cuponesv2.Models;
using Microsoft.EntityFrameworkCore;

namespace CuponesV2.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options){}
        
        public DbSet<Coupon> Coupones { get; set; }
        public DbSet<CouponHistory> CouponsHistories { get; set; }
        public DbSet<CouponUsage> CouponsUsages { get; set; }
        public DbSet<MarketingUser> MarketingUser  { get; set; }
        public DbSet<MarketplaceUser> MarketplaceUser { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<PurchaseCoupon> PurchaseCoupon { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
    }
}