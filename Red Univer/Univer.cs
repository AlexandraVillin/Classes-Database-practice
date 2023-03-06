using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Univer
{
    class Univer : Register
    {
        private List<Register> rs/* = new List<Kasa> { }*/;

        public Register FreeRegister()
        {
            Register min = rs[0];
            for (int i  = 0; i < rs.Count; ++i)
            {
                if (min.BN > rs[i].BN) min = rs[i];
            }
            return min;
        }

        public void ChooseAndPutBuyerToRegister(Buyer buyer)
        {
            FreeRegister().AddBuyer(buyer);
        }
        public void PutOnOtherRegister(int rs1, int rs2, int n)
        {
            int br = 0;
            foreach (Register c in rs)
            {
                while(br < rs[rs2].MB)
                {
                    rs[rs2].row1.Enqueue(rs[rs2].row1.Dequeue());
                }
            }
        }

        public void GenerateReport()
        {
            foreach(Register c in rs)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public override string ToString()
        {
            string str = "";

            foreach (Register c in rs)
            {
                str = str + c.ToString();
            }

            return str;
        }

    }
}
