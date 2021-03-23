using System;

namespace Slutprojekt2021
{
    public class Slime
    {
        public int hp;
        public int exp;
        public int level;
        public int damage;
        public int defense;

        protected int expRequired;
        protected bool isAlive;

        public void addExp(int expAmount){
            exp = exp + expAmount;

            if(exp > expRequired){
                exp = exp - expRequired;
                expRequired = expRequired * 2;
                level++;
            }
        }

        public void takeDamage(int damageAmount){
            damageAmount = damageAmount - defense;

            if(damageAmount < 0){
                damageAmount = 0;
            }

            hp = hp - damageAmount;
            if(hp < 0){
                hp = 0;
            }

            if(hp == 0){
                isAlive = false;
            }
        }

    }
}
