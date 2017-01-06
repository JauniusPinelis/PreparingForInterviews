using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgortihms
{
    public class Sorter
    {
        public static void Exchange(ref int[] data, int pos1, int pos2)
        {
            int temporary;

            temporary = data[pos1];
            data[pos1] = data[pos2];
            data[pos2] = temporary;
        }

        public static void BubbleSort(ref int[] data)
        {
           for (int i = 0; i < data.Length-1; i++)
            {
                for (int j = 0; j < data.Length-1; j++)
                {
                    if (data[j] > data[j+1])
                        Exchange(ref data, j, j + 1);
                }
            }
        }
        
        public static void Print(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
                Console.WriteLine(data[i]);
        }  


    }
}
