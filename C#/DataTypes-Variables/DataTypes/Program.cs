// See https://aka.ms/new-console-template for more information


// Creating Variables with Types
// Create Variables
string name = "Shadow";
string breed = "Golden Retriever";
int age = 5;
double weight = 65.22;
bool spayed = true;

// Print variables to the console
Console.WriteLine($"Your dogs name is {name}.");
Console.WriteLine($"Your dogs breed is {breed}.");
Console.WriteLine($"Your dogs age is {age}.");
Console.WriteLine($"Your dogs weight is {weight}.");
Console.WriteLine($"Your dog is spayed {spayed}.");


// Converting Data Types
// Ask user for fave number
Console.Write("Enter your favorite number!: ");

// Turn that answer into an int
int faveNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your favorite number is {faveNumber}.");

/*How data types and variables work in C#
      C# built-in data types, including int, double, char, string, and bool
      how to create, name, and use variables
      converting data types from one to another
*/
