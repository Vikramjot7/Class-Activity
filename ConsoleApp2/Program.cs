using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int sum = 0, i = 0;
                while(i<=5)
                {
                    
                    sum += i;
                    i++;
                }
                Console.WriteLine(sum);
                Console.ReadLine();
            }
        }
    }
}
