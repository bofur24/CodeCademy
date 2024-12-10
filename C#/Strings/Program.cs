// Building Strings
Console.WriteLine("Building Strings");
// First string variable
string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune must be in want of a wife.";
// Second string variable using escape characters
string firstSpeech ="\"My dear Mr. bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";
// Print variable and newline
Console.WriteLine($"{firstSentence} \n {firstSpeech}");
Console.WriteLine("");

// String Concatenation
Console.WriteLine("String Concatenation");
// Declare the variables
string beginning = "Little Timmy needs";
string middle = "more soup";
string end = "to be full.";

// Concatenate the string and the variables
string story = beginning + " " + middle + " " + end;

// Print the story to the console
Console.WriteLine(story);
Console.WriteLine("");

// String Interpolation
Console.WriteLine("String Interpolation");
story = $"{beginning} {middle} {end}";
Console.WriteLine(story);
Console.WriteLine("");

// Get Info About Strings
Console.WriteLine("Get Info About Strings");
// Create password
string password = "a92301j2add";
// Get password length
int passwordLength = password.Length;
// Check if password uses symbol
int passwordCheck = password.IndexOf("!");

// Print results
Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");
Console.WriteLine("");

// Get Parts of Strings
Console.WriteLine("Get Parts of Strings");
// dna strand
string startStrand = "ATGCGATGAGCTTAC";

// Find location of "tga"
int tga = startStrand.IndexOf("TGA");
Console.WriteLine($"The dna strand {startStrand} has {tga} codon before the TGA.");
int startPoint = 0;
int length = tga + 3;
// define final strand
string dna = startStrand.Substring(startPoint, length);
Console.WriteLine($"The dna strand is {dna}.");
// DNA mutation search
char mutation = dna[3];
char A = Convert.ToChar("A");
char C = Convert.ToChar("C");
if(mutation == C || mutation == A) {
  Console.WriteLine($"We have spoted a mutation in your dna strand {dna} at strand number {dna.IndexOf(dna[3])}.");
} else
{
  Console.WriteLine($"No mutations were found.");
}
Console.WriteLine("");

// Manipulate Strings
Console.WriteLine("Manipulate Strings");
// Script line
string script = "Close on a portrait of the HANDSOME PRINCE -- as the Beast's giant paw slashes it.";

// Get camera directions
int charPosition = script.IndexOf("Close");
int length1 = "Close on".Length;
string cameradirections = script.Substring(charPosition, length1);

// get scene description
charPosition = script.IndexOf("a portrait");
string sceneDescription = script.Substring(charPosition);

// Make camera directions uppercase
cameradirections = cameradirections.ToUpper();
// Make scene description lowercase
sceneDescription = sceneDescription.ToLower();
// Print results
Console.WriteLine($"Camera directions is now all uppercase: {cameradirections}");
Console.WriteLine($"Scene description is now all lowercase: {sceneDescription}");
Console.WriteLine("");

// Review
Console.WriteLine("Review");
Console.WriteLine("How to save char and string values to a variable.");
Console.WriteLine("Use the addition symbol (+) to concatenate strings.");
Console.WriteLine("Interpolate strings for easier string construction.");
Console.WriteLine("Find information about a string using .Length and .IndexOf().");
Console.WriteLine("Grab characters and parts of strings using bracket notation and .Substring().");
Console.WriteLine("Use built-in methods such as .ToUpper() and .ToLower() to manipulate strings.");