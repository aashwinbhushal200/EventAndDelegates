using System.Reflection.Metadata.Ecma335;

namespace consoleAll
{
    internal class DelegateExample
    {
        delegate string delegate1(string s);
        //Multicast delegate eg
        delegate int calculate(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TestClasss tc= new TestClasss();
            MulticastDelegateExample mc= new MulticastDelegateExample();

            //old method Console.WriteLine(tc.addingName("aswin"));

            /*delegate1 del1 = new delegate1 (tc.addingName);
             Console.WriteLine(del1("bikash")) ;
             */

            //second way to use buil-in  delegate Func
            Func<string,string> del2 = tc.addingName;
            Console.WriteLine(del2("bikash"));


            //Multicast delegate
            calculate calc = new calculate(mc.add);
            Console.WriteLine("addition "+calc(5,3));
            calc += mc.subtract;
            Console.WriteLine("subtract "+calc(5, 3));

            //anonymous delegate

            calculate calc2 = delegate(int a, int b) { return a % b; };
            Console.WriteLine("Modulo div "+calc(5, 3));

            Console.WriteLine("event hanlding with delegates ");
            //event hanlding with delegates
            //create object
            SimpleEventDelegateExample simpleEventDelegate = new SimpleEventDelegateExample();
            //suscribe by attaching to handleevent
            simpleEventDelegate.simplehandler += HandleEvent;
            //call to trigger
            simpleEventDelegate.EventTrigger();

            //event halding part2
            Console.WriteLine("event hanlding part2  ");
            Order newOrder = new Order();
            newOrder.OnCreated += Email.Send;
            newOrder.OnCreated += SMS.Send;
            newOrder.Create();


        }
        static void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("HandleEvent called");
        }
   

    }

    class Email
    {
        public static void Send(object sender, EventArgs e)
        {
            Console.WriteLine($"Send an email");
        }
    }

    class SMS
    {
        public static void Send(object sender, EventArgs e)
        {
            Console.WriteLine($"Send an SMS");
        }
    }

}
