using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var a = new A();
        }
    }



    class A
    {
        public A()
        {
            //クラスBのインスタンスを使う。
            var b = new B();

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
