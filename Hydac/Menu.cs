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

        public void test()
        {
            Console.WriteLine($"{title}\n");
            for (int i = 0; i < menulist.Length; i++)
            {
            Console.WriteLine(menulist[i]);
            }
        }
    }
}
