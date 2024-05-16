using Discount.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Core.Repositories;

public interface IDiscountRepository
{
    Task<Coupon> GetDiscount(string productName);
    Task UpdateDiscount(Coupon coupon);
    Task CreateDiscount(Coupon coupon);
    Task DeleteDiscount(Coupon coupon);
    Task SaveChanges(CancellationToken cancellationToken = default);

}
