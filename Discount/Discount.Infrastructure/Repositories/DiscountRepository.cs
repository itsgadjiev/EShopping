using Discount.Core.Entities;
using Discount.Core.Repositories;
using Discount.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Discount.Infrastructure.Repositories
{
    public class DiscountRepository(AppDbContext appDbContext)
        : IDiscountRepository
    {
        public async Task CreateDiscount(Coupon coupon)
        {
            await appDbContext.Coupons.AddAsync(coupon);
        }

        public async Task DeleteDiscount(Coupon coupon)
        {
            appDbContext.Remove(coupon);
        }

        public async Task<Coupon> GetDiscount(string productName)
        {
            return appDbContext.Coupons.FirstOrDefault(x => x.ProductName == productName);
        }

        public async Task SaveChanges(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            await appDbContext.SaveChangesAsync(cancellationToken);

        }

        public async Task UpdateDiscount(Coupon coupon)
        {
            appDbContext.Update(coupon);
            appDbContext.Entry(coupon).State = EntityState.Modified;
        }
    }
}
