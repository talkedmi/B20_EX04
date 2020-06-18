using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
     public class CountCapitals : IMenuItemSelectedListener
    {
        public void DoWhenSelected()
        {
            capitalsCounter();
        }

        internal void capitalsCounter()
        {
            uint numberOfCapitals = 0;
            Console.WriteLine("Please enter a sentence");
            string userInput = Console.ReadLine();

            foreach(char userInputChar in userInput)
            {
                if(char.IsUpper(userInputChar))
                {
                    numberOfCapitals++;
                }
            }

            Console.WriteLine("This sentece has {0} capital letters.", numberOfCapitals);
        }
    }
}
