using System;

namespace CSharp
{

    class Player
    {
        protected int hp;
        protected int attack;
    }

    class Knight : Player
    {

    }

    class Mage : Player
    {
        public int mp;
    }

    class Program
    {

        static void EnterGame(Player player)
        {
            Mage mage = (player as Mage);
            if (mage != null) {
                mage.mp = 10;
            }
           
        }
    

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();
 
            //Mage타입이 플레이어타입으로 될수있는데 플레이어타입은 Mage타입으로 변환 바로 불가-> 타입캐스팅 해야됨 -> 하지만 해.
            //Player magePlayer = mage;
            //Mage mage2 = (Mage)magePlayer;

            EnterGame(mage);
            //EnterGame(mage);

        }
    }
}
