using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgortihms
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 11, 5, 7, 88, 4, 0, 12 };
            Sorter.SelectionSort(data);
            Sorter.Print(data);

            Console.ReadLine();
        }
    }
}
