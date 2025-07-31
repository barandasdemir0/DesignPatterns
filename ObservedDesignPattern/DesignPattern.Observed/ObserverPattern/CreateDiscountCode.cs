using DesignPattern.Observed.DAL;

namespace DesignPattern.Observed.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts?.Add(new Discount
            {
                DiscountCode = "DERGIMART",
                DiscountCodeStatus = true,
                DiscountAmount = 35
            });
            context.SaveChanges();

        }
    }
}
