using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2 {
    internal class Program {
        static void Main(string[] args) {
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            //ints.Add(5);

            MiddleOfTheList(ints);
            LargestIntegerInTheList(ints);

            Console.ReadKey();
        }

        static void MiddleOfTheList(List<int> list) {
            int sizeOfList = list.Count;
            if (sizeOfList != 0) {
                if (sizeOfList % 2 == 0) {
                    Console.WriteLine("The middle elements are " + list[sizeOfList / 2] + " and " + list[sizeOfList / 2 + 1]);
                } else {
                    Console.WriteLine("The middle element is " + list[sizeOfList / 2]);
                }
            } else {
                Console.WriteLine("There is no elements in the list");
            }
        }

        static void LargestIntegerInTheList(List<int> list) {
            int size = list.Count;
            if (size != 0)
            {
                int max = list[0];
                for (int i = 1; i < size; i++)
                {
                    if (list[i] > max)
                    {
                        max = list[i];
                    }
                }

                Console.WriteLine("The largest integer in the list is " + max);
            } else {
                Console.WriteLine("There is no elements in the list");
            }
        }
    }
}
