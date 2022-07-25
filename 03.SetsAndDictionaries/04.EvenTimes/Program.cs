using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotations = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();
            

            for (int i = 1; i <= rotations; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(currentNum))

                {
                    numbers.Add(currentNum, 1);
                    
                }
                else
                {
                    numbers[currentNum]++;
                }
                



            }

            int magicNum = 0;
            foreach (var item in numbers)
            {
                if (item.Value % 2 == 0)
                {
                    magicNum = item.Key;
                }
            }

            Console.WriteLine(magicNum);
        } 
    }
}
