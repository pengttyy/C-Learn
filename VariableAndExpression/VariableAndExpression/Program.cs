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

            //变量默认值
            sbyte mysbyte;
            bool mybool;
            //Console.Write(mybool); 与java不同基本类型必须初始化

            myStr = @"一成不变的
                显示字符串,类似于<pre>";
            Console.WriteLine(myStr);

            //数学运算符+、-、*、/、%,特殊的一元操作符+、-
            int var1 = 1, var2 = 2;
            var1 = +var2;
            Console.WriteLine("一元操作符\"+\"var1的值{0}，var2的值{1}，跟赋值没什么差别", var1, var2);

            int var3 = 1, var4 = 2;
            var3 = -var4;
            Console.WriteLine("一元操作符\"-\"var1的值{0}，var2的值{1} 赋值乘以-1", var3, var4);


            Console.ReadKey();
        }
    }
}
