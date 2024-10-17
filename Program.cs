// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, Welcome to my simple dice game!");
Random rnd = new Random();
bool exit = false;
int win = 0;
int loss = 0;
int draw = 0;

while (!exit)
{
    Console.WriteLine($"You have {win} wins, {loss} losses and {draw} draws.");
    Console.WriteLine("Press any button to roll the dice");
    Console.ReadKey();

    int user = rnd.Next(1, 7);
    int cpu = rnd.Next(1, 7);
    Console.WriteLine($"\nYou rolled {user}");
    Console.WriteLine($"\nThe cpu rolled {cpu}");
    if (user > cpu)
    {
        Console.WriteLine("Congrats you win");
        win++;
    }
    else if (cpu > user)
    {
        Console.WriteLine("Sorry you lost");
        loss++;
    }
    else
    {
        Console.WriteLine("You drew");
        draw++;
    }
    Console.WriteLine("_________________________________");
}
