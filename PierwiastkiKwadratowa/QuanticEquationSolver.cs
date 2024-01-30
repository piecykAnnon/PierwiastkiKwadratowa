using System;

namespace PierwiastkiKwadratowa
{
    public class QuadraticEquationSolver
    {
        public String Solve(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return $"Równanie ma dwa pierwiastki rzeczywiste: x1 = {x1}, x2 = {x2}";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return $"Równanie ma jeden pierwiastek rzeczywisty: x = {x}";
            }
            
                return "Równanie nie ma pierwiastków rzeczywistych.";
            
        }
    }
}
