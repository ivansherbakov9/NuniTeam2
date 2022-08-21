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
            GenerateApples _generateApples = new GenerateApples();
            if (map[x,y] != "# ")
            {
                map[x,y] = "@ ";
            }    
            else
            {
                if (_generateApples.spawn)
                    _generateApples.Spawn();
                _generateApples.spawn = false;
            }    
            foreach(string j in map)
            {
                Console.Write(j);
            }
        }
        public MapDrawer()
        {
            MapClear();
        }
    }
}