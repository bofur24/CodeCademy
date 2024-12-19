
// Boolean Data Types

Console.Write("The number 500 is greater than 24? (True or False)");
bool answerOne = Convert.ToBoolean(Console.ReadLine());
if (answerOne == true) {
    Console.WriteLine($"Correct{answerOne}, 500 is greater than 24.");
}else
{
    Console.WriteLine($"{answerOne}, 24 is not greater than 500");
}
Console.WriteLine("");

// Equality Operators

int cookiesSoldGuess = 250;
int storeOneCookies = 110;
int storeTwoCookies = 135;
int cookiesSoldActual = storeOneCookies + storeTwoCookies;
bool guessedCorrect = cookiesSoldGuess == cookiesSoldActual;
Console.WriteLine($"Store one made {storeOneCookies} cookies and store two made {storeTwoCookies} cookies");
Console.WriteLine($"Your cookies sold total guess is {cookiesSoldGuess} but the actual sold is {cookiesSoldActual}");
Console.WriteLine($"Your guess is {guessedCorrect}");
Console.WriteLine("");

// Comparison Operators

// Less than <
// Greater than >
// Less than or equal to <=
// Greater than or equal to >=

Console.WriteLine("You are driving to your family's house for a holiday and want to see if you'll get there before dinner.");
Console.WriteLine("Dinner will be gin at 6:00pm and the house is 95 miles away.");
Console.WriteLine("The average speed to your family house is 30 miles per hour");
Console.Write("What time will you need to leave to get there before 6:00pm (Enter whole numbers 1 - 24): ");
double guessedTimeToDinner = Convert.ToDouble(Console.ReadLine());
double dinnerTime = 18;
double timeToDinner = dinnerTime - guessedTimeToDinner;
double distance = 95;
double rate = 30;
double tripDuration = distance / rate;
bool answer = tripDuration <= timeToDinner;

Console.WriteLine(timeToDinner);

if (answer == true) {
    Console.WriteLine("You will make it on time to dinner;");
}else {
    Console.WriteLine("You will be late to dinner");
};

Console.WriteLine("");

// Logical Operators

// AND &&       True if both are ture              (1 == 1 && 1 == 1) 
// OR ||        True if one or more are ture       (1 == 1 || 1 == 2 )
// NOT !        True if opposite of the expression (!False)

Console.WriteLine("You and your friend are planning a trip together and are trying to decide where to go.");
Console.WriteLine("You each have specific criteria that it needs to fulfill");
Console.WriteLine("Criterias are Beach, Hiking, and City");
bool beach = true;
bool hiking = true;
bool city = true;

bool yourNeeds = beach && city;
bool friendNeeds = beach || hiking;

bool tripDecision = yourNeeds && friendNeeds;

Console.WriteLine($"The trip decision is {tripDecision}");



