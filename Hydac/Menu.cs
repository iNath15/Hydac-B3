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

        public int Navigate()
        {
            int cursorIndex = 0;
            bool isSelected = false;

            while(!isSelected)
            {
                Console.Clear();
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

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.DownArrow:
                            cursorIndex++;
                            break;

                        case ConsoleKey.UpArrow:
                            cursorIndex--;
                            break;

                        case ConsoleKey.Enter:
                            isSelected = true;
                            break;

                        default:
                            break;

                    }
                    
                if(cursorIndex < 0)
                {
                    cursorIndex = menulist.Length - 1;
                }
                else if (cursorIndex > menulist.Length - 1)
                {
                    cursorIndex = 0;
                }


            }
            return cursorIndex;

        }
    }
}
