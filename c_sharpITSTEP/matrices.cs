//using System;

//public class SquareMatrix
//{
//    public int[,] Matrix { get; private set; }
//    public int Size { get; private set; }

//    public SquareMatrix(int[,] matrix)
//    {
//        if (matrix.GetLength(0) != matrix.GetLength(1))
//            throw new ArgumentException("Matrix must be square.");

//        Matrix = matrix;
//        Size = matrix.GetLength(0);
//    }

//    public static SquareMatrix operator +(SquareMatrix a, SquareMatrix b)
//    {
//        if (a.Size != b.Size)
//            throw new ArgumentException("Matrices must be of the same size.");

//        int[,] result = new int[a.Size, a.Size];
//        for (int i = 0; i < a.Size; i++)
//        {
//            for (int j = 0; j < a.Size; j++)
//            {
//                result[i, j] = a.Matrix[i, j] + b.Matrix[i, j];
//            }
//        }

//        return new SquareMatrix(result);
//    }

//    public static SquareMatrix operator -(SquareMatrix a, SquareMatrix b)
//    {
//        if (a.Size != b.Size)
//            throw new ArgumentException("Matrices must be of the same size.");

//        int[,] result = new int[a.Size, a.Size];
//        for (int i = 0; i < a.Size; i++)
//        {
//            for (int j = 0; j < a.Size; j++)
//            {
//                result[i, j] = a.Matrix[i, j] - b.Matrix[i, j];
//            }
//        }

//        return new SquareMatrix(result);
//    }

//    public void Print()
//    {
//        for (int i = 0; i < Size; i++)
//        {
//            for (int j = 0; j < Size; j++)
//            {
//                Console.Write($"{Matrix[i, j]} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
//        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };

//        SquareMatrix m1 = new SquareMatrix(matrix1);
//        SquareMatrix m2 = new SquareMatrix(matrix2);

//        SquareMatrix sum = m1 + m2;
//        SquareMatrix difference = m1 - m2;

//        Console.WriteLine("Матрица 1:");
//        m1.Print();

//        Console.WriteLine("Матрица 2:");
//        m2.Print();

//        Console.WriteLine("Сумма:");
//        sum.Print();

//        Console.WriteLine("Разность:");
//        difference.Print();

//        Console.ReadLine();
//    }
//}
