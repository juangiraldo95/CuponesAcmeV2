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
        public DbSet<CouponUsage> CouponesUsage { get; set; }
        public DbSet<MarketingUser> MarketingUser  { get; set; }
        public DbSet<MarketplaceUser> MarketplaceUser { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<PurchaseCoupon> PurchaseCoupon { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
    }
}