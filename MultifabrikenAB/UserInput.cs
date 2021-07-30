using System;
using System.Collections.Generic;
using System.Text;

namespace MultifabrikenAB
{
    class UserInput
    {
        public static int MainMenu()
        {
            int input = 0;
            bool loop = true;
            do
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                    if (input >= 0 && input < 3)
                    {
                        loop = false;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input1");
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect input2");
                }

            } while (loop);
            return input;
        }

        public static int SubMenu()
        {
            int input = 0;
            bool loop = true;
            do
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                    if (input >= 0 && input <= 4)
                    {
                        loop = false;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input1");
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect input2");
                }

            } while (loop);
            return input;
        }
    }
}
