using System;

namespace ReturningAndPassingData
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            result = numbersAdded(2, 3);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static int numbersAdded(int x, int y)
        {
            int z = x + y;

            return z;
        }
    }
}
