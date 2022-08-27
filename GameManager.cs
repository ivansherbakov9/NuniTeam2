using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuniTeam2
{
    public class GameManager
    {
        private MapDrawer _mapDrawer;
        private GenerateApples _generateApples;

        public void Start(){
            _mapDrawer = new MapDrawer();
            _generateApples = new GenerateApples();
            while (true)
            {
                Update();
            }
        }

        private void Update(){
            _mapDrawer.Drow();
        }
        
        
    }
}