using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        enum X { a, b, c }

        struct testStruct
        {
            private int a;
            public int A
            {
                set { a = value; }
                get { return a; }
            }

            public void M1()
            {
                Console.WriteLine("struct method");
            }
        }

        class testClass
        {
            public const int a =3;
            public string b;
            public int c;
            public testClass(int _a,string _b)
            {
                b = _b;
            }

            public testClass(int A,string B,int C):this(A,B)
            {
                c = C;
            }
        }
        static void Main(string[] args)
        {
            //3rd Comment from repote 2
            //on new branch new change testtttt
            const int xy = 99;
            Console.WriteLine(xy.ToString());
            testClass tc = new testClass(2, "vv", 4);
          

            Console.WriteLine(tc.b.ToString() + tc.c.ToString());
            StringBuilder strbldr = new StringBuilder("ali");
            Console.WriteLine(strbldr.ToString());
            strbldr.Clear();
            strbldr.Append("aaaa");
            Console.WriteLine(strbldr.ToString());
            string xx = "aaa";
            if (xx is string)
                Console.WriteLine("sss");

        }
    }
}
