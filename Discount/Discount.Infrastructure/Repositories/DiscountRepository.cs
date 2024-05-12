using Discount.Core.Entities;
using Discount.Core.Repositories;
using Microsoft.Extensions.Configuration;

namespace Discount.Infrastructure.Repositories
{
    public class DiscountRepository()
        : IDiscountRepository
    {
        public Task<Coupon> CreateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }

        public Task<Coupon> DeleteDiscount(string productName)
        {
            throw new NotImplementedException();
        }

        public Task<Coupon> GetDiscount(string productName)
        {
            throw new NotImplementedException();
        }

        public Task<Coupon> UpdateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }
    }
}
