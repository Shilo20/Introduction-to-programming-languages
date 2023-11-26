int [] array = new int [10];
FillArray(array);
KolvChetn(array);





void FillArray(int[] massive)
{
    int length = massive.Length;
    for(int i=0; i<length; i++)
    {
        massive[i] = new Random().Next(0,10);
    }
}
void KolvChetn(int [] massvivchik)
 {
    int kolvoChetn=0;
    int length = massvivchik.Length;
    for(int i=0; i<length; i++)
    {
        if(massvivchik[i]%2==0)
        {
            kolvoChetn++;
        }
        else
        continue;
    }
    Console.WriteLine(kolvoChetn);
 }