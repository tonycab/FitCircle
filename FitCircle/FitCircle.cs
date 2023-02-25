using System;
using MathNet.Numerics.LinearAlgebra;

namespace nFitCircle
{
    class CircleFit
    {
   
        public static void GetFitCircle(double[][] points, out double CenterX, out double CenterY, out double CenterZ, out double Radius)
        {
            int n = points.Length;

            // Creatric des matrix de dimension n
            var A = Matrix<double>.Build.Dense(n, 4);
            var b = Vector<double>.Build.Dense(n);


            for (int i = 0; i < n; i++)
            {
                double x = points[i][0];
                double y = points[i][1];
                double z = points[i][2];

                A[i, 0] = x;
                A[i, 1] = y;
                A[i, 2] = z;
                A[i, 3] = 1;

                b[i] = x * x + y * y + z * z;
            }

            // Resoudre l'équation linéaire
            var qr = A.QR();
            var s = qr.Solve(b);

            // Recuperation du résultat
            CenterX = s[0] / 2;
            CenterY = s[1] / 2;
            CenterZ = s[2] / 2;
            Radius = Math.Sqrt(s[3] + CenterX * CenterX + CenterY * CenterY + CenterZ * CenterZ);
        }
    }
}