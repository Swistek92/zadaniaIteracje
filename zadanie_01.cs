using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace zadanie1
{
    internal class zadanie1
    {
      

        static void Main()
        {
            Console.WriteLine("Podaj liczbę liczb pierwszych do wygenerowania:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();    
            int count = 0;
            int number = 2;
            Console.WriteLine(n + " liczb pierwszych: ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            while (count < n)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number);
                    count++;
                }

                number++;
            }
            Console.ReadKey();
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
