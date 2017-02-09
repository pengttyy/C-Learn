using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableAndExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 10;
            string myStr = "test";
            //原生支持占位符
            Console.WriteLine("{0},{1}", myInt, myStr);
            Console.ReadKey();
        }
    }
}
