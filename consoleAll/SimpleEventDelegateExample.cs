using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAll
{
    public class SimpleEventDelegateExample
    {
        public event EventHandler simplehandler;
        public void EventTrigger()
        {
            OnInvoke();
        }
        protected virtual void OnInvoke() { 
            simplehandler?.Invoke(this, EventArgs.Empty);
        }

    }
}
