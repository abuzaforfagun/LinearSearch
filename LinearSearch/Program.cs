using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 2, 34, 19, 38, 1, 28, 20 };
            Console.WriteLine(LinearSearch.DoLinearSearch(numbers, 19));
            Console.Read();
        }
    }
}
