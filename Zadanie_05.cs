using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace zad5
{
    internal class zadanie5
    {
        class Program
        {
            static void Main()
            {
                int x = GetInput("Podaj liczbę  x: ");
                int n = GetInput("Podaj liczbę n: ");
                int result = Power(x, n);

                int expected = (int)Math.Pow(x, n);

                Console.WriteLine($"Wynik otrzymany: {result}");
                Console.WriteLine($"Wynik prawidłowy: {expected}");

                if (result == expected)
                    Console.WriteLine("Wyniki są zgodne.");
                else
                    Console.WriteLine("Wyniki nie są zgodne.");
            }

            static int GetInput(string message)
            {
                int input;
                bool isValid = false;

                do
                {
                    Console.Write(message);
                    isValid = int.TryParse(Console.ReadLine(), out input);

                    if (!isValid || input < 0)
                    {
                        Console.WriteLine("Nieprawidłowa wartość. Podaj liczbę całkowitą nieujemną.");
                        isValid = false;
                    }
                } while (!isValid);

                return input;
            }

            static int Power(int x, int n)
            {
                if (n == 0)
                    return 1;

                int result = x;
                int prevResult = x;
                int sum = x;

                for (int i = 1; i < n; i++)
                {
                    for (int j = 1; j < x; j++)
                    {
                        sum += prevResult;
                        result += prevResult;
                    }

                    prevResult = sum;
                }

                return result;
            }
        }
    }
}
