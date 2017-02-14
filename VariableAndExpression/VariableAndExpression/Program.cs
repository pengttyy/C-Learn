using System;
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
        public string routeName() {
            return enumVal.ToString() + distance; 
        }
    }
    class Program
    {
        //可变参数需要使用params关键字指定且可变参数必须是最后一个参数
        static void Special(bool flag,params int[] numbers)
        {

        }

        static void ValAdd(int input) {
            input = input + 1;
        }

        static void ValAdd2(ref int input)
        {
            input = input + 1;
        }

        static void OutFunction(int input, out int outArg) {
            outArg = input;
        }

        static void Main(string[] args)
        {
            int myInt = 10;
            string myStr = "test";
            //原生支持占位符
            Console.WriteLine("{0},{1}", myInt, myStr);
            Console.ReadKey();

            //变量默认值
            //sbyte mysbyte;
            //bool mybool;
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

            /*
            数组
            */
            //声明数组
            int[] ints1 = {1,45,44,78};
            const int intsLen = 2;
            int[] ints2 = new int[intsLen];//数组长度必须为常量
            int[] ints3 = new int[2] { 2,4};

            //声明多维数组
            int[,] table = new int[4,3];//与java的区别

            //声明锯齿数组的三种方式
            int[][] serration = new int[2][];
            serration[0] = new int[2] { 1,1};
            serration[1] = new int[3];
            Console.WriteLine("锯齿数组：{0}",serration);

            int[][] serration2 = new int[2][] { new int[] { 1,3},new int[] { 10} };

            int[][] serration3 = { new int[] { 1, 3 }, new int[] { 10 } };

            /*
            字符串处理
            */
            string msg = "c#-learn";
            Console.WriteLine(msg.ToUpper());
            Console.WriteLine(msg.ToCharArray()[0]);

            string msgTrim = " c#-learn ";
            Console.WriteLine(msgTrim.Trim());

            Console.WriteLine("去掉开始空格{0}",msgTrim.TrimStart());
            Console.WriteLine("去掉结束空格{0}",msgTrim.TrimEnd());
            Console.WriteLine("{0}字符串左对齐", msgTrim.PadLeft(20));
            Console.WriteLine("{0}字符串左对齐", msgTrim.PadLeft(20,'-'));

            //可变参数函数
            Special(true,1, 12);

            //值参数
            int input = 1;
            Console.WriteLine("值参数前:{0}", input);
            ValAdd(input);
            Console.WriteLine("值参数后:{0}", input);

            //引用参数
            int input2 = 1;
            Console.WriteLine("引用参数前:{0}", input2);
            ValAdd2(ref input2);
            Console.WriteLine("引用参数后:{0}", input2);

            //输出参数,与引用参数的区别：在函数外可以不进行初始化
            int outArg;
            int input3 = 1;
            //Console.WriteLine("输出参数:{0}", outArg);
            OutFunction(input3,out outArg);
            Console.WriteLine("输出参数:{0}", outArg);

            //结构函数
            Console.WriteLine("结构中可以使用函数{0}", myRoute.routeName());

        }
    }
}

//namespace相当于java中的package
//using 则相当于java中的import
namespace fabulous {
    class Test2 {
        //Test t;
    }
    
}

namespace super {
    namespace smashing {
        class Test { }
    }
}
