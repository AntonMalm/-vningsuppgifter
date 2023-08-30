// Skriv ett program som frågar användaren efter ett lösenord.
// Hitta på ett hemligt lösenord och spara det i en variabel.
// När användaren har skrivit in ett lösenord ska programmet
// jämföra med det sparade lösenordet och skriva ut om det var
// rätt eller inte. Använd en if-sats.
string password = "1234";

Console.WriteLine("Ange lösenordet");
string UserPassword = Console.ReadLine();

if  (UserPassword == password)
{
    Console.WriteLine("Rätt!");
}
else
{
    Console.WriteLine("Fel!");
}