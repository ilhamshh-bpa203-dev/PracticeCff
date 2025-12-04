using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CffTask
{
    internal interface ICargoService
    {
        void AddCustomer();
        void AddCourier(Courier courier);
        void CreateOrder();
        void CompleteOrder();
    }
}
