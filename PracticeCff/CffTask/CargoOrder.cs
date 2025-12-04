using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CffTask
{
        class CargoOrder
        {
            private static int Id { get; set; }

            private int CustomerId { get; set; }

            private int CourierId { get; set; }

            public int TotalAmount { get; set; }

            public OrderStatus Status { get; set; } = OrderStatus.Created;

            public DateTime CreatedAt { get; set; } = DateTime.Now;


            static CargoOrder()
            {
                Id = 0;
                Id++;
            }
            public void UpdateStatus(OrderStatus newStatus)
            {
                if (newStatus == OrderStatus.Cancelled && Status == OrderStatus.Delivered)
                {
                    throw new InvalidOperationException("Cannot cancel an order that has already been delivered.");
                }

                Status = newStatus;
            }


        }
    
}
