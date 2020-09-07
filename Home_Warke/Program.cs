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
                    matrix[i, d] = Rand(2, 20);
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
                Console.WriteLine("матрицы подходят только для умножения на число");
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
            int stolb = matrix.GetLength(0);
            int stroka = matrix.GetLength(1);
            int[,] resultMatrix = new int[stolb, stroka];
            for (int i = 0; i < stolb; i++)
            {
                for (int d = 0; d < stroka; d++)
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
            int stolb = matrix.GetLength(0);
            int stroka = matrix.GetLength(1);
            int[,] resultMatrix = new int[stolb, stroka];
            for (int i = 0; i < stolb; i++)
            {
                for (int d = 0; d < stroka; d++)
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
            int stolb = matrix.GetLength(0);
            int stroka = matrix.GetLength(1);
            int[,] resultMatrix = new int[stolb, stroka];
            for (int i = 0; i < stolb; i++)
            {
                for (int d = 0; d < stroka; d++)
                {
                    resultMatrix[i, d] = matrix[i, d] - matrix2[i, d];
                }
            }

            return resultMatrix;
        }
        /// <summary>
        /// Метод перемножения матриц
        /// в случае не соблюдения правил умножения матриц вернеться Null масив
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        static int[,] MatrixMult(int[,] matrix, int[,] matrix2)
        {
            int stolb2 = matrix2.GetLength(1);
            int stolb = matrix.GetLength(1);
            int stroka = matrix.GetLength(0);
            int stroka2 = matrix2.GetLength(0);
            int[,] matrixResult = new int[stroka, stolb2];
            int[,] nullMatrix = new int[1, 1];
            if (stolb == stroka2)
            {
                for (int i = 0; i < stroka; i++)
                {
                    for (int d = 0; d < stolb2; d++)
                    {
                        for (int p = 0; p < stolb; p++)
                        {
                            matrixResult[i, d] += matrix[i, p] * matrix2[p, d];
                        }
                    }
                }
                return matrixResult;
            }
            else
            {
                return nullMatrix;
            }
        }

        static void Main()
        {
            //int[,] resultMatrix = MatrixMultNumb(RecMatrix(3, 2), 4);
            //int[,] resultMatrix2 = MatrixEd(resultMatrix, RecMatrix(3, 2));
            //int[,] resultMatrix3 = MatrixSub(resultMatrix2, RecMatrix(3, 2));
            //ChekMatrix(RecMatrix(3, 5), RecMatrix(2, 3));
            //Console.ReadKey();
            //MatrixMult(RecMatrix(3, 5), RecMatrix(2, 3));
            //PrintMatrix(resultMatrix2);
            int[,] r1 = RecMatrix(2, 1);
            int[,] r2 = RecMatrix(1, 3);
            PrintMatrix(r1);
            Console.WriteLine();
            PrintMatrix(r2);
            ChekMatrix(r1, r2);
            int[,] r3 = MatrixMult(r1, r2);
            Console.WriteLine();
            PrintMatrix(r3);
        }
    }
}
