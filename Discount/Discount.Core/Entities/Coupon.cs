namespace Discount.Core.Entities;

public record Coupon
{
    public int Id{ get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public int Amount { get; set; }

}
