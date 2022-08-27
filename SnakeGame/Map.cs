namespace SnakeGame
{
    class Map
    {
        private static Map instance;
    
        private Map()
        {}
    
        public static Map getInstance()
        {
            if (instance == null)
                instance = new Map();
            return instance;
        }

        public void DrawNewMap()
        {
            for(int i = 0; i < 10; i ++)
            {
                for(int j = 0; j < 10; j ++)
                {
                    Console.Write(map[i][j]);
                }
            }
        }
        public string[][] map = 
            {
            new string[] {" LOL","  ","  ","YES  ","  ","  ","  ","  ","  ","  "},
            new string[] {"  ","  ","  ","  ","  ","  ","  ","  ","  ","  "}, // 1
            new string[] {"  ","  ","  ","  ","  ","  ","  ","  ","  ","  "},
            new string[] {"  ","  ","  ","  ","  ","  ","  ","  ","  ","  "}, // 3
            new string[] {"  ","  ","  ","  ","  ","  ","  ","  ","  ","  "},
            new string[] {"  ","  ","  ","  ","  ","  ","  ","  ","  ","  "}, // 5
            new string[] {"  ","  ","  ","  ","  ","  ","  ","  ","  ","  "},
            new string[] {"  ","  ","  ","  ","  ","  ","  ","  ","  ","  "}, // 7
            new string[] {"  ","  ","  ","  ","  ","  ","  ","  ","  ","  "}, 
            new string[] {"  ","  ","  ","  ","  ","  ","  ","  ","  ","  "}, // 9
            };
}


}