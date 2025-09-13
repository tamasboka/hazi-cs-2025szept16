using System.Security.Cryptography;

namespace hazi0916
{
    internal class Program
    {
        static void F1()
        {
            Console.WriteLine("Hello, World!");
        }
        static void F2()
        {
            Console.Write("nev: ");
            string nev = Console.ReadLine();
            Console.WriteLine("Szia" + nev);
        }
        static void F3()
        {
            Console.Write("szam: ");
            Console.WriteLine(int.Parse(Console.ReadLine())*2);
        }
        static void F4()
        {
            Console.Write("elso szam: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("masodik szam: ");
            int szam2 = int.Parse(Console.ReadLine());
            Console.WriteLine(szam1 + szam2);
            Console.WriteLine(szam1 - szam2);
            Console.WriteLine(szam1 * szam2);
            Console.WriteLine(szam1 / szam2);
        }
        static void F5()
        {
            Console.Write("elso szam: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("masodik szam: ");
            int szam2 = int.Parse(Console.ReadLine());
            if (szam1 > szam2)
            {
                Console.WriteLine(szam1);
            } else if (szam2 > szam1)
            {
                Console.WriteLine(szam2);
            } else
            {
                Console.WriteLine(szam1);
            }
        }
        static void F6()
        {
            Console.Write("elso szam: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("masodik szam: ");
            int szam2 = int.Parse(Console.ReadLine());
            Console.Write("harmadik szam: ");
            int szam3 = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {

        }
    }
}