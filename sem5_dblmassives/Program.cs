// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System.Net;

int[,] CreateArray()
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

static void brain(int[,] array, int x, int y)
{
    int rows = array.GetLength(0), columns = array.GetLength(1);
    if (x<columns && y<rows)
    {
        Console.WriteLine("x = " + x + " y = " + y + " searching element = " + array[y,x]);
    }
    else
        Console.WriteLine("wrong input");
}

void main()
{
    int[,] array = CreateArray();
    while (true)
    {
        Console.WriteLine("Введите x и y через пробел или \"q\" для выхода");
        string[] Read = Console.ReadLine().Split(' ');
        if(Read.Length==2)
        {
            if (int.TryParse(Read[0], out int x)) {}
            else
            {
                Console.WriteLine("wrong input"); 
                continue;
            }
            if (int.TryParse(Read[1], out int y)) {}
            else
            {
                Console.WriteLine("wrong input"); 
                continue;
            }
            brain(array,x,y);
        }
        else if(Read.Length==1)
            break;
        else
        {
            Console.WriteLine("wrong input"); 
            continue;
        }
    }
}

main();

