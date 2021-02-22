using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chellenge2_oop_tip_calculatore
{
    class Program
    {
        static void Main(string[] args)

        {

            Tip obj1 = new Tip(124, 48, 268, 180 ,42);
            obj1.Totalbill();

            foreach (var item in obj1.Tips)
            {
            Console.WriteLine(item);
            }
            foreach (var item in obj1.Totalbill1)
            {
                Console.WriteLine(item);
            }


        }
    }
}
