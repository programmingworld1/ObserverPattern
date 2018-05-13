using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class User : IObserver
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public User(string firstname, string lastname)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
        }

        public void Update()
        {
            Console.WriteLine("New volkswagen polo's have arrived at the store!");
        }

    }
}
