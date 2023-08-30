//int age = 19;
//string name = "Anton";
////ctrl+k+c, ctrl+k+u, ctrl+k+d
//if (name == "Anton")
//{
//    Console.WriteLine("Gammal du är Anton!");
//}
//else if (age > 18)
//{
//    Console.WriteLine("Oof!");
//}
//else
//{
//    Console.WriteLine("Vem är du?"); Console.WriteLine("Vem är du?");
//}

//int counter = 0;

//while (name == "Anton")
//{ 
//    if (counter > 10)
//    {
//        break;
//    }
//    Console.WriteLine("LOL");
//    counter++;
//}
//Console.WriteLine("_____________________________________________________");
//for (int i = 0; i < 10; i++)
//{
//    if (name != "Anton")
//    {
//        break;
//    }
//    Console.WriteLine("LOL");
//}

int[] goodNumbers;
goodNumbers = new int[10];

for (int i = goodNumbers.Length-1; i >= 0; i--)
{
    goodNumbers[i] = 10-i;
}

foreach (int number in goodNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("_____________________________________________");

Array.Sort(goodNumbers);

foreach (int number in goodNumbers)
{
    Console.WriteLine(number);
}

//int index = 0;

//while (index < goodNumbers.Length)
//{
//    index++;

//}

//string name = "Anton";
//Console.WriteLine(name.Length);

//Console.WriteLine(name[2]);

//for (int i = 0; i < name.Length; i++)
//{
//    Console.WriteLine(name[i]);
//}
