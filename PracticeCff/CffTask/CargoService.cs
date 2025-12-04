using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CffTask
{
    internal class CargoService:ICargoService
    {
        public List<CargoOrder> CargoOrders = new List<CargoOrder>();
        public List<Courier> Couriers = new List<Courier>();
        public List<Customer> Customers = new List<Customer>();

        public void AddCourier()
        {

        }


        public void AddCustomer()
        {
            throw new NotImplementedException();
        }

        public void CompleteOrder()
        {
            throw new NotImplementedException();
        }

        public void CreateOrder()
        {
            throw new NotImplementedException();
        }
    }
}
