using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = Convert.ToInt32(Console.ReadLine());
            int[,] MatrixA= new int[limit, limit];
            int[,] MatrixB = new int[limit, limit];
            int[,] sumMatrix = new int[limit,limit];
            Random rnd = new Random();

            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j < limit; j++)
                {
                    MatrixA[i, j] = rnd. Next(1,100);
                    MatrixB[i, j] = rnd.Next(1,100);
                    sumMatrix[i, j] = MatrixA[i, j] + MatrixB[i,j];

                    Console.Write("{0,5}" , MatrixA[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-------------------------------------------\n");

            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j < limit; j++)
                {
                    MatrixB[i, j] = rnd.Next(1, 100);                   
                    Console.Write("{0,5}", MatrixB[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-----------------------------------------\n");

            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j < limit; j++)
                {
                    sumMatrix[i, j] = MatrixA[i, j] + MatrixB[i, j];
                    Console.Write("{0,5}", sumMatrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
