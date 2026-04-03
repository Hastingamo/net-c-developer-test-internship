// See https://aka.ms/new-console-template for more information

// task one 
string name = "john doe";
int age = 25;
Boolean isAdmin = true;
Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(isAdmin);

Console.WriteLine();

// task two
Console.WriteLine("please enter a number with no decimal values");
string value = Console.ReadLine();
int result = int.Parse(value);

if (result % 2 == 0)
{
    Console.WriteLine(result + " is an even number");
}
else
{
    Console.WriteLine(result + " is an odd number");
}

Console.WriteLine();

// task 3
for (int values = 0; values < 11; values++ )
{
   
    Console.WriteLine(values);

}
Console.WriteLine();

// task 4

int [] number = { 2, 4, 6, 8, 10 };
foreach (var i in number)
{
    Console.WriteLine(i);
}

Console.WriteLine();

// task 5




void Greet(string name)
{
    Console.WriteLine("Hello, " + name + "!");
}

Greet("Alice");
