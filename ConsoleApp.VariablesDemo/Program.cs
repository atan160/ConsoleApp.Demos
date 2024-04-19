// See https://aka.ms/new-console-template for more information

// Different datatypes
/*
    text - string 
    integers - int 
    decimal - double, float, decimal
    logical - bool
*/

string myName = "Natalija"; // Varijabla je dinamicka vrednost
Console.WriteLine("My name is Natalija"); // Ovo je staticna vrednost


Console.WriteLine("My name is " + myName); // String concatenation
Console.WriteLine($"My name is {myName}"); // String interpolation
Console.WriteLine("My name is {0}", myName); // Formatted string

int myAge  = 34;
int x = 0;
int y = 3;

Console.WriteLine("I am " + myAge + " years old. ");

bool isRetiered = true;
