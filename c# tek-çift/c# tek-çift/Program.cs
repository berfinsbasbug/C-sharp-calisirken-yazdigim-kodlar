using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tek_çift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir sayı giriniz:  ");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("sıfırdan küçük sayılarda teklik-çiflik aranmaz");
            }
            else if (num%2==0)
            {
                Console.WriteLine("girdiğiniz sayı çifttir.");
            }
            else
            {
                Console.WriteLine("girdiğiniz sayı tektir");
            }
        }
    }
}
