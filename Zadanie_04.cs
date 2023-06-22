using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace zad4
{
    internal class zadanie4
    {
        class Program
        {
            static void Main()
            {
                int attempts = 0;
                int size = 0;

                while (attempts < 3)
                {
                    Console.WriteLine("Podaj nieparzystą liczbę wierszy rombu (minimum 3):");
                     size = Convert.ToInt32(Console.ReadLine());
                    if (size >= 3 && size % 2 != 0)
                        break;

                    attempts++;
                }

                if (attempts >= 3)
                {
                    Console.WriteLine("Podano nieprawidłową wartość zbyt wiele razy. Program zostanie zakończony.");
                    Console.ReadKey();
                    return;
                }

                char borderChar = GetRandomChar(new[] { '#', '@', '|', '*' });
                char fillChar = GetRandomChar(new[] { '.', ':', '-', '+' });

                int spaces = size / 2;
                int chars = 1;

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < spaces; j++)
                        Console.Write(" ");

                    for (int k = 0; k < chars; k++)
                    {
                        if (k == 0 || k == chars - 1 || i == 0 || i == size - 1)
                            Console.Write(borderChar);
                        else
                            Console.Write(fillChar);
                    }

                    Console.WriteLine();

                    if (i < size / 2)
                    {
                        spaces--;
                        chars += 2;
                    }
                    else
                    {
                        spaces++;
                        chars -= 2;
                    }
                }
            }

            static char GetRandomChar(char[] chars)
            {
                Random random = new Random();
                int index = random.Next(chars.Length);
                return chars[index];
            }


        }
    }
}
