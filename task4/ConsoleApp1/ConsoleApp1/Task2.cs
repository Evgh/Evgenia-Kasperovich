using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate int FactorialDelegate(int par);

    public static class Task2
    {
        public static FactorialDelegate FactorialHandler;

        public static Func<int, int> FactorialSystemHandler;
        public static Func<int, int> FactorialSystemHandler1;

        private static Action _testEvent;
        public static event Action TestEvent
        {
            add
            {
                _testEvent += value;

                Console.WriteLine("Added to event");
            }
            remove
            {
                _testEvent -= value;

                Console.WriteLine("Removed from event");
            }
        }


        public static void MakeTask()
        {

            _testEvent?.Invoke();
        }
    }
}
