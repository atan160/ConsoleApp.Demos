// Declare variables
string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;

// Prompt the user for input
Console.WriteLine("Please enter your first name");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your age");
age = Convert.ToInt32(Console.ReadLine());

// Proces the data
int workingYearsLeft = retirementAge - age;

// Output the result to the user
Console.WriteLine($"Your full name is: {firstName} {lastName}");
Console.WriteLine($"Your age is: {age}");
Console.WriteLine($"Your working years remaining: {workingYearsLeft}");