//Making comments in C#
/*Multi-line comments
are made like this in C# */


//How to print basic text
Console.WriteLine("Hello World!");


//Getting Input
Console.WriteLine("How old are you?");
string input = Console.ReadLine();
Console.WriteLine($"You are {input} years old!");
// The code is ran in bash and is triggered by "$ dotnet run"


/* This variable will be used to count the number of times anyone tweets the word persnickety */
int persnicketyCount = 0;
/* Calculates tomorrow's rain likelihood as a number between 0 and 100 */
ComplicatedRainCalculationForTomorrow();

//C# and it's alternatives like .NET allow more input per second from users - making busy websites faster than with JS
/* C# is used to make interactive websites, mobile apps, video games, augmented and virtual reality (AR and VR), back-end services, and desktop applications */
// .NET generally refers to the family of programs and commands that let you make applications with C#


//Data Types and Variables
//Data Types
/*  int - whole numbers, like: 1, -56, 948
    double - decimal numbers, like: 239.43909, -660.01
    char - single characters, like: “a”, “&”, “£”
    string - string of characters, like: “dog”, “hello world”
    bool - boolean values, like: true or false  */

//Creating Variables with Types
// Declare an integer
int myAge;
myAge = 32;
// Declare a string
string countryName = "Netherlands";

/* Once we’ve defined a variable, we can use them throughout our program. For example, here’s a short program that
prints a few  math equations to the console:    */
int evenNumber = 22;
int oddNumber = 45;
Console.WriteLine(evenNumber + oddNumber); // Prints 67
Console.WriteLine(oddNumber - evenNumber); // Prints 23

//Using multiple Variable sets
using System;

namespace Form
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create Variables
string name = "Shadow";
string breed = "Golden Retriever";
int age = 5;
double weight = 65.22;
bool spayed = true;
      // Print variables to the console
Console.WriteLine(name);
Console.WriteLine(breed);
Console.WriteLine(age);
Console.WriteLine(weight);
Console.WriteLine(spayed);
    }
  }
}


