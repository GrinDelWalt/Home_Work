using System;
using System.Diagnostics;
using System.Linq;

namespace Home_Warke
{
    class Program
    {
        /// <summary>
        /// Вывод в консоль матриц
        /// </summary>
        /// <param name="matrix"></матрица>
        /// <returns></returns>
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int d = 0; d < matrix.GetLength(1); d++)
                {
                    Console.Write($"{matrix[i, d]}  ");
                }
                Console.WriteLine();
            }
            
        }
        /// <summary>
        /// Генератор случайных чисел
        /// </summary>
        /// <param name="r"></число от>
        /// <param name="z"></число до>
        /// <returns></returns>
        static int Rand(int r, int z)
        {
            Random rand = new Random();
            return rand.Next(r, z);
        }
        /// <summary>
        /// Генерация Матриц
        /// </summary>
        /// <param name="a"></количество столбцов>
        /// <param name="b"></количество строк>
        /// <returns></returns>
        static int[,] RecMatrix(int a, int b)
        {

            int[,] matrix = new int[b, a];
            for (int i = 0; i < b; i++)
            {
                for (int d = 0; d < a; d++)
                {
                    matrix[i, d] = Rand(10, 20);
                }
            }
            
            return matrix;
        }
        /// <summary>
        /// Проверка матриц на равноразмерность или согласованность
        /// </summary>
        /// <param name="matrix"></количество столбцов>
        /// <param name="matrix2"></количество строк>
        static void ChekMatrix(int[,] matrix, int[,] matrix2)
        {
            if (matrix.GetLength(0) == matrix2.GetLength(0) && matrix.GetLength(1) == matrix2.GetLength(1))
            {
                Console.WriteLine("матрицы равноразмерные");
            }
            else if (matrix.GetLength(1) == matrix2.GetLength(0))
            {
                Console.WriteLine("матрицы согласованны");
            }
            else
            {
                Console.WriteLine("матрицы подходят только для унажения на число");
            }
        }
        /// <summary>
        /// Умножение матрицы на число
        /// </summary>
        /// <param name="a"></Количество столбцов>
        /// <param name="b"></Колличество строк>
        /// <param name="m"></Число>
        static int[,] MatrixMultNumb(int[,] matrix, int m)
        {
            int[,] resultMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int d = 0; d < matrix.GetLength(1); d++)
                {
                    resultMatrix[i,d] = matrix[i, d] * m;
                }
            }
            return resultMatrix;
        }
        /// <summary>
        /// Сложение матриц
        /// </summary>
        static int[,] MatrixEd(int[,] matrix, int[,] matrix2)
        {
            int[,] resultMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int d = 0; d < matrix.GetLength(1); d++)
                {
                    resultMatrix[i, d] = matrix[i, d] + matrix2[i, d];
                }
            }

            return resultMatrix;
        }
        /// <summary>
        /// Вычитание матриц
        /// </summary>
        static int[,] MatrixSub(int[,] matrix, int[,] matrix2)
        {
            int[,] resultMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int d = 0; d < matrix.GetLength(1); d++)
                {
                    resultMatrix[i, d] = matrix[i, d] - matrix2[i, d];
                }
            }

            return resultMatrix;
        }
        /// <summary>
        /// Перемножение матриц
        /// </summary>
        /// <param name="x"></Количество столбцов матрицы 1>
        /// <param name="z"></Количество строк матрицы 1>
        /// <param name="v"></Количество столбцов матрицы 2>
        /// <param name="c"></Количество строк матрицы 2>
        static int[,] MatrixMult(int[,] matrix, int[,] matrix2)
        {
            

            int[,] matrixResult = new int[matrix.GetLength(0), matrix2.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int d = 0; d < matrix2.GetLength(1); d++)
                {
                    for (int p = 0; p < matrix.GetLength(1); p++)
                    {
                        matrixResult[i, d] += matrix[i, p] * matrix2[p, d];
                    }
                }
            }
            
            return matrixResult;
        }

        static void Main()
        {
            int[,] resultMatrix = MatrixMultNumb(RecMatrix(3, 2), 4);
            int[,] resultMatrix2 = MatrixEd(resultMatrix, RecMatrix(3, 2));
            int[,] resultMatrix3 = MatrixSub(resultMatrix2, RecMatrix(3, 2));
            ChekMatrix(resultMatrix, resultMatrix2);
            MatrixMult(RecMatrix(3, 5), RecMatrix(2, 3));
            PrintMatrix(resultMatrix3);

        }
    }
}
