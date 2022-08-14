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
            int multiple = 3;
            int receivedNumber;

            for (int i = 0; i < numberOfRepeat; i++)
            {
                randomNumber = rand.Next(1, 100);
                receivedNumber = randomNumber % multiple;

                if (receivedNumber  == 0)
                {
                    numberForSum += randomNumber;
                }
                Console.WriteLine($"Случайное число: {randomNumber}");
            }
            Console.WriteLine(numberForSum);
            Console.ReadKey();
        }
    }
}
