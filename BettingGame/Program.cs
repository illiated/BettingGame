﻿using Practise;
using System;
using System.Threading.Channels;

Random random = new Random();

double odds = 0.75;
Person player = new Person() { Name = "Player", Cash = 100 };

Console.WriteLine($"Welcome to the casino. The odds are {odds}");

while (player.Cash > 0)
{
    while (true)
    {
        Console.Write("Would you like to change the odds, please type 'yes' or 'no': ");
        string oddChange = Console.ReadLine();
        if (oddChange != "yes" && oddChange != "no")
        {
            Console.WriteLine("Please type 'yes' or 'no':");
        }
        if (oddChange == "yes")
        {
            Console.Write("What should the odds be, please type a value between 0.0 - 1.0: ");
            string newOddValue = Console.ReadLine();
            if (double.TryParse(newOddValue, out double valueChange))
            {
                odds = valueChange;
                Console.WriteLine($"The odds are now {odds}.");
                break;
            }
            else { Console.WriteLine("please type in the appopiate value"); }
        }
        else
        {
            if (oddChange == "no")
            {
                Console.WriteLine($"The odds are still {odds}.");
                break;
            }
        }
    }
    Console.WriteLine($"The player has {player.Cash} bucks.");
    Console.Write("How much would you like to bet: ");
    string howMuch = Console.ReadLine();

    if (int.TryParse(howMuch, out int amount))
    {
        if (amount == 0)
        {
            Console.WriteLine("Please bet a valid amount");
        }
        else
        {
            int pot = amount * 2;
            double roll = random.NextDouble();
            if (roll > odds)
            {
                Console.WriteLine($"You win {pot}");
                player.RecieveCash(pot);
            }
            else
            {
                Console.WriteLine("Bad luck you lose!");
                player.GiveCash(amount);
            }
        }

    }
    else
    {
        Console.WriteLine("Please bet a valid amount");
    }
}
Console.WriteLine("The house always wins!");