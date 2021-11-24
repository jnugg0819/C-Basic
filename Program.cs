using System;

namespace CSharp
{

    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }
    }

    //오버로딩 (함수이름의 재사용) 
    //오버라이딩 (다형성이용) virtual keyword.(모든함수를 vitual로 한다는것은 비추)
    class Knight : Player
    {
        //sealed는 Knight를 상속받는 자식들은 더이상 건들지 말라는뜻.(TIP). 
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Knight 이동!");
        }
    }

    class Mage : Player
    {
        public int mp;

        public override void Move()
        {
            Console.WriteLine("Mage 이동!");
        }
    }

    class SuperKnight : Knight
    {
        public override void Move()
        {
            Console.WriteLine("SuperKnight 이동!");
        }
    }

    class Program
    {

        static Player FindPlayerById(int id)
        {
            //id에해당하는 플레이어 탐색.
            //못찾았을시엔 null.
            return null;
        }
        static void EnterGame(Player player)
        {
            player.Move();
            Mage mage = (player as Mage);
            if (mage != null) {
                mage.mp = 10;
                mage.Move();
            }
           
        }
    

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            //Mage타입이 플레이어타입으로 될수있는데 플레이어타입은 Mage타입으로 변환 바로 불가-> 타입캐스팅 해야됨 -> 하지만 해.
            //Player magePlayer = mage;
            //Mage mage2 = (Mage)magePlayer;

            //knight.Move();
            //mage.Move();

            knight.Move();

            //EnterGame(mage);
            //EnterGame(mage);

        }
    }
}
