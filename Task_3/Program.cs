// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
using System.Diagnostics.CodeAnalysis;

int[,] array1 = new int[3, 3];
int[,] array2 = new int[3, 3];
int[,] GreatArray(int [,]Array)
{
    int i = 0;
    while (i < Array.GetLength(0))
    {
        int j = 0;
        while (j < Array.GetLength(1))
        {
            Array[i, j] = new Random().Next(1, 5);
            Console.Write($"{Array[i, j]} ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
 return Array;
}
array1 = GreatArray(array1);
Console.WriteLine();
array2 = GreatArray(array2);

int i = 0;

int[,] result = new int[array1.GetLength(0),array1.GetLength(1)];
while (i<array1.GetLength(0))
{
    int j = 0;
    int[] help = new int[array1.GetLength(0)];
    while (j < array1.GetLength(1))
    {
        help[j] = array1[i, j];
        j++;
    }
    int k = 0;
    while (k < array2.GetLength(1))
    {
        int l = 0;
        int sum = 0;
        while (l < array2.GetLength(0))
        {
            sum = sum + (help[l] * array2[l,k]);
            l++;
        }
        result[i, k] = sum;
        Console.Write($"{result[i,k]} ");
        k++;
        
    }
    
    i++;
    Console.WriteLine();
}
Console.ReadLine();