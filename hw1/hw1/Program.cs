using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        // This procedure is used to print out the matrix
        static void writeMatrix(Matrix n)
        {
            for (int i = 0; i < n.getWidth; i++)
            {
                for (int j = 0; j < n.getHeight; j++)
                    Console.Write(n.value()[i, j]+" ");
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            // Define the sizes for the random matrices
            Random randNum = new Random();
            int width = randNum.Next(1, 5);
            int height = randNum.Next(1, 5);

            // Create 2 random matrices
            Matrix a = new Matrix(width, height);
            Matrix b = new Matrix(width, height);
            // Output the matrices to the screen
            Console.Write("A\n");
            writeMatrix(a);
            Console.Write("B\n");
            writeMatrix(b);

            // Perform basic operation 
            Matrix sum = a.add(b);
            Matrix diff = a.minus(b);
            Matrix product= a.mul(b);
            // Output the results
            Console.Write("A+B\n");
            writeMatrix(sum);
            Console.Write("A-B\n");
            writeMatrix(diff);
            Console.Write("A*B\n");
            writeMatrix(product);
        }
    }
}
