﻿using System;

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

        enum MonsterType
        {
            None = 0,
            Slime =1,
            Orc = 2,
            Skeleton = 3
        }

        struct Monster
        {
            public int hp;
            public int attack;
        }

        static Job ChooseJob()
        {
            Console.WriteLine("직업을 선택해주세요.");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

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

        static void CreateRandomMonster(out Monster monster)
        {
            Random rand = new Random();
            int randMonster = rand.Next(1, 4);

            switch (randMonster)
            {
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임이 스폰되었습니다.");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크가 스폰되었습니다.");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤이 스폰되었습니다.");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
            }
            //랜덤으로 1~3 몬스터 중 하나를 리스폰.
        }

        static void Fight(ref Player player, ref Monster monster)
        {
            while (true)
            {
                //플레이아가 몬스터 공격
                monster.hp -= player.attack;
                if(monster.hp <= 0)
                {
                    Console.WriteLine("승리했습니다.");
                    Console.WriteLine($"남은 체력 {player.hp}");
                    break;
                }

                //몬스터반격
                player.hp -= monster.attack;
                if(player.hp <= 0)
                {
                    Console.WriteLine("패배했습니다.!");
                    break;
                }
            }
        }
        static void EnterField(ref Player player)
        {

            while (true)
            {
                Console.WriteLine("필드에 접속했습니다.");

                Monster monster;

                CreateRandomMonster(out monster);

                Console.WriteLine("[1] 전투 모드로 돌입");
                Console.WriteLine("[2] 일정확률로 마을로 도망");

                string input = Console.ReadLine();

                if(input == "1")
                {
                    Fight(ref player, ref monster);
                }else if(input == "2")
                {
                    //33%
                    Random rand = new Random();
                    int randvalue = rand.Next(0, 101);

                    if(randvalue <= 33)
                    {
                        Console.WriteLine("도망치는데 성공했습니다.");
                        break;
                    }else
                    {
                        Fight(ref player, ref monster);
                    }
                }

                //랜덤으로 1~3 몬스터 중 하나를 리스폰
                //[1] 전투모드로 돌입
                //[2] 일정확률로 마을로 도망
            }


        }
        static void EnterGame(ref Player player)
        {

            while (true)
            {
                Console.WriteLine("마을에 접속했습니다.");
                Console.WriteLine("[1] 필드로 간다");
                Console.WriteLine("[2] 로비로 돌아가기");

                string input = Console.ReadLine();

                if(input == "1")
                {
                    EnterField(ref player);
                } else if(input == "2")
                {
                    break;
                }
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

                    EnterGame(ref player);
                }

            }
        }
    }
}
