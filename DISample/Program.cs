using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //クラスAの外でインスタンスを作って
            var b = new B();

            //クラスAに渡してやる。
            var a = new A(b);
        }
    }



    class A
    {
        public A(B b)
        {
            Console.WriteLine(b.CalcAdd(1, 2));
        }
    }

    class B
    {
        public int CalcAdd(int x, int y)
        {
            return (x + y);
        }
    }
}
