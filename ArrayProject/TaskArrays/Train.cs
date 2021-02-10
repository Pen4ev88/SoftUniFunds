using System;

namespace ExerciseArray.TaskArrays
{
    public class Train
    {
        public void TaskTrain()
        {
            int numberWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numberWagons];
            int sumPeople = 0;

            for (int i = 0; i < numberWagons; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sumPeople += wagons[i];
            }

            foreach (var wag in wagons)
            {
                Console.Write(wag + " ");
            }

            Console.WriteLine();
            Console.WriteLine(sumPeople);
        }
    }
}
