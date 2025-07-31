using DesignPattern.Observed.DAL;

namespace DesignPattern.Observed.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages?.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.UserName,
                Content = "Dergi Bültenimize Kyıt olduğunuz için teşekkürler. Dergilerimize web sitesinden ulaşabilirsiniz"
            });
            context.SaveChanges();
        }
    }
}
