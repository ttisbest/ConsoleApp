using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToldYouSo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSettings.ConsoleSettings con = new ConsoleSettings.ConsoleSettings();

            Interactions.StartTheStory();
            Interactions.ClearScreen();
            con.FillData();
            Game.Game.TheGame();
        }
    }
}
