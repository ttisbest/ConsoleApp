using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToldYouSo.Game
{
    class Game
    {
        public static int StartUpMenu()
        {
            // load menu
            // load ship
            return 0; //return next fase
        }
        public static void StartUpGame()
        {
           
            // draw background
            // start key lissener
            // 
        }
        public static void TheGame()
        {
            bool exit = false;
            int fase = 1;

            do
            {
                switch (fase)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        fase = StartUpMenu();
                        break;
                    case 2:
                        StartUpGame();
                        // introduction
                        break;
                    case 3:
                        StartUpGame();
                        // level 
                        break;
                    default:
                        // error page
                        break;
                }
            } while (!exit);
        }
    }
}
