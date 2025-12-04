using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CffTask
{
    public class Customer
    {
        private static int Id;
        public string Name;
        public string City;

        public Customer(string name, string city)
        {
            Id++;
            Name = name;
            City = city;

        }


    }
}
