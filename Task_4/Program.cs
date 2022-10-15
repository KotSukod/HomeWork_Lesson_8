// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int Metod(int [,,]Array,int x)
{
     int i = 0;
     int result = 0;
    while (i < Array.GetLength(0))
    {
        int j = 0;
        while (j < Array.GetLength(1))
        {
            int k = 0;
            while (k < Array.GetLength(2))
            {
                if (x == Array[i,j,k])
                    {
                        result = 1;
                    }
                
                k++;
            }
            j++;
        }
        i++;
    }
    return result;
}
int[,,] array1 = new int[2,2,2];
int[,,] GreatArray(int [,,]Array)
{
    int i = 0;
    while (i < Array.GetLength(0))
    {
        int j = 0;
        while (j < Array.GetLength(1))
        {
            int k = 0;
            int l = 0;
            int help = 0;
            while (k < Array.GetLength(2))
            {
                l = new Random().Next(10,100);
                help = Metod(array1,l);
                if (help == 0) 
                {
                    Array[i,j,k] = l;
                    Console.Write($"{Array[i, j, k]} ({i},{j},{k}) ");
                    k++;
                }               
                 
                
            }
             Console.WriteLine();
            j++;
        }
        Console.WriteLine();
        i++;
    }
 return Array;
}


array1 = GreatArray(array1);