// Declare variables
string name = string.Empty;
int age = 0;
int retirementAge = 65;

// Prompt the user for input
Console.WriteLine("Please enter your name");
name = Console.ReadLine();

Console.WriteLine("Please enter your age");
age = Convert.ToInt32(Console.ReadLine());

// Proces the data
int workingYearsLeft = retirementAge - age;

// Output the result to the user
Console.WriteLine($"Your name is: {name}");
Console.WriteLine($"Your age is: {age}");
Console.WriteLine($"Your working years remaining: {workingYearsLeft}");