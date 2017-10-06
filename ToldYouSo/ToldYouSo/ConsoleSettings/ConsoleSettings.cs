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
        private int fontSize;
        private int positionLeft;
        private int positionTop;
        private int bufferWidth;
        private int bufferHeight;

        public ConsoleSettings()
        {
            this.consoleWidth = 790;
            this.consoleHeight = 169;
            this.fontSize = 5;
            this.positionLeft = 0;
            this.positionTop = 0;
            this.bufferWidth = this.consoleWidth;
            this.bufferHeight = this.consoleHeight;
        }
        //methods

        public void makeScreen()
        {
            Console.CursorSize = this.fontSize;
            Console.SetWindowSize(this.consoleWidth, this.consoleHeight);
            Console.SetWindowPosition(this.positionLeft, this.positionTop);
            Console.SetBufferSize(this.bufferWidth, this.bufferHeight);
        }

        public void placeScreen()
        {

        }
        //getters and setters
    }
}
