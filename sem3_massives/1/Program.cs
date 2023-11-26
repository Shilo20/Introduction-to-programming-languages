void FillArray(int [] array)
{
    int l = array.Length;
    for(int i=0; i<l; i++)
    {
        array[i]= new Random().Next(1,100);
        Console.WriteLine(array[i]);
    }
}

void ElOfMass(int [] array)
{
    int l = array.Length;
    int numberofel=0;

    for(int i=0; i<l; i++)
    {
        if(array[i]>20&&array[i]<90)
            {
                numberofel++;
            }
        else
        continue;
    }
    Console.WriteLine(numberofel);
}

int [] massive = new int [10];
FillArray(massive);
ElOfMass(massive);