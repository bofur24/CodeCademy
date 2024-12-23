// IF Statements

int socks = 3;
socks += 2;
if (socks <= 3) {
  Console.WriteLine("Time to do laundry!");
} 
  Console.WriteLine("If false, Time to do laundry! will be skipped.");


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

