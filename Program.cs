using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabonacci
{
    class Program
    {
        static void Fabonacci (int n1, int n2)
        {
            //at my discretion I added a limit for n2 value
            if(n2 > 1000)
            {
                return;
            } else
            {
                int sum = n1 + n2;
                Console.WriteLine(sum);
                Fabonacci(n2, sum);
            }
        }
        static void Main(string[] args)
        {
            Fabonacci(0, 1);
            Console.WriteLine("The End");
        }
    }
}
