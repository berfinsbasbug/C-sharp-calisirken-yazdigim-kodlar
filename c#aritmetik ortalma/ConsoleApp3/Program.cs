using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kaç adet sayı gireceksiniz?");
            int adet=Convert.ToInt32(Console.ReadLine());
            double toplam = 0;
            for (int i=1;i<=adet; i++) 
            {
                Console.WriteLine($"#{i}. sayıyı giriniz: ");
                double sayi=Convert.ToDouble(Console.ReadLine());
                toplam += sayi;
            }
            Console.WriteLine($"#girdiğiniz sayı adedi {adet}\n girdiğiniz sayıların toplamı {toplam}");
            double ortlama = toplam / adet;
            Console.WriteLine($"#girdiğiniz sayıların aritmetik ortalaması:{ortlama}");
        }
    }
}
