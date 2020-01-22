using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace chm1
{
    class Program
    {
        static double function(double x)
        {
            return 3.0d * Math.Pow(x, 2.0d) + Math.Pow(Math.Cos(x), 2.0d);
        }

        static void CalcTable(double x, double dx, out double[] x_array, out double[] y_array)
        {
            x_array = new double[5];
            y_array = new double[5];
            for (int i = 0; i < 5; i++)
            {
                x_array[i] = x;
                y_array[i] = function(x);
                Console.WriteLine($"x{i} = {x_array[i]} y{i} = {y_array[i]}");
                x += dx;
            }
        }

        static double fourDots(double[] y_array, double dx)
        {
            return (-11.0d * y_array[0] + 18.0d * y_array[1] - 9 * y_array[2] + 2 * y_array[3]) / (6.0d * dx); 
        }

        static double fiveDots(double[] y_array, double dx)
        {
            return (-25.0d * y_array[0] + 48.0d * y_array[1] - 36.0d * y_array[2] + 16.0d * y_array[3] - 3.0d * y_array[4]) / (12.0d * dx);
        }

        static void Main(string[] args)
        {
            double x_0 = 0.2380d, dx = 0.0227d;
            double[] x_array, y_array;
            CalcTable(x_0, dx, out x_array, out y_array);
            Console.WriteLine($"4:{fourDots(y_array, dx)} 5:{fiveDots(y_array, dx)}");
            Console.ReadKey();
        }
    }
}
