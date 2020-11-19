using System;

namespace Cislo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Myslim si cislo.. Jake to je?");
            Random rd = new Random();
            int cislo = rd.Next(1, 20);
            int vstup = Convert.ToInt32(Console.ReadLine());
            while (vstup != cislo) {
                if (vstup < cislo) {
                    Console.WriteLine("Vetsi");
                }
                if (vstup > cislo) {
                    Console.WriteLine("Mensi");
                }
                vstup = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("CG");
        }
    }
}