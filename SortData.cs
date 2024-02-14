using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents
{
    public class SortData
    {
        public static int Sort<T>(T[] items, Comparison<T> comparer)
        {
            int len = items.Length;

            for (int i = 0; i <= len - 2; i++)
            {
                for (int j = 0; j <= (len - 2); j++)
                {
                    if (comparer(items[j], items[j + 1]) > 0)
                    {
                        T temp = items[j + 1];
                        items[j+1] = items[j];
                        items[j] = temp;
                    }
                }
            }
            return 1;
        }

    }
}
