using System;
using System.Collections.Generic;
using System.Text;

namespace Hydac
{
    internal class Menu
    {
        private string title;
        private string[] menulist;

        public Menu(string[] menulist, string title)
        {
            this.menulist = menulist;
            this.title = title;
        }

        public void Navigate()
        {
            int cursorIndex = 0;
            for (int i = 0; i < menulist.Length; i++)
            {
                if (i == cursorIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(menulist[i]);
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(menulist[i]);
                }

            }

            Console.ResetColor();

        }
    }
}
