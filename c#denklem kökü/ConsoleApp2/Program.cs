using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ax2+Bx+C=0 formundaki denklemin köklerini yazınız.");
            float a=Convert.ToInt32(Console.ReadLine());
            float b=Convert.ToInt32(Console.ReadLine());
            float c=Convert.ToInt32(Console.ReadLine());
            float d = b * b - (4 * a * c);
            if (d < 0)
            {
                Console.WriteLine("Denklemin reel kökü yoktur");
            }
            if (d >= 0)
            {
                float karekök = (float)Math.Sqrt(d);
                float x1 = (-b + karekök) / 2 * a;
                float x2 = (-b - karekök) / 2 * a;
                Console.WriteLine("denklemin birinci kökü: "+x1);
                Console.WriteLine("denklemin ikinci kökü: " + x2);
            }
        }
    }
}
