using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel();

            User subscriberMurat = new User("Murat", "Yilmaz");
            User subscriberSultan = new User("Sultan", "The Lion King");

            channel.Attach(subscriberMurat);
            channel.Attach(subscriberSultan);

            channel.Notify();

            Console.ReadLine();
        }
    }
}
