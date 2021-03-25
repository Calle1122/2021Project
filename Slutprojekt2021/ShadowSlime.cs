using System;

namespace Slutprojekt2021
{
    public class ShadowSlime : Slime
    {
        public ShadowSlime(){
            type = "Shadow";

            damage = generator.Next(65, 101);
            hp = generator.Next(25, 61);
            defense = generator.Next(15, 51);

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
