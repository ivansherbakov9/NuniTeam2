namespace NuniTeam2
{
    public class Snake
    {
        public int SnakeLenght{get;set;}
        public int SpeedSnake{get;set;}
        ConsoleKeyInfo keyMenu;
        public void Move()
        {
            keyMenu = Console.ReadKey();
            if(keyMenu.Key == ConsoleKey.RightArrow)
            {

            }
            if(keyMenu.Key == ConsoleKey.LeftArrow)
            {

            }
            if(keyMenu.Key == ConsoleKey.UpArrow)
            {

            }
            if(keyMenu.Key == ConsoleKey.DownArrow)
            {

            }
        }
       public void Death()
       {

       }

    }
}