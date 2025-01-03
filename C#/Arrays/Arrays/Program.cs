
// Building Arrays


// playlist
string[] summerStrut;
// song in playlist
summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles"};
// song ratings
int[] ratings = { 1, 2, 3, 4, 5, 1, 2, 3,};

// Array Length

if (summerStrut.Length == 8) {
  Console.WriteLine("SummerStrut Playlist is ready to go!");
} else if (summerStrut.Length > 8) {
  Console.WriteLine("SummerStrut Playlist has to many songs!");
} else {
  Console.WriteLine("SummerStrut Playlist needs more songs!");
}

// Accessing Array Items

Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars.");

// Editing Arrays

summerStrut[7] = "Rock Me All Night";
Console.WriteLine($"New song added to SummerStrut Playlist is {summerStrut[7]}.");

ratings[7] = 3;
Console.WriteLine($"New rating for new song {summerStrut[7]} is {ratings[7]}.");

// Built-In Methods
// Array.Sort() sorts an Array
// Array.IndexOf() takes a value and returns the index within the Array
// Array.Reverse() returns the array with the original elements in reverse order

int threeStar = Array.IndexOf(ratings, 3);
Console.WriteLine($"Song number {threeStar + 1} is rated three stars");

Array.Reverse(summerStrut);

Console.WriteLine($"Songs are in reverse order, first title is {summerStrut[0]}, and the last title is {summerStrut[7]}.");

Array.Sort(summerStrut);

Console.WriteLine($"Songs are sorted alphabetically, first title is {summerStrut[0]}, and the last title is {summerStrut[7]}.");




