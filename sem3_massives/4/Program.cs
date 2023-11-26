int chislo = 0;//new Random().Next(1,100000);
Console.WriteLine("chislo = "+chislo);

int length = chislo.ToString().Length;
int [] mchislo = new int [length];

for(int i = 0; i<length; i++)
{
    int curnumb = (chislo % Convert.ToInt32 (Math.Pow(10, length-i))) / Convert.ToInt32 (Math.Pow(10,length-i-1));
    
    mchislo[i]=curnumb;
    Console.WriteLine("mchislo = "+mchislo[i]);
}




