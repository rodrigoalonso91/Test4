using System;
using System.Collections.Generic;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
           var listNumbers= MakeListRandom(100);
            Console.WriteLine(GetNumberIndex(num:22, fromList: listNumbers));
        }
        private static int GetNumberIndex(int num, List<int> fromList)
        {
                return fromList.IndexOf(num);
        }

        private static List<int> MakeListRandom(int length)
        {
            var outputList = new List<int>();
            for (int i = 0; i < length; i++)
            {
                var randomNum = new Random();
                outputList.Add(randomNum.Next(length));
            }
            outputList.Sort();
            return outputList;
        }

    }
}
