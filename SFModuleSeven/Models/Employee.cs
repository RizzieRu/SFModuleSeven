using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFModuleSeven.Models
{
    internal class Employee : UserBase
    {
        public string Position { get; set; }

        public int CountOfDeals { get; set; }

        public Employee(int id, string name, string surName, string position = "intern")
        {
            Id = id;
            
            Name = name;

            SurName = surName;

            Position = position;
        }

        public override void MakeOrder()
        {
            CountOfDeals++;
            Console.WriteLine($"Employee {this.Name} created a new order");
        }
    }
}
