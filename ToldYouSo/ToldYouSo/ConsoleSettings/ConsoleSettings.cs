using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToldYouSo.ConsoleSettings
{
    class ConsoleSettings
    {
        private int consoleWidth;
        private int consoleHeight;
        private int bufferWidth;
        private int bufferHeight;

        //methods
        public void FillData()
        {
            this.consoleWidth = Console.WindowWidth;
            this.consoleHeight = Console.WindowHeight;
            this.bufferWidth = this.consoleWidth;
            this.bufferHeight = this.consoleHeight;
        }
        //getters and setters
        public int getConsoleWidth()
        {
            return this.consoleWidth;
        }

        public int getConsoleHeigt()
        {
            return this.consoleHeight;
        }
    }
}
