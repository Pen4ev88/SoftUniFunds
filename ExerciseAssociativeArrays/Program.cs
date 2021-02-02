using ExerciseAssociativeArrays.TasksAssociativeArrays;
using System;

namespace ExerciseAssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Select task of Exercise:");
            Console.WriteLine("1. CountChar:");
            Console.WriteLine("2. MinerTest:");
            Console.WriteLine("3. LegendaryFarming:");
            Console.WriteLine("4. Orders:");
            Console.WriteLine("5. SoftUniParking:");
            Console.WriteLine("6. Cources:");
            Console.WriteLine("7. StudentAcademy:");
            Console.WriteLine("8. CompanyUser:");
            Console.WriteLine("9. ForceBook:");
            Console.WriteLine("10. Exam:");

            CountChar countChar = new CountChar();
            MinerTast minerTast = new MinerTast();
            LegendaryFarming legendaryFarming = new LegendaryFarming();
            Orders orders = new Orders();
            SoftUniParking softUniParking = new SoftUniParking();
            Courses courses = new Courses();
            StudentAcademy studentAcademy = new StudentAcademy();
            CompanyUser companyUser = new CompanyUser();
            ForceBook forceBook = new ForceBook();
            SoftUniExam softUniExam = new SoftUniExam();

            int switch_on = int.Parse(Console.ReadLine());

            switch (switch_on)
            {
                case 1:
                    {
                        countChar.TaskCountChar();
                        break;
                    }
                case 2:
                    {
                        minerTast.TaskMinerTast();
                        break;
                    }
                 case 3:
                    {
                        legendaryFarming.TsakLegendaryFarming();
                        break;
                    } 
                 case 4:
                    {
                        orders.TaskOrders();
                        break;
                    } 
                 case 5:
                    {
                        softUniParking.TaskSoftUniParking();
                        break;
                    } 
                 case 6:
                    {
                        courses.TaskCourses();
                        break;
                    } 
                 case 7:
                    {
                        studentAcademy.TaskStudentAcademy();
                        break;
                    } 
                 case 8:
                    {
                        companyUser.TaskCompanyUser();
                        break;
                    } 
                 case 9:
                    {
                        forceBook.TaskForceBook();
                        break;
                    }
                  case 10:
                    {
                        softUniExam.TaskSoftUniExam();
                        break;
                    }             
                
                default:
                    Console.WriteLine("Exit:");
                    break;
            }
        }
    }
}
