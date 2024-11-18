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
Console.WriteLine();

// Arithmetic Operators
Console.WriteLine("Arithmetic Operators");
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
Console.WriteLine();

// Operator Shortcuts
Console.WriteLine("Operator Shortcuts");
// Declare steps variable
int steps = 0;

// Two steps forward
steps+= 2;

// One step back
steps--;

// Print result to the console
Console.WriteLine($"The new number for steps is: {steps}");
Console.WriteLine();

//Modulo
Console.WriteLine("MODULO");
Console.WriteLine($"There are 18 students how many groups can you make that are an even number (3 - 5).");
// Number of students
int students = 18;

// Number of students in a group
int groupSize = Convert.ToInt32(Console.ReadLine());
      if (students % groupSize == 0) {
        Console.WriteLine($"Correct we can make {groupSize} groups of 6");
      }else if (students % groupSize >= 2 && students % groupSize < 3 ) {
        Console.WriteLine($"Wrong we can't make {groupSize} groups there are {students % groupSize} students left.");
      } else {
        Console.WriteLine($"Wrong we can't make {groupSize} groups there are {students % groupSize} students left.");
      };


// Does groupSize go evenly into students?

