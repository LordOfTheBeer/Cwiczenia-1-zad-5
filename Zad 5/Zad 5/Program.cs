namespace Zad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2, x0;

            Console.WriteLine("Podaj a");

            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b");

            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj c");

            c = double.Parse(Console.ReadLine());

                delta = b * b - a * c;
            Console.WriteLine("delta {0:f2}",delta);

            if (delta > 0)
            {
                Console.WriteLine("delta dodatnia");

                x1 = (-b - (double)Math.Sqrt(delta) / (2 * a));

                x2 = (-b + (double)Math.Sqrt(delta) / (2 * a));

                Console.WriteLine("x1 {0:f2}", + x1);

                Console.WriteLine("x2 {0:f2}", + x2);
            }
            else if (delta == 0)
            {
                x0 = (-b / 2 * a);

                Console.WriteLine("delta wynosi zero i jeden pierwiastek wynosi {0:f2}", + x0);
            }

            else
                Console.WriteLine("delta ujemna - brak pierwiastkow");

            Console.ReadKey();
        }
    }
}