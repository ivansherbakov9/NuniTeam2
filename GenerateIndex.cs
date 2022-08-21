using System;
using System.Collections.Generic;
namespace NuniTeam2
{
    public class GenerateApples
    {
        MapDrawer mapDrawer = new MapDrawer();
        List<int> range =  new List<int> {7,8,9,10,13,14,15,16,19,20,21,22,25,26,27};
        static public bool spawn = true;
      
        public void Spawn()
        {
            
        
                Random rnd = new Random();
                int num = rnd.Next(7,29);
                int rangeRnd = rnd.Next(0,range.Count);
                mapDrawer.DrawApple(range[rangeRnd],0);
            
            
        }

    }
}