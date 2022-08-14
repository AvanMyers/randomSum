using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber;
            int numberForSum = 0;
            int firstMultiple = 3;
            int secondMultitipe = 5;

            randomNumber = random.Next(0, 100);
            Console.WriteLine($"Число повторений: {randomNumber}");

            for (int i = 0; i < randomNumber; i++)
            {
                if (i % firstMultiple == 0 || i % secondMultitipe == 0)
                {
                    numberForSum += i;
                }
               
                Console.WriteLine($"{i}.Сумма чисел кратных {firstMultiple} или {secondMultitipe}: {numberForSum}");
            }
            Console.ReadKey();
        }
    }
}
