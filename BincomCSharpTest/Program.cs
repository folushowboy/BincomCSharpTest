using System;

// TASK 1: Declare and initialize variables

string name = "Odusina Tolulope";
int age = 25;
bool isAdmin = true;

Console.WriteLine("TASK 1: Variables");
Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Is Admin: " + isAdmin);

Console.WriteLine();


// TASK 2: Check if a number is even or odd

Console.WriteLine("TASK 2: Even or Odd");
Console.Write("Enter an integer: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}

Console.WriteLine();


// TASK 3: Print numbers from 1 to 10 using a for loop

Console.WriteLine("TASK 3: Numbers from 1 to 10");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine();


// TASK 4: Calculate the sum of an array using foreach

Console.WriteLine("TASK 4: Array Elements and Sum");

int[] numbers = { 2, 4, 6, 8, 10 };
int sum = 0;

foreach (int item in numbers)
{
    Console.WriteLine(item);
    sum = sum + item;
}

Console.WriteLine("Sum: " + sum);

Console.WriteLine();


// TASK 5: Create and call the Greet method

Console.WriteLine("TASK 5: Greeting");

Greet("Alice");

void Greet(string name)
{
    Console.WriteLine("Hello, " + name + "!");
}