using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NuniTeam2;

namespace NuniTeam2
{
    public class MapDrawer
    {

        //private char[,] map = new char[16, 16];
        static string [,] map = {{"* "},{"* "},{"* "},{"* "},{"* "},{"* \n"},
                                  {"* "},{"  "},{"  "},{"  "},{"  "},{"* \n"},
                                  {"* "},{"  "},{"  "},{"# "},{"  "},{"* \n"},
                                  {"* "},{"  "},{"  "},{"# "},{"  "},{"* \n"},
                                  {"* "},{"  "},{"  "},{"  "},{"  "},{"* \n"},
                                  {"* "},{"* "},{"* "},{"* "},{"* "},{"* \n"}};
        
        static public void MapClear()
        {
            foreach(string j in map)
            {
                Console.Write(j);
            }
        }
        public string[,] GetMap()
        {
            return map;
        }

        public void SetMap(string[,] map)
        {
            //this.map = map;
        }
        public void DrawApple(int x, int y)
        {
            
            if (map[x,y] != "# ")
            {
                map[x,y] = "@ ";
                GenerateApples.spawn = false;
            }
            else 
            {
                GenerateApples _generateApples = new GenerateApples();
            }    
          
            foreach(string j in map)
            {
                Console.Write(j);
            }
        }
        
        public void Drow()
        {
            Console.Clear();
            foreach(string j in map)
            {
                Console.Write(j);
            }
            Thread.Sleep(1000);
        }
    }
}