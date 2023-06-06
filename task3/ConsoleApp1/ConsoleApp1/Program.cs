// задача 1


int[,] array = new int[,] { { 30, 40, 66, 0}, { -5, 15, 27, 99 } };

int[][] array2 = new int[][]
{
    new int[] { 5, 7, 12 },
    new int[] { 555, 40, -30},
};


int[][] array3 = new int[5][];
for (int i = 0; i < array3.Length; i++)
{
    array3[i] = new int[] { i*i };
}


int minValue = int.MaxValue;
int maxValue = int.MinValue;

for (int i = 0; i <= array.GetUpperBound(0); i++)
{
    for(int j = 0; j <= array.GetUpperBound(1); j++)
    {

        if (array[i,j] < minValue)
            minValue = array[i,j];

        if (array[i,j] > maxValue)
            maxValue = array[i,j];
    }
}

Console.WriteLine($"Minvalue is {minValue}, maxvalue is {maxValue}");



minValue = int.MaxValue;
maxValue = int.MinValue;

for (int i = 0; i < array2.Length; i++)
{
    for (int j = 0; j < array2[i].Length; j++)
    {
        if (array2[i][j] < minValue)
            minValue = array2[i][j];

        if (array2[i][j] > maxValue)
            maxValue = array2[i][j];
    }
}

Console.WriteLine($"Minvalue is {minValue}, maxvalue is {maxValue}");




// пузырьковая сортировка

int[] unsortedArray = new int[] { 39, 343, 2323, 0, 2, -42, 16, 288 };


for(int i = 0; i< unsortedArray.Length; i++)
{
    for(int j = 0; j < unsortedArray.Length; j++)
    {

        if(j < unsortedArray.Length - 1)
        {

            if (unsortedArray[j] > unsortedArray[j+1])
            {
                int buffer;
                buffer = unsortedArray[j + 1];
                unsortedArray[j+1] = unsortedArray[j];
                unsortedArray[j] = buffer;
            }
        }
    }
}


Console.WriteLine("Sorted array");
for (int i = 0; i < unsortedArray.Length; i++)
    Console.WriteLine(unsortedArray[i]);


// 


Stack<int> stack = new Stack<int>();
stack.Push(123);
stack.Pop();
stack.Peek();


Queue<int> queue = new Queue<int>();
queue.Enqueue(10);
queue.Dequeue();
queue.Peek();


Dictionary<int, object> keyValuePairs = new Dictionary<int, object>();
keyValuePairs.Add(10, "Row Number 10");
Console.WriteLine(keyValuePairs[10]);



string testString = "TestString";
int hash = testString.GetHashCode();

HashSet<string> keys = new HashSet<string>();

keys.Add(testString);





List<int> ints;
ints = new List<int>() { 1, 10, 11, 100, 110 };

ints.Add(1000);
ints.Remove(1);

if (ints.Contains(10))
    Console.WriteLine("Contains");


int count = ints.Count;

var lessThan100 = ints.Where(value => value < 100);

List<int> newInts = new List<int>();
foreach(int i in ints)
{
    if(i < 100)
        newInts.Add(i);
}



var minIntValue = ints.Min();
var maxIntValue = ints.Max();

var lastElement = ints.Last();
var firstElement = ints.First();


var sortedInts = ints.OrderBy(value => value.GetHashCode());



List<User> users = new List<User>();
users.Add(new User() { Id = 0, Name = "AAA"});

var sortedUsers = users
    .OrderBy(value => value.GetHashCode())
    .Where(user => user.Name != null);


sortedUsers.ToList();


var singleUser = sortedUsers.FirstOrDefault(user => user.Id == 0);


// Where 
// Min, Max 
// Count 
// OrderBy 
// Single, SingleOrDefault
// First, FirstOrDefault



IEnumerable<int> CustomWhere(IEnumerable<int> collection, Predicate<int> condition)
{
    List<int> newCollection = new List<int>();

    foreach (int value in collection)
    {
        if (condition(value))
        {
            newCollection.Add(value);
        }
    }

    return newCollection;
}


class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}