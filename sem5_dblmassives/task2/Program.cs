//смена 1 и последней строки

static int[,] CreateArray()
{
    Random rand = new();
    int [,] array = new int [rand.Next(0,10), rand.Next(0,10)];
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

static int[,] PrintArray(int[,] array)
{   
    int rows=array.GetLength(0);
    int columns=array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
    return array;
}

int[,] array = CreateArray();
PrintArray(array);
Console.WriteLine();
int rows=array.GetLength(0);
int columns=array.GetLength(1);
int[] semiarray= new int [columns];
for (int i = 0; i < columns; i++)
{
    semiarray[i] = array[0,i];
}
for (int i = 0; i < columns; i++)
{
    array[0,i] = array[rows-1,i];
}
for (int i = 0; i < columns; i++)
{
    array[rows-1,i] = semiarray[i];
}

PrintArray(array);