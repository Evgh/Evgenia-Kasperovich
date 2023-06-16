using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Book
    {
        public int Id; 


        public delegate void ReadAction(Book book);
        public delegate void ReadCompletedHandler();

        public ReadCompletedHandler ReadCompleted;


        public Action SimpleAction;
        public delegate void SimpleActionHandler();

        public Action<int> ParametrizedAction;
        public delegate void ActionHandler(int a);

        public Func<int, int> SimpleFunc;
        public delegate int FuncDelegate(int i);


        public Predicate<int> Predicate;
        public delegate bool PredicateDelegate(int a);


        public int Method(int i, string s)
        {
            return 0;
        }

        public bool PredicateMethod(int i)
        {
            return i > 0;
        }

        public abstract void Read(ReadAction action);
    }

    public class PaperBook : Book
    {
        public override void Read(ReadAction action)
        {
            action?.Invoke(this);

            ReadCompleted?.Invoke();
        }
    }

    public class ElectroBook : Book
    {
        public override void Read(ReadAction action)
        {
            action?.Invoke(this);

            ReadCompleted?.Invoke();
        }
    }

}
