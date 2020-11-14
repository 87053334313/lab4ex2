using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4ex2
{
    public class Utils 
    {
        public static void Swap(ref int a, ref int b) 
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
    public class Test
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введи х");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введи y");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Перед свапом x = "+x+" , y ="+y);
        
        Utils.Swap(ref x, ref y);

        Console.WriteLine("После свапа(перестановки) x ="+x+" y = "+y);
        Console.ReadKey();

    }
    }
}
