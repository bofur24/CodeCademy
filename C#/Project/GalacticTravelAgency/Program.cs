// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");
string passengerName = Console.ReadLine();
Console.WriteLine("What is your age?");
int passengerAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What type of ticket do you have?");
string ticketType = Console.ReadLine();
Console.WriteLine("What planet are you from?");
string preferredPlanet = Console.ReadLine();

// Print out passenger data
Console.WriteLine("Passenger data");
Console.WriteLine($"Name: {passengerName}");
Console.WriteLine($"Age: {passengerAge}");
Console.WriteLine($"Ticket Type: {ticketType}");
Console.WriteLine($"Planet: {preferredPlanet}");
