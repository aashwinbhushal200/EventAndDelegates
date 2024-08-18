using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAll
{
    class Order
    {
        public event EventHandler OnCreated;

        public void Create()
        {
            Console.WriteLine("Order created");

            if (OnCreated != null)
            {
                OnCreated(this, EventArgs.Empty);
            }
        }
    }




    
}
