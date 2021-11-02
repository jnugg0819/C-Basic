using System;

namespace CSharp
{ 
    class Knight
    {
        //접근한정자.
        //public protected private(default는 private)
        protected int hp;

        public void SecretFunction()
        {
            hp = 20;
        }

        public void SetHp(int hp)
        {
            this.hp = hp;
        }
    }

       
    class SuperKnight : Knight
    {
        void Test()
        {
            hp = 10;
        }
    }

    class Program
    {


        static void Main(string[] args)
        {

            Knight knight = new Knight();
            knight.SetHp(100);

            
        }
    }
}
