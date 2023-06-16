using ConsoleApp1;
using System.Text;

var strB = new StringBuilder();// 1

strB.Append("");
strB.ToString(); // 2

var message = "Hello"; // 1
message += ", World"; // 2

Console.WriteLine(message);


message += ", I'm glad";

Console.WriteLine(message + " to see you");


Console.WriteLine(factorial(4));
Console.WriteLine(FactorialWithoutRecursion(4));


var book = new PaperBook();

book.ReadCompleted += () => Console.WriteLine("Read completed");
book.ReadCompleted += WriteToConsoleAgain;


book.Read(book => Console.WriteLine("Readed book: " + book.GetType()));
book.Read((book) =>
{
    Console.WriteLine("Readed book again: " + book.GetType());
});

Task2.FactorialHandler += (number) =>
{
    Console.WriteLine($"Вычисляем факториал для числа: {number}. Результат:");
    return number;
};
Task2.FactorialHandler += FactorialWithoutRecursion;
var result = Task2.FactorialHandler?.Invoke(5);

Console.WriteLine(result);


List<int> numbers = new List<int>() { 0, 12, 03, 232, 2323, 122243 };

numbers.Where((number) => number < 100);
numbers.First(number => 
{
    return number % 2 == 0;
});


numbers.OrderBy((number) => { return number; });


List<Book> books = new List<Book>() { new PaperBook() };
books.OrderBy((book) => book.Id);







var test = numbers.Where(num => true);
Console.WriteLine(test.ToList());

Task2.FactorialSystemHandler += num => num;
Task2.FactorialSystemHandler += FactorialWithoutRecursion;

Task2.FactorialSystemHandler1 = Task2.FactorialSystemHandler;

Console.WriteLine(Task2.FactorialSystemHandler1?.Invoke(6));





//var moto = new Motorcycle();

//moto.Delegate += PrintFactorial;
//moto.Delegate += 

//(int i) =>
//{
//    Console.WriteLine("Lambda" + i);
//    return i;
//};

//moto.Delegate?.Invoke(5);




//var collection = new List<Motorcycle>();


//collection.Where(x => x.Delegate != null);

static int ReturnNumber(int number)
{
    return number;
}


static int FactorialWithoutRecursion(int parameter)
{
    int factorialResult = 1;


    while (parameter > 1)
    {
        factorialResult *= parameter;
        parameter--;
    }

    return factorialResult;
}


void WriteToConsoleAgain()
{
    Console.WriteLine("Read completed again");
}


static int NotFactorial(int i)
{
    //Console.WriteLine("Function" + factorial(i));
    return i;
}


static int factorial(int i)
{
    int result;

    if (i == 1)
        return 1;

    result = factorial(i - 1) * i;
    return result;
}


public delegate int PerformCalculation(int x);



class Motorcycle
{
    public PerformCalculation Delegate;




    // Anyone can call this.
    public void StartEngine() {/* Method statements here */ }

    // Only derived classes can call this.
    protected void AddGas(int gallons) { /* Method statements here */ }

    // Derived classes can override the base class implementation.
    public virtual int Drive(in int miles, out int speed, bool logCountings = false) 
    { /* Method statements here */ 
        
        speed = 0;

        return 1; 
    }
}
