using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ToldYouSo.Game
{
    class Game
    {
        public static int StartUpMenu()
        {
            // load menu
            // load ship
            // start key lissener
            Thread EventLister = new Thread(KeyListen.StartKeyListen);
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
