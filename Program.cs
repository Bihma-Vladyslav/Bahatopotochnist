using System;
using System.Threading;

namespace Bahatopotochnist
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main()
        {
            int[] array = new int[5];

            Console.WriteLine("Enter array elements:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Thread t1 = new Thread(() =>
            {
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                Console.WriteLine("Max value: " + max);
            });

            Thread t2 = new Thread(() =>
            {
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
                Console.WriteLine("Min value: " + min);
            });

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.ReadLine();
        }
    }

}
