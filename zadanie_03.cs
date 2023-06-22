using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace zadanie3
{
    internal class zadanie3
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("Podaj wysokość trójkąta:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                int width = 2 * height - 1;
                int spaces = width / 2;

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < spaces; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < 2 * i + 1; k++)
                    {
                        Console.Write("+");
                    }

                    Console.WriteLine();
                    spaces--;
                }
                Console.ReadKey();
            }
            
        }

      
    }
}
