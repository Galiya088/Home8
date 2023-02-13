// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetArray(int rows, int cols, int min, int max)
{
    int[,] arr = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    return arr;
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(String.Format("{0,3} ", array[i, j]));
        }
        Console.WriteLine();
    }
}

int[,] ConArray(int[,] arrayA, int[,] arrayB)
{
    int rowsA = arrayA.GetLength(0);
    int colsA = arrayA.GetLength(1);
    int rowsB = arrayB.GetLength(0);
    int colsB = arrayB.GetLength(1);

    int[,] result = new int[rowsA, colsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < colsB; j++)
        {
            for (int k = 0; k < colsA; k++)
                result[i, j] += arrayA[i, k] * arrayB[k, j];
        }
    }
    return result;
}

int sizeMA = GetNum("Введите размер M1: ");
int sizeNA = GetNum("Введите размер N1: ");
int sizeMB = GetNum("Введите размер M2: ");
int sizeNB = GetNum("Введите размер N2: ");

int[,] arrayA = GetArray(sizeMA, sizeNA, 0, 9);
int[,] arrayB = GetArray(sizeMB, sizeNB, 0, 9);

PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
int[,] arrayCon = ConArray(arrayA, arrayB);
Console.WriteLine();
PrintArray(arrayCon);


