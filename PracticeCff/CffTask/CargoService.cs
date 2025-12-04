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


        public void AddCourier(Courier courier)
        {
            if(Couriers.Any(c => c.Id == courier.Id))
            {
               throw new Exception("Courier already exists");
            }
            else
            {
                Couriers.Add(courier);
            }
        }


        public void AddCustomer(string name, string city)
        {
        Customer _customer = new();


            _customer.Name = name;
            _customer.City = city;
            Customers.Add(_customer);
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
