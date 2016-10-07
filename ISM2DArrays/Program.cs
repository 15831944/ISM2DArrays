using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM2DArrays
{
    class Program
    {
        static Double[,] Generate(int rows, int cols)
        {
            Double[,] mas = new Double[rows, cols];
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mas[i, j] = r.Next(0,4);
                }
            }
            return mas;
        }
        static Double[,] mnoz(Double[,] mas1, Double[,] mas2)
        {
            int c1, c2, r1, r2;
            r1 = mas1.GetLength(0);
            c1 = mas1.GetLength(1);
            r2 = mas2.GetLength(0);
            c2 = mas2.GetLength(1);
            if (c1 != r2)
                return null;
            Double[,] rmas=new Double[r1,c2];
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    for (int k = 0; k < r2; k++)
                    {
                        rmas[i, j] += mas1[i, k] * mas2[k, j];
                    }
                }
            }
            return rmas;
        }
        static void Main(string[] args)
        {
            int cols1, rows1, cols2, rows2;
            rows1 = int.Parse(Console.ReadLine());
            cols1 = int.Parse(Console.ReadLine());
            rows2 = int.Parse(Console.ReadLine());
            cols2 = int.Parse(Console.ReadLine());
            if (rows1 < 0 || rows2 < 0 || cols1 < 0 || cols2 < 0)
            {
                return ;
            }
            Double[,] mas1 = new Double[rows1, cols1];
            Double[,] mas2 = new Double[rows2, cols2];
            Double[,] rmas = new Double[rows2, cols1];
            mas1 = Generate(rows1,cols1);
            mas2 = Generate(rows2, cols2);
            rmas = mnoz(mas1,mas2);

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write(mas1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(mas2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(rmas[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
