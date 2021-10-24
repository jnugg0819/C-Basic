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

        struct Player
        {
            public int hp;
            public int attack;
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


        static void CreatePlayer(Job choice, out Player player)
        {
            //기사 (100/10) 궁수(75/12) 마법사(50/15)

            switch (choice)
            {
                case Job.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case Job.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case Job.Magi:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
          
        }

        static void Main(string[] args)
        {
       
            while (true)
            {
                Job choice = ChooseJob();
                if (choice != Job.None)
                {
                    //캐릭터 생성.
                    Player player;

                    CreatePlayer(choice, out player);

                    Console.WriteLine($"HP{player.hp} Attack{player.attack}");
 

                }

            }
        }
    }
}
