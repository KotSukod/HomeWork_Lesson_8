// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] array = new int[4, 5];
int i = 0;
int min = 0;
int NumberLine = 0;
while (i < array.GetLength(0))//Создаем массив
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

i = 0;
while (i < array.GetLength(0))
{
    int j = 0;
    int sum = 0;
    while (j < array.GetLength(1))
    {
        sum = sum + array[i, j];
        j++;
    }
    Console.WriteLine($"Сумма {i+1} строки равна {sum}");
    if (i == 0)
    {
        min = sum;
        NumberLine = i + 1;
    }
    else if (sum < min)
    {
        min = sum;
        NumberLine = i + 1;
    }
    i++;
    
}
Console.WriteLine($"Строка {NumberLine } имеет наименьшую сумму элементов");
