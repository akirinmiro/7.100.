using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int n = 10;
            short[] numbers = new short[n];
            short summ = 0;
            Random random = new Random();
            for (byte i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt16(random.Next(5, 15));
                Console.WriteLine("El:" + numbers[i]);
                summ += numbers[i];
            }
                {
                    int m = 100;
                    if (summ > m) Console.WriteLine("{0} - Больше 100", summ);
                    else Console.WriteLine("{0} - Меньше 100", summ);
                    {
                        int p = 2;
                        if(summ % p == 0)System.Console.WriteLine("{0} - кратно 2.", summ);
                        else Console.WriteLine("{0} -не кратно 2.", summ);
                    }



                }
                
            }
        }
    }


