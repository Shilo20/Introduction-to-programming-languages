string str = "w1pw";
int l=str.Length;
bool flag = true;
for (int i = 0; i < l/2; i++)
{
    if(str[i]!=str[l-i-1])
    {
        Console.WriteLine("!=polyndrom");
        flag=false;
        break;
    }
}
if(flag)
    Console.WriteLine("==polyndrom");