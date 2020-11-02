using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLibrary
{
    public class MyMatrix
    {
        protected int[,] Matr;

        public MyMatrix(int rowCount, int columnCount)
        {
            Matr = new int[rowCount, columnCount];
        }

        public int[,] GetMatrix()
        {
            return Matr;
        }

        public void FillRandomNumbers(int minValue = -100, int maxValue = 200)
        {
            Random rnd = new Random();
            for (int i = 0; i < Matr.GetLength(0); i++)
                for (int j = 0; j < Matr.GetLength(1); j++)
                    Matr[i, j] = rnd.Next(minValue, maxValue);
        }

        public int CountPositiveElements()
        {
            int count = 0;
            for (int i = 0; i < Matr.GetLength(0); i++)
                for (int j = 0; j < Matr.GetLength(1); j++)
                    if (Matr[i, j] > 0)
                        count += 1;

            return count;
        }

        public int MoreOneMaximumNumbers(ref int count)
        {
            int max = Int32.MinValue;
            int index_i = 0, index_j = 0;
            int iterationNumber = 1, nxm = Matr.GetLength(0) * Matr.GetLength(1);
            while (count == 1 && iterationNumber <= nxm)
            {
                for (int i = 0; i < Matr.GetLength(0); i++)
                    for (int j = 0; j < Matr.GetLength(1); j++)
                    {
                        if (Matr[i, j] > max)
                        {
                            max = Matr[i, j];
                            count = 1;
                            index_i = i;
                            index_j = j;
                        }
                        else if (Matr[i, j] == max)
                            count += 1;
                    }
                if (count == 1)
                {
                    Matr[index_i, index_j] = Int32.MinValue;
                    max = Int32.MinValue;
                }
                iterationNumber++;
            }

            return max;
        }

        public int CountColumnsWithoutZeros()
        {
            int count = 0, countZero;
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                countZero = 0;
                for (int j = 0; j < Matr.GetLength(1); j++)
                    if (Matr[i, j] == 0)
                        countZero += 1;
                if (countZero == 0)
                    count += 1;
            }

            return count;
        }

        public int CountRowsWithZeros()
        {
            int count = 0, countZero;
            for (int i = 0; i < Matr.GetLength(1); i++)
            {
                countZero = 0;
                for (int j = 0; j < Matr.GetLength(0); j++)
                    if (Matr[j, i] == 0)
                        countZero += 1;
                if (countZero != 0)
                    count += 1;
            }

            return count;
        }

        public int NumberRowMaxIdenticalElements()
        {
            int num = -1, countM = -1, countR, count = -1;
            int number;
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                    number = Matr[i, j];
                    countR = 0;
                    for (int k = 0; k < Matr.GetLength(1); k++)
                    {
                        if (Matr[i, k] == number)
                            countR += 1;
                    }
                    if (countR > count && countR > 1)
                        count = countR;
                }
                if (count > countM)
                {
                    countM = count;
                    num = i;
                }
            }

            return num;
        }

        public int[] MultiplicationRowsWithoutNegativeElements(ref int countRowsNegativeElements)
        {
            int[] multiArr = new int[Matr.GetLength(0)];
            int countNegativeElements;
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                multiArr[i] = -1;
                countNegativeElements = 0;
                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                    if (Matr[i, j] < 0)
                        countNegativeElements += 1;
                }
                if (countNegativeElements == 0)
                {
                    multiArr[i] = 1;
                    for (int j = 0; j < Matr.GetLength(1); j++)
                        multiArr[i] *= Matr[i, j];
                }
                else
                    countRowsNegativeElements += 1;
            }

            return multiArr;
        }

        public int MaxSumsDiagonalsParallelMain()
        {
            int maxSum = Int32.MinValue, suma, index, start;
            int m = Matr.GetLength(0);
            int n = Matr.GetLength(1);

            for (int i = 1; i < m; i++)
            {
                suma = 0;
                index = i;
                for (int j = 0; j < n; j++)
                {
                    suma += Matr[index, j];
                    index += 1;
                    if (index >= m)
                        break;
                }
                if (suma > maxSum)
                    maxSum = suma;
            }

            for (int i = 0; i < n - 1; i++)
            {
                suma = 0;
                start = n - i - 1;
                index = 0;
                for (int j = start; j < n; j++)
                {
                    suma += Matr[index, j];
                    index += 1;
                    if (index >= m)
                        break;
                }
                if (suma > maxSum)
                    maxSum = suma;
            }

            return maxSum;
        }

        public int[] SumColumnsDoNotNegativeElements(ref int countColumnsNegativeElements)
        {
            int[] sumArr = new int[Matr.GetLength(1)];
            int countNegativeElements;
            for (int i = 0; i < Matr.GetLength(1); i++)
            {
                sumArr[i] = -1;
                countNegativeElements = 0;
                for (int j = 0; j < Matr.GetLength(0); j++)
                {
                    if (Matr[j, i] < 0)
                        countNegativeElements += 1;
                }
                if (countNegativeElements == 0)
                {
                    sumArr[i] = 0;
                    for (int j = 0; j < Matr.GetLength(0); j++)
                        sumArr[i] += Matr[j, i];
                }
                else
                    countColumnsNegativeElements += 1;
            }

            return sumArr;
        }

        public string[] CalculateSumColumnsNegativeElement(ref int countColumnsNegativeElements)
        {
            string[] sumArr = new string[Matr.GetLength(1)];
            int countNegativeElements;
            for (int i = 0; i < Matr.GetLength(1); i++)
            {
                sumArr[i] = "*";
                countNegativeElements = 0;
                for (int j = 0; j < Matr.GetLength(0); j++)
                {
                    if (Matr[j, i] < 0)
                        countNegativeElements += 1;
                }
                if (countNegativeElements > 0)
                {
                    sumArr[i] = 0.ToString();
                    for (int j = 0; j < Matr.GetLength(0); j++)
                        sumArr[i] = (Convert.ToInt32(sumArr[i]) + Matr[j, i]).ToString();
                }
                else
                    countColumnsNegativeElements += 1;
            }

            return sumArr;
        }

        public int MinSumsModulesElementsDiagonalsParallelLateral()
        {
            int minSum = Int32.MaxValue, suma, index, start;
            int m = Matr.GetLength(0);
            int n = Matr.GetLength(1);

            for (int i = 0; i < n - 1; i++)
            {
                suma = 0;
                index = 0;
                start = i;
                for (int j = start; j > -1; j--)
                {
                    suma += Math.Abs(Matr[index, j]);
                    index += 1;
                    if (index >= m)
                        break;
                }
                if (suma < minSum)
                    minSum = suma;
            }

            for (int i = 1; i < m; i++)
            {
                suma = 0;
                index = i;
                start = n - 1;
                for (int j = start; j > -1; j--)
                {
                    suma += Math.Abs(Matr[index, j]);
                    index += 1;
                    if (index >= m)
                        break;
                }
                if (suma < minSum)
                    minSum = suma;
            }

            return minSum;
        }

        public int[,] TransposeMatrix()
        {
            int[,] transposeMatrix = new int[Matr.GetLength(1), Matr.GetLength(0)];
            for (int i = 0; i < Matr.GetLength(0); i++)
                for (int j = 0; j < Matr.GetLength(1); j++)
                    transposeMatrix[j, i] = Matr[i, j];

            return transposeMatrix;
        }
    }
}
