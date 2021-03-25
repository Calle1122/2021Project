using System;
using System.Collections.Generic;

namespace Slutprojekt2021
{
    public class SlimeManager
    {
        public List<Slime> slimeList = new List<Slime>();

        public void addSlimeToList(Slime slimeToAdd){
            slimeList.Add(slimeToAdd);
        }
    }
}
