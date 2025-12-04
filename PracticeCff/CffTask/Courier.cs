using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CffTask
{
    public class Courier
    {
        private static int _id;
        public int Id { 
            get { return _id; } 
            set
            {
                _id = value;
            }
        }
        public string Name;
        public bool IsAvailable = false;


        public Courier(string name, bool isavailable)
        {
            _id++;
            Name = name;
            IsAvailable = isavailable;

        }


    }
}
