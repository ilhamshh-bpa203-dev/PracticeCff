using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CffTask
{
    public class Courier
    {
        private static int Id;
        public string Name;
        public bool IsAvailable = false;

        public Courier(string name, bool isavailable)
        {
            Id++;
            Name = name;
            IsAvailable = isavailable;

        }


    }
}
