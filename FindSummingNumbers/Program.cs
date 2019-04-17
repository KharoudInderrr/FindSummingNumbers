using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSummingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            new GeneralList().Run(57);

        }


        class GeneralList
        {
            const int LEN = 100;
            ArrayList ListQ;
            int AddUpToNumber = 0;
            public void Run(int AddUpToNumber)

                {


                Random r = new Random();

                ListQ = new ArrayList();
                for(int i = 0; i<LEN; i++)
                {
                    ListQ.Add(r.Next(100));
                }
                this.findTwoNumbersThatAddUpTo(AddUpToNumber);




}

            public int  findTwoNumbersThatAddUpTo(int number)
            {

                number = AddUpToNumber;
                return number;



            }




        }
    }
}
