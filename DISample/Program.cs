using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //仮のクラスBもどきを作って
            var b = new BModoki();

            //クラスAに渡してやる。
            var a = new A(b);
        }
    }



    class A
    {
        public A(IBclass b)
        {
            Console.WriteLine(b.CalcAdd(1, 2));
        }
    }

    interface IBclass
    {
        int CalcAdd(int x, int y);
    }

    class B : IBclass
    {
        public int CalcAdd(int x, int y)
        {
            //開発中
            return (x + y);
        }
    }

    class BModoki : IBclass
    {
        public int CalcAdd(int x, int y)
        {
            return 4;
        }
    }
}
