using DesignPattern.Observed.DAL;

namespace DesignPattern.Observed.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
