using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SFModuleSeven.Models
{
    internal class Customer : UserBase
    {
        public int OrdersCount { get; set; }

        public string? LastDeliveryAddress { get; set; }

        // in real project this can be taken from DB
        private string Salt { get; set; }

        private string PasswordHash { get; set; }

        private void SetPassword(string password)
        {
            byte[] saltBytes = new byte[16];
            RandomNumberGenerator.Fill(saltBytes);
            Salt = Convert.ToBase64String(saltBytes);

            PasswordHash = HashPassword(password, Salt);
        }

        private string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(saltedPasswordBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        public bool VerifyPassword(string password)
        {
            if (Salt == null)
                return false;

            string hash = HashPassword(password, Salt);
            return hash == PasswordHash;
        }

        public override void MakeOrder()
        {
            OrdersCount++;
            Console.WriteLine($"Customer {this.Name} just makes an order!");
        }

        public Customer(int id, string name, string surName, string password, int ordersCount = 0, string? lastDeliveryAddress = null)
        {
            Id = id;

            Name = name;

            SurName = surName;

            LastDeliveryAddress = lastDeliveryAddress;

            OrdersCount = ordersCount;

            // Salt + PasswordHash
            SetPassword(password);
        }
    }
}
