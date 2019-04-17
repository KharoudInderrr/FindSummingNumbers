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
                AddUpToNumber = r.Next();
                ListQ = new ArrayList();
                for(int i = 0; i<LEN; i++)
                {
                    ListQ.Add(r.Next(100));
                   
                }
                this.findTwoNumbersThatAddUpTo(AddUpToNumber);

                


}

            public void  findTwoNumbersThatAddUpTo(int number)
            {
                foreach (int num1 in ListQ)
                {
                    int c, d;
                c = num1;
                foreach (int num2 in ListQ)
                {
                    d = num2;
                    if (c + d== 57)
                    {
                        Console.WriteLine("The two numbers between 0 and 100 whose sum is 57 are found. Numbers are: " + c + " " + d);
                    }
                }


            }
            Console.ReadLine();


            }


                






        }
    }
}
