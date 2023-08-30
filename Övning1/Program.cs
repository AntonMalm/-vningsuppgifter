
//Skriv ett program som frågar efter användarens namn och
//skriver ut en hälsning på konsolen. Om namnet är "David"
//ska det skriva ut "Hej David!"

using System;

Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();
Console.WriteLine("Skriv ett tal");
int tal = int.Parse(Console.ReadLine());

for (int i = 0; i < tal; i++)
{
    
   
        Console.WriteLine("Hej" + name);
    

}

