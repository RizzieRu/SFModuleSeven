using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFModuleSeven.Models
{
    internal class PickPointDelivery : DeliveryBase
    {
        public PickPointDelivery(string address)
        {
            Address = address;
        }
    }
}
