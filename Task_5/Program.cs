// Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] array = new int[4,4];
int i = 0;
int j = 0;
int number = 1;
for (j = 0; j < array.GetLength(1); j++)
{
    array[i,j] = number;
    number++;
}
j =j - 1;
for(i = 1; i < array.GetLength(0); i++)
{
    array[i,j] = number;
    number++;
}
i = i-1;
for(j = j - 1;j >= 0; j--)
{
    array[i,j] = number;
    number++;
}
j =j +1;
for (i = i-1; i >= 1; i--)
{
        array[i,j] = number;      
        number++;
}
i = i + 1;
for(j=j +1; j < array.GetLength(1); j++)
{
    if (array[i,j] == 0 )
    {
        array[i,j] = number;
        number++;
    }
    else if (array[i,j] !=0) break;
}   
j = j-1;
for (i = i+1; i< array.GetLength(0); i++)
{
    if (array[i,j] == 0 )
    {
        array[i,j] = number;
        number++;
    }
    else if (array[i,j] !=0) break;
}
i = i-1;
for (j = j-1; j< array.GetLength(1); j--)
{
    if (array[i,j] == 0 )
    {
        array[i,j] = number;
        number++;
    }
    else if (array[i,j] !=0) break;
}
i = 0;
while (i < array.GetLength(0))
{
    j = 0;
    while(j < array.GetLength(1))
    {
        Console.Write($"{array[i,j]} ");
        j++;
    }
    Console.WriteLine();
    i++;
}
