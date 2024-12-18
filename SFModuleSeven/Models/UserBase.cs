using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SFModuleSeven.Models
{
    internal abstract class UserBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public virtual void MakeOrder()
        {
            Console.WriteLine("New order just created!");
        }
    }
}
