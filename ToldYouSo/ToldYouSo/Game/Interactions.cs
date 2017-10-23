using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ToldYouSo
{
    class Interactions
    {
        public static void ClearScreen()
        {
            Console.Clear();
        }
        public static void StartTheStory()
        {
            string story =
                "Hello, This is a story to proof Sietse wrong.." +
                "\nbefore we can start i need you to do a couple of thinks for my.." +
                "\nplease do al of this things after you have read them al.." +
                "\nthe first thing is change the font size to 5.." +
                "\nthe second thing is pressing 'WindowsKey + ArrowUp' at the same time.." +
                "\nand than press 'Enter'.." +
                "\nGoodluck..";
            foreach (char letter in story)
            {
                Thread.Sleep(50);
                Console.Write(letter);
            }
            Console.ReadLine();
        }
    }
}
