using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObservable
    {
        void Attach(User user);

        void Detach(User user);

        void Notify();
    }
}
