
namespace SnakeGame
{
    public class Pixel
    {
       /* private const int _mapWidth = 10;
        private const int _mapHeight = 10;

        public int X { get; } 
        public int Y { get; }

        public ConsoleColor Color {get;}
        private const string PixelChar = "██";

        public Pixel(int x, int y, ConsoleColor color )
        {
            X = x;
            Y = y;
            Color = color;
        }

        public Pixel()
        {
        
        }
        

        public void Draw()
        {
            Console.ForegroundColor = Color;
            Map.map[X][Y] = PixelChar;
            DrawMap();
        }

        public void ClearMap()
        {
            for (int i = 1; i < _mapHeight - 1; i++)
            {
                    for(int j = 1; j < _mapWidth - 1; j ++)
                    {
                        Map.map[i][j] = "  ";
                    }
            }
            DrawMap();
        }

        public void DrawMap()
        {
            Console.Clear();
            for (int i = 0; i < _mapHeight; i++)
            {
                for(int j = 0; j < _mapWidth; j ++)
                {
                    Console.Write(Map.map[i][j]);
                }
            }
        }

        public void DrawBoarder()
        {
            Console.ForegroundColor = Color;
           
            for(int j = 0; j < _mapWidth; j ++)
            {
                Map.map[0][j] = PixelChar;
                Map.map[9][j] = PixelChar;

            }

            for(int j = 0; j < _mapHeight; j ++)
            {
                Map.map[j][0] = PixelChar;
                Map.map[j][9] = PixelChar + "\n";

            }

            DrawMap();
        }*/
    }
}