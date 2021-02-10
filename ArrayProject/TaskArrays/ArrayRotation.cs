using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseArray.TaskArrays
{
    public class ArrayRotation
    {
        public void TaskArrayRotation()
        {
            string[] arrayRotate = Console.ReadLine().Split(" ");

            int numbRotation = int.Parse(Console.ReadLine());

            while(numbRotation > 0)
            {
                string first = arrayRotate[0];
                List<string> tmpList = arrayRotate.ToList();
                tmpList.Add(first);
                tmpList.RemoveAt(0);
                arrayRotate = tmpList.ToArray();

                numbRotation--;
            }

            foreach (var item in arrayRotate)
            {
                Console.Write(item + " ");
            }            

        }
    }
}
