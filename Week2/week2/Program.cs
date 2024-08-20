//Control flow statements
int a = 10;
int b = 20;

if (a > b)
{
    Console.WriteLine("a is greater than b");
}else if (a == b)
{
    Console.WriteLine("a is equal to b");
}
else
{
    Console.WriteLine("b is greater than a");
}

switch (a)
{
    case 10:
        Console.WriteLine("a is 10");
        break;
    case 20:
        Console.WriteLine("a is 20");
        break;
    default:
        Console.WriteLine("a is not 10 or 20");
        break;
}

// Arrays and Lists
int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i + 10;
}

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

List<int> numbersList = new List<int>();

for (int i = 0; i < 5; i++)
{
    numbersList.Add(i + 10);
}

foreach (int number in numbersList)
{
    Console.WriteLine(number);
}

// Methods and Functions
int Add(int a, int b)
{
    return a + b;
}

int result = Add(10, 20);
Console.WriteLine(result);

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

PrintMessage("Hello World");
