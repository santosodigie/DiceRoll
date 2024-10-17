// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, Welcome to my simple dice game!");
Random rnd = new Random();
bool exit = false;

while (!exit)
{
    Console.WriteLine("Press any button to roll the dice");
    Console.ReadKey();

    int user = rnd.Next(1, 7);
    int cpu = rnd.Next(1, 7);
    Console.WriteLine($"\nYou rolled {user}");
    Console.WriteLine($"\nThe cpu rolled {cpu}");
    Console.WriteLine("_________________________________");
}
