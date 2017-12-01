using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class LinearSearch
    {
        public static int DoLinearSearch(int[] numbers, int number)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                    return i;
            }
            return -1;
        }
    }
}
