// See https://aka.ms/new-console-template for more information
using Lection5;
using System.Text.Unicode;

Console.WriteLine("Hello, World!");



List<int> list = new List<int>();

list.Single(x => x == 1);



try
{
    GetInt(null);
    Console.WriteLine("Try is done");
}
finally
{
    Console.WriteLine("Finally");
}


Console.WriteLine("End");


int GetInt(string str)
{
    if(str == null)
        return -1;

    return str.Length;
}

void ThrowNotImplementedException()
{
    throw new NotImplementedException();
}

void UsingFunc()
{
    try
    {
        using (FileStream fs = new FileStream("", FileMode.OpenOrCreate))
        {
            fs.Write(System.Text.UTF8Encoding.UTF8.GetBytes("Hello"));
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
}


void Func(List<int> list)
{
    try
    {
        list.Add(1);
    }
    catch (NullReferenceException)
    {

    }
    catch
    {
        // обработка исключения
        throw;
    }
    finally
    {
        // выполнится в любом случае
    }
}



