using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japnesegame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shiritori my_shiritori = new Shiritori();
            int option = 0;

            while (option != 3)
            {
                Console.WriteLine("\n");
                Console.WriteLine("===========Welcome to My Shiritori===========");
                Console.WriteLine("| 1. Play game                               |");
                Console.WriteLine("| 2. Restart your game                       |");
                Console.WriteLine("| 3. Exit game                               |");
                Console.WriteLine("============================================");

                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Write("Enter your word ===> ");
                    string word = Console.ReadLine();
                    Console.WriteLine("Playing '" + word );
                    my_shiritori.Play(word);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Restarting....... " + my_shiritori.Restart());
                }
                else if (option == 3)
                {
                    Console.WriteLine("Program is closing...");
                }
                else
                {
                    Console.WriteLine("Invalid.....Type b/w 1-3......");
                }
            }
        }
        Console.Read();
    }
}
