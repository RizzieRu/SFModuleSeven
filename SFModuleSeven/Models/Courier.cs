using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SFModuleSeven.Models
{
    internal class Courier : UserBase
    {
        public int PlaceInQueue { get; set; }

        public bool OnRoad { get; set; }

        public int DeliveredOrders { get; set; }

        public override void MakeOrder()
        {
            DeliveredOrders++;
            Console.WriteLine($"Courier {this.Name} just delivered one more order!");
        }

        public Courier(int id, string name, string surName, int placeInQueue, bool onRoad, int deliveredOrders)
        {
            Id = id;

            Name = name;

            SurName = surName;

            PlaceInQueue = placeInQueue;

            OnRoad = onRoad;

            DeliveredOrders = deliveredOrders;
        }
    }
}
