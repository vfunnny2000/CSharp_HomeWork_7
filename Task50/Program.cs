// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

// Console.WriteLine("Задайте двумерный массив m x n");
// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[m, n];

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = new Random().Next(0, 10);
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.Write("Введите позицию строки элемента: ");
// int posM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию столбца элемента: ");
// int posN = Convert.ToInt32(Console.ReadLine());
// if (posM < m && posN < n) {Console.WriteLine($"Значение элемента с индексом ({posM},{posN}) равно: {matrix[posM,posN]}");}
// else {Console.WriteLine("Такого элемента в массиве нет.");}




Console.WriteLine("Задайте двумерный массив m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.Write("Введите позицию строки элемента: ");
int posM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца элемента: ");
int posN = Convert.ToInt32(Console.ReadLine());
if (posM < m && posN < n) {Console.WriteLine($"Значение элемента с индексом ({posM},{posN}) равно: {matrix[posM,posN]}");}
else {Console.WriteLine("Такого элемента в массиве нет.");}


  static bool SearchArray (int soughtOutNum, int[,] searchableArray, out int rowIndex, out int colsIndex)
    {
        rowIndex = -1;
        colsIndex = -1;
        // Assuming your c is column and r is row
        for (int c = 0; c < searchableArray.GetLength(0); c++)
        {
            for (int r = 0; r < searchableArray.GetLength(1); r++)
            {
                if (searchableArray[r, c] == soughtOutNum)
                {
                    rowIndex = r;
                    colsIndex = c;
                    //Console.WriteLine("found number");
                    return true;
                }
            }
        }
        //Console.WriteLine("Number not found");
        return false;
    }






// working variant
// Console.WriteLine("Введите размеры массива");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
 
// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
// }
 
// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         Console.Write(array[i,j] + "\t  ");
//         Console.WriteLine();
// }
 
//  Console.WriteLine("Введите данные числа");
//  int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());
//  if (a>m && b>n)
//  Console.WriteLine("такого числа нет");
//  else
//  {
//  object c = array.GetValue(a,b);
//  Console.WriteLine(c);
//  }