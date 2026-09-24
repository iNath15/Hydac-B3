using System;
using System.Collections.Generic;
using System.Text;

namespace Hydac
{
    internal class Guest
    {
        private string name;
        private string business;
        private string responsible;

        public string Name 
        {
            set { name = value; }
            get { return name; }
        }

        public string Business
        {
            set { business = value; }
            get { return business; }
        }

        public string Responsible
        {
            set { responsible = value; }
            get { return responsible; }
        }
    }
}
