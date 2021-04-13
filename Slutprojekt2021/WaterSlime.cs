using System;

namespace Slutprojekt2021
{
    public class WaterSlime : Slime
    {
        public WaterSlime(){
            type = "Water";

            damage = generator.Next(40, 76);
            hp = generator.Next(35, 71);
            defense = generator.Next(20, 56);

            level = 1;
            exp = 0;

            expRequired = 500;
            isAlive = true;

            int shinyTester = generator.Next(1, 101);
            if(shinyTester == 1){
                isShiny = true;
            }
            else{
                isShiny = false;
            }
        }


    }
}
