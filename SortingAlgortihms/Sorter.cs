using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgortihms
{
    public class Sorter
    {
        private static void exchange(int[] data, int pos1, int pos2)
        {
            int temporary;

            temporary = data[pos1];
            data[pos1] = data[pos2];
            data[pos2] = temporary;
        }

        public static int MinPosOfArray(int[] data, int startPos)
        {
            var minPos = startPos;

            for (int i = startPos + 1; i < data.Length; i++)
                if (data[i] < data[minPos])
                    minPos = i;
            return minPos;

        }

        public static void SelectionSort(int[] data)
        {
            for (int i = 0; i < data.Length-1; i++)
            {
                int minPos = MinPosOfArray(data, i);
                if (i != minPos)
                    exchange(data, i, minPos);
            }
        }

        public static void BubbleSort(int[] data)
        {
           for (int i = 0; i < data.Length-1; i++)
            {
                for (int j = 0; j < data.Length-1; j++)
                {
                    if (data[j] > data[j+1])
                        exchange(data, j, j + 1);
                }
            }
        }
        
        public static void Print(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
                Console.Write("{0} ", data[i]);
        }


    }
}
