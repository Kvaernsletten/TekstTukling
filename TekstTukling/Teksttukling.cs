using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kvaernsletten
{
    internal class Teksttukling
    {

        public void Run()
        {
            WelcomeScreen();
        }

        public void WelcomeScreen()
        {
            Console.WriteLine("Welcome, please input a menu number and press ENTER to continue... ");
            Console.WriteLine();
            Console.WriteLine("1. Mirror text");
            Console.WriteLine("2. Change word");
            var input = Console.ReadLine();

            if (input == "1")
            {
                MirrorText();
            }
            else if (input == "2")
            {
                ChangeText();
            }
        }

        public void MirrorText()
        {
            Console.Clear();
            Console.WriteLine("Please type in your word that you want mirrored and press ENTER to continue...");
            string outputString = "";
            var inputString = Console.ReadLine();

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                outputString += inputString[i];
            }

            Console.WriteLine(outputString);
        }
        public void ChangeText()
        {
            Console.Clear();
            Console.WriteLine("Please type in your word that you want changed and press ENTER to continue...(Switches every 'E' with 'A' and opposite)");
            var inputString = Console.ReadLine();

            foreach (var letter in inputString)
            {
                if(letter == 'a')
                {
                    Console.Write('e');
                }
                else if(letter == 'A')
                {
                    Console.Write('E');
                }
                else if (letter == 'e')
                {
                    Console.Write('a');
                }
                else if (letter == 'E')
                {
                    Console.Write('A');
                }
                else
                {
                    Console.Write(letter);
                }
            }
        }

    }
}
