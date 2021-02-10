using System;

namespace ExerciseArray.TaskArrays
{
    public class ZigZag
    {
        public void TaskZigZag()
        {
            int numbArrays = int.Parse(Console.ReadLine());
            int[] zig = new int[numbArrays];
            int[] zag = new int[numbArrays];

            for (int i = 0; i < numbArrays; i++)
            {
                string[] readRow = Console.ReadLine().Split(" ");
                if (i % 2 == 0)
                {
                    zig[i] = int.Parse(readRow[0]);
                    zag[i] = int.Parse(readRow[1]);
                }
                else 
                {
                    zig[i] = int.Parse(readRow[1]);
                    zag[i] = int.Parse(readRow[0]);
                }
            }

            foreach (var zi in zig)
            {
                Console.Write(zi + " ");
            }

            Console.WriteLine();

            foreach (var za in zag)
            {
                Console.Write(za + " ");
            }
        }
    }
}
