using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Matrix
    {
        private int width,height;
        private int[,] array;
        public static Random randNum = new Random();
        public int getWidth
        {
            get { return width; }
        }

        public int getHeight
        {
            get { return height; }
        }

        public Matrix(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.array = new int[this.width, this.height];
            for (int i = 0; i < this.width; i++)
                for (int j = 0; j < this.height; j++)
                    this.array[i, j] = randNum.Next(1, 10);
        }

        public int[,] value()
        {
            return this.array;
        }

        public Matrix add( Matrix b)
        {
            // Create another matrix with the same size as a & b
            Matrix c = new Matrix(this.width, this.height);
            for (int i = 0; i < c.width; i++)
                for (int j = 0; j < c.height; j++)
                    c.value()[i, j] = this.value()[i, j] + b.value()[i, j];
            return c;
        }

        public Matrix minus(Matrix b)
        {
            // Create another matrix with the same size as a & b
            Matrix c = new Matrix(this.width, this.height);
            for (int i = 0; i < c.width; i++)
                for (int j = 0; j < c.height; j++)
                    c.value()[i, j] = this.value()[i, j] - b.value()[i, j];
                   
            return c;
        }

        public Matrix mul(Matrix b)
        {
            // Create another matrix with the same size as a & b
            Matrix c = new Matrix(this.width, this.height);
            for (int i = 0; i < c.width; i++)
                for (int j = 0; j < c.height; j++)
                    c.value()[i, j] = this.value()[i, j] * b.value()[i, j];
            return c;
        }

    }
}
