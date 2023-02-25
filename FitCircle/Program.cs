using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nFitCircle;

namespace FitCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double[][] points = new double[][]
            {
                new double[]{6.0,0.0,1.0 },
                new double[]{0.0,6.0,1.0 },
                new double[]{-4.0,0.0,1.0 },
                new double[]{0.0,-4.0,1.00001 },
               
            };


            CircleFit.GetFitCircle(points, out double centerX, out double centerY, out double centerZ, out double radius);

            Console.WriteLine($"Center X :{centerX}");
            Console.WriteLine($"Center Y :{centerY}");
            Console.WriteLine($"Center Z :{centerZ}");
            Console.WriteLine($"Radius :{radius}");
            Console.ReadLine();

        }
    }
}
