// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetArray(int rows, int cols, int min, int max)
{
    int[,] arr = new int[rows, cols];
    // int maxTemp = max + 1;
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

int MinSum(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    int min = 0;
    int minStr = 0;
    for (int i = 0; i < cols; i++) min += array[0, i];
    
    for (int i = 1; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < cols; j++) sum += array[i, j];
    
        if (min > sum)
        {
            min = sum;
            minStr = i;
        }
    }
    return minStr + 1;
}

int sizeM = GetNum("Введите размер M: ");
int sizeN = GetNum("Введите размер N: ");

int[,] array = GetArray(sizeM, sizeN, 0, 9);
PrintArray(array);
int minStr = MinSum(array);
Console.WriteLine($"{minStr} строка c наименьшей суммой элементов");
