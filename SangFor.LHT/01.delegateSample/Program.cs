using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.delegateSample
{
    public class Math
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }

    //为了保证不会用错方法，首先定义一个委托来规范使用
    //这个类型表示需要传递两个整数作为参数，并且返回一个整数的方法
    public delegate int interSum(int i, int j);

    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            interSum interSum = new interSum(math.Sum);
            var ss = interSum(3,6);
            Console.WriteLine(ss);
            Console.ReadKey();

        }
    }
}
