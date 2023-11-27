using System;
using System.Collections.Generic;



class program
{
    static List<string> a = new List<string>();


    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\"Simple Task List Application\"");
            Console.WriteLine("Press 1 for Create task.");
            Console.WriteLine("Press 2 for Read Task.");
            Console.WriteLine("Press 3 for Update Task.");
            Console.WriteLine("Press 4 for Delete Task.");
            Console.WriteLine("Press 5 for Exit.");
            Console.Write("Enter a number:");
            int d = int.Parse(Console.ReadLine());
            switch (d)
            {
                case 1:

                    Insert();
                    break;
                case 2:
                    Read();
                    break;
                case 3:
                    update();
                    break;
                case 4:
                    delect();
                    break;
                case 5:
                    Environment.Exit(0);

                    break;
                default:
                    Console.WriteLine("enter only 1 to 5 number.");
                    break;

            }
        }
        static void Insert()
        {
            Console.Write("Create a task:");
            string ad = Console.ReadLine();
            if (!string.IsNullOrEmpty(ad))
            {
                a.Add(ad);
                Console.WriteLine("Task is inserted successfully.");

            }
            else
            {
                Console.WriteLine("Task is not created.");
            }
        }
        static void Read()
        {
            Console.WriteLine("Read the tasks:");
            if (a.Count == 0)
            {
                Console.WriteLine("Here is no tasks.");

            }
            else
            {
                int ag = 1;
                foreach (var t in a)
                {
                    Console.WriteLine($"{ag}.Total Tasks: {t}");
                    ag = ag + 1;
                }

            }
        }
        static void update()
        {
            Console.Write("Enter the task no for update: ");
            int av;
            if (int.TryParse(Console.ReadLine(), out av))
            {
                if (av > 0 && av <= a.Count)
                {
                    Console.Write("Enter new task: ");
                    a[av - 1] = Console.ReadLine();
                    Console.WriteLine("Task updated successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid task no.");
                }
            }
        }
        static void delect()
        {
            Console.Write("Enter the task no for delect:");
            int ab = int.Parse(Console.ReadLine());
            if (ab > 0 && ab <= a.Count)
            {
                a.RemoveAt(ab - 1);
                Console.WriteLine("The task is delected successfully.");
            }
            else
            {
                Console.WriteLine("invalid task no.");
            }
        }
    }
}