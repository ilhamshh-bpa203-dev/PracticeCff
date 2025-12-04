using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CffTask
{
    internal interface ICargoService
    {
        void AddCustomer(string name, string city);
        void AddCourier(Courier courier);
        void CreateOrder();
        void CompleteOrder();
    }
}
