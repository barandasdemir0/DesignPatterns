using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class Decorator : INotifier
    {

       
        private readonly INotifier _notifier;

        public Decorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        virtual public void CreateNotify(Notifier notifier)
        {
            notifier.NotifierCreator = "Admin";
            notifier.NotifierCreator = "Toplantı";
            notifier.NotifierCreator = "Public";
            notifier.NotifierCreator = "Whatsapp";
            _notifier.CreateNotify(notifier);
        }
    }
}
