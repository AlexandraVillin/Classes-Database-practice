using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Univer
{
    class Article
    {
        private string name;
        private int price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Article()
        {
            this.name = ""; 
            this.price = 0;
        }

        public Article(int price, string name)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            string str = "\n" + name + " " + price;
            return str;
        }
    }
}
