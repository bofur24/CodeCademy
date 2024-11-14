internal class Program
{
    private static void Main(string[] args)
    {
        /* Multi-line comment 
         * this code will print out items
         * one by one on its own line.
         */
        Console.WriteLine("Hello, World!");
        Console.WriteLine("I am Learning C#");
        Console.WriteLine("It is awesome!");
        // Single line comment 3 + 3 = 6
        Console.WriteLine(3 + 3);
        Console.Write("Hello "); // End of line comment next line will be as one.
        Console.Write("I will print on the same line.");

        /* Variables are declared as follows
         * type variableName = value;
         * string name = "John";
         */
        string name = "John";
        Console.WriteLine(name);

        // Variable to store a number
        int myNum = 15;
        Console.WriteLine(myNum);

        // Variable assigned later
        int myNumb;
        myNumb = 15;
        Console.WriteLine(myNumb);

        // Variable assigned a new value
        myNumb = 20; //myNumb was 15 now is 20
        Console.WriteLine(myNumb);

        // Variables of different types
        double myDoubleNum = 5.99D;
        char myLetter = 'D';
        bool myBool = true;
        string myText = "Hello";

        Console.WriteLine(myDoubleNum);
        Console.WriteLine(myLetter);
        Console.WriteLine(myBool);
        Console.WriteLine(myText);

        // Constants variables can't be changed
        const int myNumbs = 10;
        // myNumbs = 5; error


        // Display Variables & combine variables
        Console.WriteLine(name);
        string lastName = " Doe";
        string fullName = name + lastName;
        Console.WriteLine(fullName);

        // Numeric vales the + works as a mathematical operator

        int x = 5;
        int y = 6;
        Console.WriteLine(x + y); // Print the value of x + y 

        // Declare Many Variables

        int i = 7, j = 8, k = 9;
        Console.WriteLine(i + j + k);

        // same value multiple variables
        int a, b, c;
        a = b = c = 3;
        Console.WriteLine(a + b + c);

        // C# Identifiers
        /*  unique names
         *  short names ( x and y) 
         *  descriptive names (age, sum, totalVolume) 
         */

        // Good
        int minutesPerHour = 60;

        // OK, but not so easy to understand what m actually is
        int m = 60;

        /*Data Types
         * int      4 bytes                 stores numbers -2,147,483,648 to 2,147,483,647
         * long     8 bytes                 stores numbers -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807     
         * float    4 bytes                 stores fractional numbers 6 to 7 decimal digits
         * double   8 bytes                 stores fractional numbers 15 decimal digits
         * bool     1 bit                   stores true or false values
         * char     2 bytes                 stores single character/letter, surrounded by single quotes
         * string   2 bytes per character   stores a sequence of characters, surrounded by double quotes
         */

        // Interger Types

        int myNumbers = 100000;
        Console.WriteLine(myNumbers);

        // long should end the value with an "L"
        long myLongNumber = 15000000000L;
        Console.WriteLine(myLongNumber);

        // Floating Point Types

        // Float and Double should end the value with an "F"(float) and "D"(double)

        float myFloatNum = 5.75F;
        Console.WriteLine(myFloatNum);

        double myDoubleNumber = 19.99D;
        Console.WriteLine(myDoubleNumber);

        // Scientific Numbers

        // Scientific number with an "e" to indicated the power of 10

        float f1 = 35e3F;
        double d1 = 12E4D;
        Console.WriteLine(f1);
        Console.WriteLine(d1);

        // Booleans
        // true or false

        bool isCSharpFun = true;
        bool isFishTasty = false;
        Console.WriteLine(isCSharpFun); // Outputs True
        Console.WriteLine(isFishTasty); // Outputs False

        // Characters

        // char store a single character

        char myGrade = 'B';
        Console.WriteLine(myGrade);

        // String

        string greeting = "Hello World";
        Console.WriteLine(greeting);

        // Type Casting

        // Implicit Casting
        // automatically passes a smaller size type to a larger size type

        int myInt = 9;
        double myDouble = myInt;        // Automatic casting: int to double

        // Explicit Casting
        // Explicit must be done manually by placing the type in parentheses in front of the value

        double myDoubles = 9.78;
        int myInts = (int) myDoubles;

        // Type Conversion Methods

        // Built-in Methods

        Console.WriteLine(Convert.ToString(myInt));
        Console.WriteLine(Convert.ToDouble(myInt));
        Console.WriteLine(Convert.ToInt32(myDouble));
        Console.WriteLine(Convert.ToString(myBool));


        // Get User Input

        // Type your username and press enter
        Console.WriteLine("Enter username:");

        // Create a string variable and get user input from the keyboard and store it in the variable

        string userName = Console.ReadLine();

        // Print the value of the variable (userName), wich will display the input value

        Console.WriteLine("Username is: " + userName);

        // User input and numbers

        // Must Type Cast since ReadLine() return a string

        Console.WriteLine("Enter your Age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is " + age);

        // Operators

        int h = 100 + 50;

        Console.WriteLine(h);

        int sum1 = 100 + 50;
        int sum2 = sum1 + 250;
        int sum3 = sum2 + sum2;

        int g = 10;
        g += 5;

        Console.WriteLine(k > i);

        // Math

        // Math.Max(x,y) find highest value of x and y

        Math.Max(10, 12);

        // Math.Min(x,y) find lowest value of x and y

        Math.Min(10, 12);

        // Math.Sqrt(x) returns the square root of x

        Math.Sqrt(64);

        // Math.Abs(x) returns the absolute (positive) value of x

        Math.Abs(-4.7);


        // Math.Round() rounds a number to the nearest whole number

        Math.Round(9.99);

        // Strings

        string greetings = "Hello"; // Single word string
        Console.WriteLine(greetings);
        
        string greeting2 = "Nice to meet you!"; // Many words.
        Console.WriteLine(greeting2);

        // String Length

        string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Console.WriteLine("The length of the txt string is: " + txt.Length);

        // Other Methods

        string txts = "Hello World";
        Console.WriteLine(txts.ToUpper());
        Console.WriteLine(txts.ToLower());

        // String Concatenation

        string firstName1 = "John ";
        string lastName1 = "Doe";
        string name1 = firstName1 + lastName1;
        Console.WriteLine(name1);


        // string.Concat();

        name = string.Concat(firstName1, lastName1);
        Console.WriteLine(name1);

        // WARNING! C# uses the + operator for both additiong and concatenation

        int z = x + y; // z will be 11 (an integer/number
        Console.WriteLine(z);

        // numbers as strings will be strings not numbers

        string numberString = "10";
        string stringNumber = "20";
        Console.WriteLine(numberString + stringNumber); // Result will be 1020 (a string)


        // String Interpolation
        // Have to use the $ when using interpolation method.

        Console.WriteLine($"My full name is: {firstName1} {lastName1}");

        // Access Strings
        // String indexes start with 0: [0] is the first character. [1] is the second character, etc.

        string myString = "Hello";
        Console.WriteLine(myString[0]); // Outputs "H"
        Console.WriteLine(myString[1]); // Outputs "e"

        // IndexOf(); the index position of a specific character in a sting

        Console.WriteLine(myString.IndexOf("e")); // Outputs "1"

        // Substring(); extracts the characters from a string, starting from the specified character position/index, and returns a new string.
        // Often used together with IndexOf() to get the specific character position:

        int charPos = lastName1.IndexOf("D");
        string newName = lastName1.Substring(charPos);
        Console.WriteLine(newName);


        // String - Special Characters
        /*
         *  Escape characters
         *  \' Single quote
         *  \" Double quote
         *  \\ Backslash
         *  \n New line
         *  \t Tab
         *  \b Backspace
         * 
         */


        string txtss = "It\'s alright, for the \"Vikings\" to call \\ this out.";
        Console.WriteLine(txtss);

        // Boolean Values


        Console.WriteLine(isCSharpFun); // Outputs True
        Console.WriteLine(isFishTasty); // Outputs False

        // Boolean Expression

        int boolX = 10;
        int booly = 9;

        Console.WriteLine(boolX > booly); // returns True, because 10 is higher than 9

        Console.WriteLine(10 > 9); // returns True, becasuse 10 is higher than 9

        // equal to (==)
        
        int boolz = 10;
        Console.WriteLine(boolz == 10); // returns True, because the value of boolz is equal to 10

        Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15

        // Real Life Example
        // Example use >= comparison operator to find out if the age (25) is greater than OR equal to the voting age limit, which is set to 18

        int myAge = 25;
        int votingAge = 18;
        Console.WriteLine(myAge >= votingAge);

        // A better approach would be to wrap the code above in an if ... else statement, so we can perform different actions depending on the result.

        if (myAge >= votingAge)
        {
            Console.WriteLine("Old enough to vote!");
        }
        else
        {
            Console.WriteLine("Not old enough to vote.");
        }

        // The If Statement

        if (20 > 18)
        {
            Console.WriteLine("20 is greater than 18");
        }

        // Testing Variables

        if (x > y)
        {
            Console.WriteLine("x is greater than y");

        }


        // The else Statement

        int time = 22;
        if (time < 18)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }

        // Outputs "Good evening."



        // The else if Statement

        if (time < 10)
        {
            Console.WriteLine("Good morning.");
        }
        else if (time < 20)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }

        // Outputs "Good evening."


        // Short Hand if...Else

        string result = (time > 18) ? "Good day." : "Good evening.";
        Console.WriteLine(result);

        // Switch Statements

        int day = 4;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
        }

        // Outputs "Thursday" (day 4)

        switch (day)
        {
            case 6:
                Console.WriteLine("Today is Saturday.");
                break;
            case 7:
                Console.WriteLine("Today is Sunday");
                break;
            default:
                Console.WriteLine("Looking forward to the Weekend.");
                break;
        }

        // Outputs "Looking forward to the Weekend

        // While Loop, loops through a block of code as long as a specified condition is True

        int loopI = 0;
        while (loopI < 5)
        {
            Console.WriteLine(loopI);
            loopI++;
        }
        // Printe out 0 1 2 3 4, be sure to increase the variable used in the condition, otherwise the lop will never end!

        //The do/while loop

        /* is a variant of the while loop. This loop will execute the code block once,
         * before checking if the condition is true, then
        * it will repeat the loop as long as the condition is ture.        *
        */

        do
        {
            Console.WriteLine(loopI);
            loopI++;
        } while (loopI < 5);

        // For Loop
        // When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop.

        for (int loopH = 0; loopH < 5; loopH++)
        {
            Console.WriteLine(loopH);
        }

        // Another Example This will only print even values between 0 and 10

        for (int loopJ = 0; loopJ < 10; loopJ= loopJ + 2)
        {
            Console.WriteLine(loopJ);
        }

        // Nested Loops

        // The "inner loop" will be executed one time for each iteration of the "outer loop";

        for (int loopK = 1; loopK <= 2; loopK++)
        {
            Console.WriteLine("Outer: " + loopK); // Executes 2 times

            // Inner Loop

            for (int loopL = 1; loopL <= 3; loopL++)
            {
                Console.WriteLine(" Inner: " + loopL); // Executes 6 times (2 * 3)
            }
        }

        








    }
}