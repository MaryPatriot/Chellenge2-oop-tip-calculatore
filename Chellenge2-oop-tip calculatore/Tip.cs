using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chellenge2_oop_tip_calculatore
{
    class Tip
    {
        
        private int[] _bill;
        private double [] _totalbill;
        private double [] _tips;

        public int[] Bill { get => _bill; set => _bill = value; }
        public double[] Totalbill1 { get => _totalbill; set => _totalbill = value; }
        public double[] Tips { get => _tips; set => _tips = value; }

        public Tip(int bill1, int bill2, int bill3, int bill4, int bill5)
        {
            int[] temp = {  bill1,  bill2,  bill3, bill4,  bill5 };
            Bill[5]  = temp[5];
        }

    

        public  void Totalbill()
        {
            double[] Totalbill1 = new double[5];

            double[] Tips = new double[5];


            for (int i = 0; i < 5; i++)
            {
                if (Bill[i] < 50)
                {
                    Tips[i] = Bill[i] * 0.2;
                    Totalbill1[i] = Tips[i] + Bill[i];
                }
                else if (Bill[i] >50 && Bill[i] < 200)
                {
                    Tips[i] = Bill[i] * 0.15;
                    Totalbill1[i] = Tips[i] + Bill[i];
                }
                else
                {
                    Tips[i] = Bill[i] * 0.1;
                    Totalbill1[i] = Tips[i] + Bill[i];
                }
            }

            

        }
    }
}
