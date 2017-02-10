﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using super.smashing;

namespace VariableAndExpression
{
    /*
     枚举只能使用数字基本类型   
     如未指定类型，默认为int类型
    */
    enum firstEnum:byte {
        one = 10,
        two,
        three
    }

    /*
    复杂数据类型之结构
    */
    struct route {
        public firstEnum enumVal;
        public double distance;
    }
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

            //赋值操作符=、+=、-=、*=、/=、%=

            /*操作符优先级(从高到低)
            用作前缀 ++、--、 +、-(一元)，!、~
            *、/、%
            +、-
            <<,>>
            <,>,<=,>=
            ==,!=
            &
            ^
            |
            &&
            ||
            =,*=,/=,%=,+=,-=,<<=,>>=,&=,^=,|=
            ++,--用作后缀
            */

            //练习题--运算符优先级
            int var11 = 1, var12 = 2, var13 = 3, var14 = 4,var15=5, resultVar=0;
            resultVar += var11 * var12 + var13 % var14 / var15;

            /*
                1.var11*var12
                2.var13%var14/var15
                3.step1+step2
                4.resultVar = resultVar+step3
            */

            Console.WriteLine("resultVal={0}",resultVar);
            Console.ReadKey();

            /*
            显示转换与隐式转换
                隐式转换小字段与大字段运算，自动转成大的字段类型
                显示转换与java类似，（强制类型）变量或使用转换函数
            */

            /*
            checked(expression)与unchecked(expression)
            */

            byte byteVar;
            long longVar = 300;

            byteVar = unchecked((byte)longVar);
            Console.WriteLine("默认为unchecked,输出值为44，二进制高位丢失{0}", byteVar);

            //byteVar = checked((byte)longVar);
            //Console.WriteLine("System.OverflowException:算术运算导致溢出！{0}",byteVar);

            /*
            枚举
            */
            Console.WriteLine(Convert.ToInt32(firstEnum.one));
            //将string转为枚举值
            firstEnum firstEnumTwo = (firstEnum)Enum.Parse(typeof(firstEnum), "two");
            Console.WriteLine("将string转为枚举值{0}",firstEnumTwo);

            //使用结构数据类型
            route myRoute;
            myRoute.distance = 10;
            myRoute.enumVal = firstEnum.three;

            Console.WriteLine("使用结构数据类型enumValue:{0},distance:{1}", myRoute.enumVal,myRoute.distance);
        }
    }
}

//namespace相当于java中的package
//using 则相当于java中的import
namespace fabulous {
    class Test2 {
        Test t;
    }
    
}

namespace super {
    namespace smashing {
        class Test { }
    }
}
