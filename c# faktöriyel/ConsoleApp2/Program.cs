using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktöriyelHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            long fak = 1;
            for (int i = 1; i <= sayi; i++)
            {
                fak *= i;
            }
            Console.WriteLine("girilen sayının faktöriyeli: "+fak);

        }
    }
}
