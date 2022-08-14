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
            Random rand = new Random();
            int randomNumber;
            int numberForSum = 0;
            int numberOfRepeat = 10;
            int firstMultiple = 3;
            int secondMultitipe = 5;
            int receivedFirstNumber;
            int receivedSecondNumber;

            for (int i = 0; i < numberOfRepeat; i++)
            {
                randomNumber = rand.Next(1, 100);
                receivedFirstNumber = randomNumber % firstMultiple;
                receivedSecondNumber = randomNumber % secondMultitipe;

                if (receivedFirstNumber == 0 || receivedSecondNumber == 0)
                {
                    numberForSum += randomNumber;
                }
                Console.WriteLine($"Случайное число: {randomNumber}");
                Console.WriteLine($"Сумма чисел кратных 3 или 5: {numberForSum}");
            }
            Console.ReadKey();
        }
    }
}
