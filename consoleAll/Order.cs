using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace consoleAll
{
    class Order
    {
        public event EventHandler<OrderEventArgs> OnCreated;

        public void Create(string email, string phone)
        {
            Console.WriteLine("Order created");

            if (OnCreated != null)
            {
                OnCreated(this, new OrderEventArgs { Email = email, Phone = phone });
            }
        }
    }
    class OrderEventArgs : EventArgs
    {
        public string Email { get; set; }
        public string Phone { get; set; }
    }





}
