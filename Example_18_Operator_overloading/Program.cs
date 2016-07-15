using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_18_Operator_overloading
{
    class Matrix
    {
        private int[,] _matrix;
        private int _size;

        public Matrix(int size)
        {
            _matrix = new int[size, size];
        }

        public int this[int x, int y]
        {
            get 
            {
                return _matrix[x, y];
            }
            set
            {
                _matrix[x, y] = value;
            }
        }

        public static Matrix operator +(Matrix matr1, Matrix matr2)
        {
            Matrix resultMatrix = new Matrix(2);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resultMatrix[i, j] = matr1[i, j] + matr2[i, j];
                }
            }
            return resultMatrix;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new Matrix(2);
            var matrix2 = new Matrix(2);

            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 4;

            matrix2[0, 0] = 5;
            matrix2[0, 1] = 6;
            matrix2[1, 0] = 7;
            matrix2[1, 1] = 8;

            var matrix3 = matrix1 + matrix2;

            Console.WriteLine(matrix3[1, 1]);
            Console.ReadLine();
        }
    }
}
