// //Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.



double [] massive = new double [20];

void FillingMassive(double [] arraychik)
{
    int l = arraychik.Length;
    for(int i =0; i< l ; i++)
    {
        arraychik[i]=GetRandomDouble(1,10);
    }
}

double GetRandomDouble(double mindb, double maxdb)
{ 
    Random random = new Random();
    return random.NextDouble() * (maxdb - mindb) + mindb;
}

double DifferenceMaxMin(double [] array)
{
    int l = array.Length;
    double min=array[0], max=array[0];
    for(int i =0; i<l;i++)
    {
        if(array[i]<min)
        {
            min=array[i];
        }
        else if(array[i]>max)
        {
            max=array[i];
        }
    }
    return max-min;
}

FillingMassive(massive);
Console.WriteLine(DifferenceMaxMin(massive));