
Console.WriteLine("Welcome to Money Maker!");
Console.WriteLine("This program will get the minimum number of coins per your requested amount.");
Console.WriteLine("(Gold is 10, Silver is 5, Bronze is 1)");
Console.Write("Enter your amount: ");
double amount = Convert.ToDouble(Console.ReadLine());
amount = Math.Floor(amount);
Console.WriteLine($"{amount} cents is equal to...");
int goldValue = 10;
int silverValue = 5;
double goldCoins = Math.Floor(amount / goldValue);
double remainder = amount % goldValue;
double silverCoins = Math.Floor(remainder / silverValue);
remainder = amount % silverValue;
Console.WriteLine($"Number of Gold Coins is: {goldCoins}");
Console.WriteLine($"Number of Silver Coins is: {silverCoins}");
Console.WriteLine($"Number of Bronze Coins is: {remainder}");