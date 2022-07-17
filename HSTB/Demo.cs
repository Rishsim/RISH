using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSTB
{
    public class Demo
    {
        public void Z1()
        {
            Hashtable ramya = new Hashtable();

            ramya.Add("key", "value");

            ramya.Add(10, 10);

            ramya.Add(887766d,222222);

            foreach (Object suresh in ramya.Values)

            {
                Console.WriteLine(suresh);


            }




        }




    }
}
