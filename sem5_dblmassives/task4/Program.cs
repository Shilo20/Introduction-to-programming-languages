//Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
//Под удалением понимается создание нового двумерного массива без строки и столбца.

int[,] CreateArray()
{
    // int rows = 3, columns = 3;
    // int[,] array = new int[rows,columns];
    // Random rand = new();
    // for (int i = 0; i < rows; i++)
    // {
    //     for (int j =0; j < columns; j++)
    //     {
    //         array[i,j] = rand.Next(0, 10);
    //     }
    // }
    int[,] array = {{9,8,7},{6,5,4},{7,8,0}};
    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0), columns = array.GetLength(0);
    for (int i = 0; i < rows; i++)
    {
        for (int j =0; j < columns; j++)
        {
            Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindMinChlen(int[,] array, out int imin, out int jmin)
{
    int rows = array.GetLength(0), columns = array.GetLength(0);
    int minchlen = array[0,0];
    imin = 0;
    jmin = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j =0; j < columns; j++)
        {
            if (array[i,j]<minchlen)
            {
                minchlen = array[i,j];
                imin = i;
                jmin = j;
            }
            else
                continue;
        }
    }
}

int[,] CreateNewArray(int[,] array, int imin, int jmin)
{
    int rows = array.GetLength(0)-1, columns= array.GetLength(1)-1;
    int[,] massive = new int[rows,columns];
    for (int i = 0, i1=0; i < rows; i++,i1++)
    {
        if (i==imin)
        {
            i1++;
        }
        for (int j = 0,j1=0; j < columns; j++,j1++)
        {
            if (j==jmin)
            {                  
                j1++;
            }
            massive[i,j] = array[i1,j1];              
        }    
    }
    return massive;
}

void main()
{
    int [,] array = CreateArray();
    PrintArray(array);
    FindMinChlen(array, out int imin, out int jmin);
    int[,] massive = CreateNewArray(array, imin, jmin);
    PrintArray(massive);
}

main();