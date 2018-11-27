using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1601140_assignment1
{
    class matrix
    {
        //
        private int row, col;
        private int[,] a;
        public matrix (int inRow, int inCol)
        {
            Random rand = new Random();
            this.row = inRow;
            this.col = inCol;
            this.a = new int[this.row, this.col];
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.col; j++)
                {
                    this.a[i, j] = rand.Next(0, 20);
                }
            }
        }
        public void view_matrix()
        {
            Console.WriteLine("Matrix dimensions: " + this.row + " " + this.col);
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.col; j++)
                {
                    Console.Write(this.a[i,j] + " ");
                }
                Console.WriteLine("");
            }
        }
        public matrix sum_matrix(matrix a)
        {
          
                matrix res = new matrix(a.row, a.col);
                for (int i = 0; i < a.row; i++)
                {
                    for (int j = 0; j < a.col; j++)
                    {
                        res.a[i, j] = this.a[i, j] + a.a[i, j];
                    }
                }
            return res;
        }
        public matrix subtract_matrix(matrix a)
        {
            matrix res = new matrix(a.row, a.col);
            for (int i = 0; i < a.row; i++)
            {
                for (int j = 0; j < a.col; j++)
                {
                    res.a[i, j] = this.a[i, j] - a.a[i, j];
                }
            }
            return res;
        }
        public matrix multiply_matrix(matrix a)
        {
            matrix res = new matrix(this.row, a.col);
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < a.col; j++)
                {
                     res.a[i, j] = 0;
                    for (int k = 0; k < a.row; k++)
                    {
                        res.a[i, j] += this.a[i, k] * a.a[k, j];
                    }
                   
                }
            }
            return res; 
        }
    }
}
