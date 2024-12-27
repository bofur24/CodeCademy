// IF Statements

int socks = 3;
socks += 2;
if (socks <= 3) {
  Console.WriteLine("Time to do laundry!");
} 
  Console.WriteLine("If false, Time to do laundry! will be skipped.");
Console.WriteLine();

// If-Else Statements

Console.WriteLine("We will go eat at SaladMart if the line is 10 or less people and the weather is nice");

int people = 10;
string weather = "nice";
if (people <= 10 && weather == "nice"){
  Console.WriteLine($"The line for SaladMart is {people} and the weather is {weather}");
  Console.WriteLine("We will eat at SaladMart");
} else {
  Console.WriteLine($"We will eat at Soup N Sandwich");
}
Console.WriteLine();
// Else If Statements

Console.WriteLine("pH is a scale used to specify the acidity or basicity of an aqueous solution.");
Console.WriteLine("Is the solution acidic, basic or neutral");
Console.Write("What level of pH do you have? Enter number between 1 - 7: ");
double ph = Convert.ToDouble(Console.ReadLine());

if (ph < 7) {
  Console.WriteLine("The pH level is Acidic.");
}else if (ph > 7) {
  Console.WriteLine("The pH level is Basic.");
}else {
  Console.WriteLine("The pH level is Neutral.");
}
Console.WriteLine();

// Switch Statement

switch (ph) {
  case < 7:
  Console.WriteLine("Acidic");
  break;

  case > 7:
  Console.WriteLine("Basic");
  break;

  default:
  Console.WriteLine("Neutral");
  break;
}


// Ternary Operators
// The ? determines the outcome
// The : separates the ture / false answers

Console.WriteLine("Your growing peppers and need to only pick them when they are 3.5 inches or longer");
Console.Write("You measure the pepper, how long it it? (1 - 10)");

int pepperLength = Convert.ToInt32(Console.ReadLine());
string result = (pepperLength >= 3.5) ? "pick it now!" : "wait a little longer";

Console.WriteLine($"Your pepper is {pepperLength} inches long, so we should {result}"); 


