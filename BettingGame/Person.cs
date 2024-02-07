using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class Person
    {
        public string Name;
        public int Cash;
        /// <summary>
        /// Writes my name ands the amount of cash I have in the console.
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine($"{Name} has {Cash} bucks.");
        }
        /// <summary>
        /// Gives some of my cash, removing it from my wallet (or printing a message to the console if I dont have enough cash).
        /// </summary>
        /// <param name="amount">Amount of cash to give.</param>
        /// <returns>Amount of cast to remove from my wallet, or '0' if I dont have enough or the amount is invalid.</returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Name} says {amount} is not a valid amount.");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine($"{Name} says: 'I dont have enough cash to give you {amount}'");
                return 0; 
            }
            Cash -= amount;
            return amount;
        }
        /// <summary>
        /// Recieve some cash, adding it to my wallet (or printing a message to the console if the amount is invalid).
        /// </summary>
        /// <param name="amount">The amount of cash to give.</param>
        public void RecieveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Name} says {amount} isnt an amount I can take.");
            }
            else
                Cash += amount;
        }
    }
}
