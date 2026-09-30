using System;
using System.Collections.Generic;
using System.Text;

namespace Navigation_Test {
    internal class Menu {
        public string[] menuList;
        public string title = "";

        public Menu(string[] menuList, string title) {
            this.menuList = menuList;
            this.title = title;
        }

        public int Navigate() {
            int cursorIndex = 0;
            bool isSelected = false;

            while (!isSelected) {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{title.ToUpper()}\n");

                for (int i = 0; i < menuList.Length; i++) {
                    if (i == cursorIndex) {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine(menuList[i]);
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(menuList[i]);
                    }
                }
                Console.ResetColor();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key) {
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

                if (cursorIndex < 0) {
                    cursorIndex = menuList.Length - 1;
                }
                else if (cursorIndex > menuList.Length - 1) {
                    cursorIndex = 0;
                }
            }

            return cursorIndex;
        }
    }
}
