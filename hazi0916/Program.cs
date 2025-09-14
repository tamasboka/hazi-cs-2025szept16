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
            Console.Write("Név: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Szia {name}");
        }
        static void F3()
        {
            Console.Write("Szám: ");
            Console.WriteLine(int.Parse(Console.ReadLine())*2);
        }
        static void F4()
        {
            Console.Write("1. szám: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("2. szám: ");
            int szam2 = int.Parse(Console.ReadLine());
            Console.WriteLine(szam1 + szam2);
            Console.WriteLine(szam1 - szam2);
            Console.WriteLine(szam1 * szam2);
            Console.WriteLine(szam1 / szam2);
        }
        static void F5()
        {
            Console.Write("1. szám: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("2. szám: ");
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
            Console.Write("1. szám: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("2. szám: ");
            int szam2 = int.Parse(Console.ReadLine());
            Console.Write("3. szám: ");
            int szam3 = int.Parse(Console.ReadLine());
            if (szam1 < szam2 && szam1 < szam3)
            {
                Console.WriteLine($"{szam1} a legkisebb");
            } else if (szam2 < szam1 && szam2 < szam3)
            {
                Console.WriteLine($"{szam2} a legkisebb");
            } else
            {
                Console.WriteLine($"{szam3} a legkisebb");
            }
        }
        static void F7()
        {
            Console.Write("a oldal: ");
            int a_oldal = int.Parse(Console.ReadLine());
            Console.Write("b oldal: ");
            int b_oldal = int.Parse(Console.ReadLine());
            Console.Write("c oldal: ");
            int c_oldal = int.Parse(Console.ReadLine());
            if (a_oldal + b_oldal > c_oldal || b_oldal + c_oldal > a_oldal || a_oldal + c_oldal > b_oldal)
            {
                Console.WriteLine("Szerkeszthető");
            } else
            {
                Console.WriteLine("Nem szerkeszthető");
            }
        }
        static void F8()
        {
            Console.Write("1. szám: ");
            double szam1 = double.Parse(Console.ReadLine());
            Console.Write("2. szám: ");
            double szam2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Számtani közép: {(szam1 + szam2) / 2}");
            Console.WriteLine($"Mértani közép: {Math.Sqrt(szam2 * szam1)}");
        }
        static void F9()
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d > 0 || d == 0)
            {
                Console.WriteLine("Van megoldása");
            } else
            {
                Console.WriteLine("Nincs megoldása");
            }
        }
        static void F10()
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Nincs megoldás");
            } else if (d == 0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine($"1 megoldás\n{x1}");
            } else
            {
                double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
                double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
                Console.WriteLine("2 megoldás");
                Console.WriteLine($"x1: {x1}");
                Console.WriteLine($"x2: {x2}");
            }
        }
        static void F11()
        {
            Console.Write("1. befogó: ");
            double befogo1 = double.Parse(Console.ReadLine());
            Console.Write("2. befogó: ");
            double befogo2 = double.Parse(Console.ReadLine());
            double atfogo = Math.Round(Math.Sqrt(befogo1 * befogo1 + befogo2 * befogo2), 2);
            Console.WriteLine($"Átfogó: {atfogo}");
        }
        static void F12()
        {
            Console.Write("a él: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b él: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c él: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"V: {a * b * c}");
            Console.WriteLine($"A: {2 * (a * b + b * c + a * c)}");
        }
        static void F13()
        {
            Console.Write("Kör átmérője: ");
            double r = double.Parse(Console.ReadLine()) / 2;
            Console.WriteLine($"Kerület: {2 * r * Math.PI}");
            Console.WriteLine($"Terület: {r * r * Math.PI}");
        }
        static void F14()
        {
            Console.Write("Körcikk sugara: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Középponti szög: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"Körcikk területe: {r * r * Math.PI * a / 360}");
            Console.WriteLine($"Körcikk ív hossza: {2 * r * Math.PI * a / 360}");
        }
        static void Main(string[] args)
        {

        }
    }
}