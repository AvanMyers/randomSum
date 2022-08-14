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
            int receivedFirstNumber;
            int receivedSecondNumber;

            randomNumber = random.Next(0, 100);
            Console.WriteLine($"Число повторений: {randomNumber}");

            for (int i = 0; i < randomNumber; i++)
            {
                receivedFirstNumber = i % firstMultiple;
                receivedSecondNumber = i % secondMultitipe;

                if (receivedFirstNumber == 0 || receivedSecondNumber == 0)
                {
                    numberForSum += i;
                }
               
                Console.WriteLine($"{i}.Сумма чисел кратных 3 или 5: {numberForSum}");
            }
            Console.ReadKey();
        }
    }
}
