
using System.Reflection.Metadata.Ecma335;

int[] Create_FillArray()
{
    int[] array = new int [new Random().Next(2, 10)];
    int len = array.Length;
    for(int i=0; i<len; i++)
    {
        array[i]=new Random().Next(-999,999);
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
    return array;
}

void KlvoCetn(int[] massive)
{
    int len = massive.Length;
    int kolvo=0;
    for(int i=0; i<len; i++)
    {
        if(massive[i]%2==0)
            kolvo++;
        else
            continue;
    }
    Console.WriteLine(kolvo);
}

KlvoCetn(Create_FillArray());


