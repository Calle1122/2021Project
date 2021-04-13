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
        public string type;
        public string name;

        protected int expRequired;
        protected bool isAlive;
        protected bool isShiny;
        protected Random generator = new Random();

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

        public int dealDamage(){
            return damage;
        }

        public void drawPlayerStats(Slime playerSlime){
            System.Console.WriteLine("Type: " + playerSlime.type);
            
            if(playerSlime.isShiny == true){
                System.Console.WriteLine("*Shiny*");
            }

            System.Console.WriteLine("\nLevel: " + playerSlime.level);
            System.Console.WriteLine("Experience: " + playerSlime.exp + "/" + playerSlime.expRequired);

            System.Console.WriteLine("\nHealth: " + playerSlime.hp);
            System.Console.WriteLine("Defense: " + playerSlime.defense);
            System.Console.WriteLine("Damage: " + playerSlime.damage);
        }

    }
}
