using System.Collections;
using System.Linq.Expressions;

int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };

void Programm(int[,] array, string str = "", int len = -1, int i = 0)
{
    if (str != "")
    {
        if (len == -1)
        {
            len = str.Length;
        }
        if (i < len)
        {
            Console.Write(str[len - i -1] + "\t");
            i++;
            Programm(array, str, len, i);
        }
    }
    else
    {
        foreach (int j in array)
        {
            str += j;
        }
        Programm(array, str);
    }


}

Programm(array);


