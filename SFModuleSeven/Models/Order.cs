using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFModuleSeven.Models
{
    internal class Order<TDelivery, TStatus, TPayment> where TDelivery : DeliveryBase
    {
        public TDelivery Delivery;

        public int Id;

        public string? Description;

        // can have object with specific fields or simple text description. E.X: { ProviderId: 1, PostPayment: true, PaymentStatus: 1 } or "Cash".
        public TPayment PaymentMethod { get; set; }

        public int PaymentPrice { get; set; }
        public Customer Customer { get; set; }

        public Employee? Employee { get; set; }

        public Courier? Courier { get; set; }

        public Package Package { get; set; }

        // probably numeric or text status 
        public TStatus Status { get; set; }

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        public Order(TDelivery delivery, TStatus status, TPayment paymentMethod, int id, Customer customer, Employee? employee = null, Courier? courier = null, string? description = null)
        {
            Id = id;

            Delivery = delivery;

            Status = status;

            PaymentMethod = paymentMethod;

            Customer = customer;

            Employee = employee;

            Courier = courier;
            
            Description = description;
        }
    }
}
