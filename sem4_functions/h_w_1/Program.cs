while(true)
{
    string chislo;
    Console.WriteLine("Введите ПОЛОЖИТЕЛЬНОЕ целое число, сумма цифр которого четная. Для остановки нажмите \"q\"");
    chislo = Console.ReadLine();
    if(chislo.ToLower() == "q")
    {
        Console.WriteLine("input is q");
        break;
    }

    if(chislo.Length==0)
    {
        Console.WriteLine("Wrong input");
        continue;
    }

    int summ = SummEl(chislo);
    if(summ==-1)
    {
        Console.WriteLine("Wrong input");
    }
    else if (summ%2==0)
    {
        Console.WriteLine("summ = " + summ + " sucsess!!!");
        break;
    }
    else
        Console.WriteLine("wrong number try again");

    
}
int SummEl(string input)
{
    int l = input.Length;
    int summ=0;
    for(int i=0; i<l; i++)
    {
        int iarg = Convert.ToInt32(input[i]);
        if(iarg<46 || iarg>57)
        {
            return -1;
        }
        summ += iarg - 48;
    }
    return summ;
}

// string input = Console.ReadLine();

//     int l = input.Length;
//     int summ=0;
//     for(int i=0; i<l; i++)
//     {
//         int iarg = Convert.ToInt32(input[i]);
//         if(iarg<48 || iarg>57)
//         {
//             summ = -1;
//             break;
//         }
//         summ += iarg - 48;
//     }
// Console.WriteLine(summ);