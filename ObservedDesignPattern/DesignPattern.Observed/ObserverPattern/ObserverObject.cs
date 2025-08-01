﻿using DesignPattern.Observed.DAL;

namespace DesignPattern.Observed.ObserverPattern
{
    public class ObserverObject
    {
        private readonly List<IObserver> _observers;
        public ObserverObject()
        {
            _observers = new List<IObserver>();
        }
        //gözlemleyeceğimiz yerleri burada tutacaz

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver(AppUser appUser)
        {
            _observers.ForEach(x =>
            {
                x.CreateNewUser(appUser);
            });
          
        }


    }
}
