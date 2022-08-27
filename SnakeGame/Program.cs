
using static System.Console;


namespace SnakeGame
{
    class Program
    {
       
        private static  ConsoleColor _pixelColor = ConsoleColor.Blue;
        private static  ConsoleColor _borderColor = ConsoleColor.Gray;
        
        
        static void Main()
        {
            /*new Pixel(0,0,_borderColor).DrawBoarder();
            Thread.Sleep(1000);
            new Pixel(3,5, _borderColor).Draw();
            Thread.Sleep(1000);
            new Pixel(4,6, _borderColor).Draw();
            Thread.Sleep(1000);
            new Pixel(7,7, _borderColor).Draw();
            Thread.Sleep(1000);
            new Pixel().ClearMap();
            Thread.Sleep(1000);
            new Pixel(3,5, _borderColor).Draw();
            Thread.Sleep(1000);
            new Pixel(4,4, _borderColor).Draw();
            Thread.Sleep(1000);
            new Pixel(4,6, _borderColor).Draw();
            Thread.Sleep(1000);*/

            var _map = Map.getInstance();

            for(int j = 0; j < 10; j ++)
            {
                _map.map[0][j] = "██";
                _map.map[9][j] = "██";

            }

            for(int j = 0; j < 10; j ++)
            {
                _map.map[j][0] = "██";
                _map.map[j][9] = "██" + "\n";

            }

            for(int i = 0; i < 10; i ++)
            {
                for(int j = 0; j < 10; j ++)
                {
                    Console.Write(_map.map[i][j]);
                }
            }

            var _map2 = Map.getInstance();

            for(int i = 0; i < 10; i ++)
            {
                for(int j = 0; j < 10; j ++)
                {
                    Console.Write(_map2.map[i][j]);
                }
            }


            
            

        }
        
        public void Move()
        {
            var keyMenu = Console.ReadKey();

            switch( keyMenu.Key)
            {
                case ConsoleKey.LeftArrow:
                    
                    break;
                case ConsoleKey.RightArrow: 
                    break;
                case ConsoleKey.DownArrow: 
                    break;
                case ConsoleKey.UpArrow: 
                    break;
            }

            
        }

       
    }
}