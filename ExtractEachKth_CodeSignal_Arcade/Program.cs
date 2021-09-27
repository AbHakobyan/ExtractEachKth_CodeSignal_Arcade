using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractEachKth_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 1, 1};
            int k = 1;
            int[] array = extractEachKth(inputArray, k);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static int[] extractEachKth(int[] inputArray, int k)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if ((i + 1) % k != 0)
                    list.Add(inputArray[i]);
            }
            return list.ToArray();
        }

    }
}
