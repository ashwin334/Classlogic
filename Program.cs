using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int a = 10;
            
            int b = ++a;
            int c = --b *  ++a;
            int d = ++c *  ++b  + --a;
            
            Console.WriteLine(a); //11
            Console.WriteLine(b); //11
            Console.WriteLine(c);//121
            Console.WriteLine(d);//1342
                        
        }
    }
}
