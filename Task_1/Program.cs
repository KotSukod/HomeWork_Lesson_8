// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] array = new int[5, 5];
int i = 0;

int[] Metod(int[] Array)
{

    int i = 0;
    while (i < Array.Length)
    {
        int j = 0;
        while (j < Array.Length)
        {
            if (Array[i] > Array[j])
            {
                int help = 0;
                help = Array[i];
                Array[i] = Array[j];
                Array[j] = help;
            }

            j++;
        }
        i++;
    }
    return Array;
}
Console.WriteLine("Было");
while (i < array.GetLength(0))
{
    int j = 0;
    while (j < array.GetLength(1))
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
        j++;
    }
    Console.WriteLine();
    i++;
}
Console.WriteLine("Стало");
i = 0;
while (i < array.GetLength(0))
{
    int j = 0;
    int[] help = new int[array.GetLength(1)];
    while (j < array.GetLength(1))
    {
        help[j] = array[i, j];
        j++;
    }
    Metod(help);
    j = 0;
    while (j < array.GetLength(1))
    {
        array[i, j] = help[j];
        Console.Write($"{array[i, j]} ");
        j++;
    }
    Console.WriteLine();
    i++;
}