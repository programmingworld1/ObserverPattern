using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class VolkswagenPolo : IObservable
    {
        private readonly List<User> _observers;

        public VolkswagenPolo()
        {
            _observers = new List<User>();
        }

        public void Attach(User user)
        {
            _observers.Add(user);
        }

        public void Detach(User user)
        {
            _observers.Remove(user);
        }

        public void Notify()
        {
            foreach (var user in _observers)
            {
                user.Update();
                Detach(user);
            }
        }
    }
}
