using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Univer
{
    class Buyer : Article
    {
        private List<Article> articles = new List<Article> {};
        private int money;

        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        public Buyer()
        {
            this.money = 0;
        }

        public Buyer(int money)
        {
            this.money = money;
        }

        public void AddArticle(Article a)
        {
            articles.Add(a);
        }

        public bool RemoveArticle(int index)
        {
            if (index < articles.Count)
            {
                articles.RemoveAt(index);
                return true;
            }
            else return false;
        }

        public int Total()
        {
            int x = 0;
            foreach (Article c in articles)
            {
                x += c.Price;
            }
            return x;
        }

        public int Time(int x)
        {
            int z = 0;
            foreach (Article c in articles)
            {
                z += x;
            }
            return z;
        }

        public override string ToString()
        {
            string str = "";
            foreach (Article x in articles)
            {
                str = str + x.ToString();
            }
            str = str + "\nmoney: " + money;
            return str;
        }

    }
}
