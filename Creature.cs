using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Creature
    {
        CreatureType type;
     
        public enum CreatureType
        {
            None,
            Player = 1,
            Monster = 2
        }

        protected Creature(CreatureType type)
        {
            this.type = type;
        }

        protected int hp;
        protected int attack;

        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;

        }

        public int GetHp() { return hp; }
        public int GetAttack() { return attack; }

        public bool IsDead() { return hp <= 0; }

        public void OnDamaged(int damage)
        {
            hp -= damage;
            if (hp < 0)
            {
                hp = 0;
            }
        }
    }
}
