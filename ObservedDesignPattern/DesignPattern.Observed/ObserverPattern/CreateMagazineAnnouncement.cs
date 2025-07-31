using DesignPattern.Observed.DAL;

namespace DesignPattern.Observed.ObserverPattern
{
    public class CreateMagazineAnnouncement:IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses?.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.SurName,
                Magazine = "Bilim Dergisi",
                Content = "Bilim Dergimizin ağustos sayısı 1 martta evinize ulaştırılacaktır konular jupiter ve mars gezegenleri olacaktır"
            });
            context.SaveChanges();
        }
    }
}
