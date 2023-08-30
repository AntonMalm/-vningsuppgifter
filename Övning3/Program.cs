//Skriv ett program som frågar användaren efter ett tal.
//Det ska skriva ut om talet är mindre än 100, lika med 100 eller större.

using System.Diagnostics;

Console.WriteLine("Skriv ett tal");
int number = int.Parse(Console.ReadLine());
if (number>100)
{
    Console.WriteLine("över 100");
}
else if (number==100)
{
    Console.WriteLine("=100");
}
else
{
    Console.WriteLine("mindre än 100");
}