// See https://aka.ms/new-console-template for more information

// Number of pizza shops
int pizzaShops = 4332;

// Number of employees
int totalEmployees = 86928;

// Revenue
decimal revenue = 390819.28m;

// Log the values to the console:
Console.WriteLine($"Total pizza shops: {pizzaShops}.");
Console.WriteLine($"Total Employees: {totalEmployees}.");
Console.WriteLine($"Total revenue: {revenue}.");


// Arithmetic Operators
Console.WriteLine("This will tell your age if you were to travele to Jupiter.");
Console.WriteLine("What is your age?");
int userAge = Convert.ToInt32(Console.ReadLine());

// One years on Jupiter (in Earth years)
double jupiterYears = 11.86;

// Age on Jupiter
double jupiterAge = userAge / jupiterYears;

// Time to Jupiter
double journeyToJupiter = 6.142466;

// New age on Earth
double newEarthAge = journeyToJupiter + userAge;

// New Age on Jupiter

double newJupiterAge = newEarthAge / jupiterYears;


// Your Age
Console.WriteLine($"Current Age: {userAge}.");
Console.WriteLine($"Time to reach Jupiter: {journeyToJupiter}.");
Console.WriteLine($"One Jupiter year is: {jupiterYears}.");
Console.WriteLine($"Age when you arrive on Jupiter: {newEarthAge}.");
Console.WriteLine($"Your age if you were born on Jupiter: {jupiterAge}.");
Console.WriteLine($"Your new age on jupiter is: {newJupiterAge}.");