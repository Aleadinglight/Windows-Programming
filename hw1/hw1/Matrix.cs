using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Matrix
    {
        private int row, col;
        private int[,] array;
        public static Random randNum = new Random();

        public int getWidth
        {
            get { return row; }
        }

        public int getHeight
        {
            get { return col; }
        }

        public Matrix(int width, int height)
        {
            this.row = width;
            this.col = height;
            this.array = new int[this.row, this.col];
            for (int i = 0; i < this.row; i++)
                for (int j = 0; j < this.col; j++)
                    this.array[i, j] = randNum.Next(1, 10);
        }

        public int[,] value()
        {
            return this.array;
        }

        public Matrix add( Matrix b)
        {
            // Create another matrix with the same size as a & b
            Matrix c = new Matrix(this.row, this.col);
            for (int i = 0; i < c.row; i++)
                for (int j = 0; j < c.col; j++)
                    c.value()[i, j] = this.value()[i, j] + b.value()[i, j];
            return c;
        }

        public Matrix minus(Matrix b)
        {
            // Create another matrix with the same size as a & b
            Matrix c = new Matrix(this.row, this.col);
            for (int i = 0; i < c.row; i++)
                for (int j = 0; j < c.col; j++)
                    c.value()[i, j] = this.value()[i, j] - b.value()[i, j];
                   
            return c;
        }

        public Matrix mul(Matrix b)
        {
        
            
            // Create another matrix with the same size as a & b
            Matrix c = new Matrix(this.row, b.col);
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < b.col; j++)
                {
                    c.value()[i, j] = 0;
                    for (int k = 0; k < this.col; k++)
                    {
                        c.value()[i, j] += this.array[i,k] * b.value()[k, j];
                    }

                }
            }
            return c;
        }

    }
}
