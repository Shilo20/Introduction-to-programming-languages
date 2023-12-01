// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateArray()
{
    Random rand = new();
    int [,] array = new int [5,5];
    int rows = array.GetLength(0), columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j]=rand.Next(1,10);
        }
    }
    return array;
}

int[,] array = CreateArray();
int rows = array.GetLength(0);
int columns = array.GetLength(1);
int [] summasrtok = new int [rows];
for (int i = 0; i < rows; i++)
{
    int summstroki=0;
    for (int j = 0; j < columns; j++)
    {
        summstroki += array[i,j];
    }
    summasrtok[i] = summstroki;
}

int minstroka=summasrtok[0];
int minstrokaindex1=0;

for (int i = 0; i < summasrtok.Length; i++)
{
    if(minstroka>summasrtok[i])
    {
        minstroka=summasrtok[i];
        minstrokaindex1=i;
    }
    
}
Console.WriteLine(minstrokaindex1);