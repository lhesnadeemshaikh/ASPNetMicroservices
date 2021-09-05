namespace Discount.API.Entities
{
    public class Coupon
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        private static readonly Coupon _DefaultCoupon = new() { Amount = 0, Description = "No Discount", ProductName = "No Discount" };
        public static Coupon DefaultCoupon => _DefaultCoupon;
    }
}