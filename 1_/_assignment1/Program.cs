using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1601140_assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rand = new Random();

                /*for sum and subtract of 2 matrices*/
                int row, col;

                /*We create a new matrix a here*/
                row = rand.Next(2,4);
                col = rand.Next(2,4);
                matrix matrixA = new matrix(row, col);
                matrixA.view_matrix();
                matrix matrixB = new matrix(row, col);
                matrixB.view_matrix();

               
               matrix matrixRes = matrixA.sum_matrix(matrixB);
               Console.WriteLine("Sum of two matrices");
               matrixRes.view_matrix();

               Console.WriteLine("Subtract of two matrices");
               matrixRes = matrixA.subtract_matrix(matrixB);
               matrixRes.view_matrix();
                // Console.WriteLine("The two matrices cannot be sum or subtract");

                /*For multiply 2 matrices*/
                int col2 = rand.Next(2, 4);
                matrixA = new matrix(row, col);
                matrixA.view_matrix();
                matrixB = new matrix(col, col2);
                matrixB.view_matrix();
                Console.WriteLine("The multiplication of 2 matrices: ");
                matrixRes = matrixA.multiply_matrix(matrixB);
                matrixRes.view_matrix();
                Console.ReadLine();
            }
        }
    }
}
