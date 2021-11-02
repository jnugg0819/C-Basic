using System;

namespace CSharp
{

    //객체(OOP Object oriented Programing)

    //Kninght
    // 속성: hp, attack, pos
    // 기능: Move, Attack, Die

    //클래스는 참조. 

    class Player // 부모 클래스 혹은 기반 클래스.
    {
        static public int counter = 1; //오로지 1개만 존재.
        public int id;
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자 호출");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자 호출");
        }


        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }


    }

    class Mage : Player
    {


    }

    class Archer : Player
    {



    }

    class Knight : Player 
    {


    }



    class Program
    {


        static void Main(string[] args)
        {

            Knight knight = new Knight();
            knight.Move();
            
        }
    }
}
