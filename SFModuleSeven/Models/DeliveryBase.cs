using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFModuleSeven.Models
{
    abstract class DeliveryBase
    {
        public string Address { get; set; }
    }
}
