using System;

namespace PierwiastkiKwadratowa
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj współczynniki równania kwadratowego ax^2 + bx + c = 0:");

            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            QuadraticEquationSolver solver = new QuadraticEquationSolver();

            String result = solver.Solve(a, b, c);

            Console.WriteLine(result);
        }
    }
}
