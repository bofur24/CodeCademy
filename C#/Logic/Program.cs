
// Boolean Data Types

Console.Write("The number 500 is greater than 24? (True or False)");
bool answerOne = Convert.ToBoolean(Console.ReadLine());
if (answerOne == true) {
    Console.WriteLine($"Correct{answerOne}, 500 is greater than 24.");
}else
{
    Console.WriteLine($"{answerOne}, 24 is not greater than 500");
}

