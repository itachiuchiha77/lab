using System;

namespace lab_1
{
    public class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
            int Time = 0;
            int[] CashBoxes = new int[n];
            for (int k = 0; k < n; ++k)
            {
                CashBoxes[k] = 0;
            }
            foreach (int current in customers)
            {
                CashBoxes[0] += current;
                Array.Sort(CashBoxes);
            }
            Time = CashBoxes[n - 1];
            return Time;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 10, 2, 3, 3 }; 
            long Time1 = HW1.QueueTime(array1, 2);
            Console.WriteLine(Time1);
            int[] array2 = { 10, 2, 3, 3 };
            long Time2 = HW1.QueueTime(array2, 1);
            Console.WriteLine(Time2);
            int[] array3 = { 5, 3, 4 };
            long Time3 = HW1.QueueTime(array3, 1);
            Console.WriteLine(Time3);
            int[] array4 = { 2, 3, 10 };
            long Time4 = HW1.QueueTime(array4, 2);
            Console.WriteLine(Time4);
        }
    }
}
