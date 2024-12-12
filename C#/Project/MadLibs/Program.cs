/*
Mad Libs Word Game
Author: Keith Heffington
*/

// Let the user know that the program is starting:
Console.WriteLine("The Mad Lib Game has started!");



// Give the Mad Lib a title:
string title = "Your fun adventure";

Console.WriteLine(title);
// Define user input and variables:
Console.Write("Enter a name: ");
string name = Console.ReadLine();

Console.Write("Enter a color: ");
string color = Console.ReadLine();

Console.Write("Enter a feeling: ");
string feeling = Console.ReadLine();

Console.Write("Enter a texture: ");
string texture = Console.ReadLine();

Console.Write("Enter an action: ");
string action = Console.ReadLine();

Console.Write("Enter a type of person (Boy or Girl): ");
string person = Console.ReadLine();

Console.Write("Enter a place: ");
string place = Console.ReadLine();

Console.Write("Enter an animal: ");
string animal = Console.ReadLine();

Console.Write("Enter a food: ");
string food = Console.ReadLine();

Console.Write("Enter a fruit: ");
string fruit = Console.ReadLine();

Console.Write("Enter a superhero: ");
string superhero = Console.ReadLine();

Console.Write("Enter a country: ");
string country = Console.ReadLine();

Console.Write("Enter a dessert: ");
string dessert = Console.ReadLine();

Console.Write("Enter a year: ");
string year = Console.ReadLine();



// The template for the story:

string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";

// Print the story:

Console.WriteLine(story);
