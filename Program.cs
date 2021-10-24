using System;

namespace CSharp
{
    class Program
    {

        enum Job
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Magi = 3
        }

        static Job ChooseJob()
        {
            Console.WriteLine("직업을 선택해주세요.");
            Console.WriteLine("[1] night");
            Console.WriteLine("[2] archor");
            Console.WriteLine("[3] magician");

            Job choice = Job.None;
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choice = Job.Knight;
                    break;
                case "2":
                    choice = Job.Archer;
                    break;
                case "3":
                    choice = Job.Magi;
                    break;
            }

            return choice;
        }

        static void Main(string[] args)
        {
       
            while (true)
            {
                Job choice = ChooseJob();
                if (choice != Job.None)
                    break;

            }
        }
    }
}
