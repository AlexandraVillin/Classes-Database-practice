using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Univer
{
    class Register : Buyer
    {
        private const int timeByArticle = 10;
        private const int maxBuyers = 5;
        public Queue<Buyer> row1 = new Queue<Buyer> { };
        private int buyerNumber = 0;
        private int moneyInRegister = 0; 
        private int totalTime = 0;

        public int BN
        {
            get { return buyerNumber; }
            set { buyerNumber = value; }
        }

        public int MB
        {
            get { return maxBuyers; }
        }

        public void AddBuyer(Buyer k)
        {
            if (RowLength() < maxBuyers) 
            { 
                row1.Enqueue(k);
                buyerNumber++;
            }
            else Console.WriteLine("Register is busy, please find another");
        }

        public void ServeBuyer()
        {
            if (RowLength() != 0 && (row1.Peek().Money > row1.Peek().Total()))
            {
                Buyer k = row1.Dequeue();
                Console.WriteLine(k.ToString());
                buyerNumber--;
                moneyInRegister += k.Total();
                totalTime += k.Time(timeByArticle);
            }
            else if(row1.Peek().Money < row1.Peek().Total())
            {
                row1.Dequeue();
                buyerNumber--;
            }
            else Console.WriteLine("Register is empty");
        }

        public int RowLength()
        {
            return row1.Count;
        }

        public override string ToString()
        {
            string str = "\nTime by article is " + timeByArticle + "\nmax number of buyers is " + maxBuyers + "\non this register there is " + buyerNumber + " buyers\nin the register there is " + moneyInRegister + "euros\nregister is working for " + totalTime +  " minutes";
            foreach (Article x in row1)
            {
                str = str + x.ToString();
            }
            return str;
        }

    }
}
