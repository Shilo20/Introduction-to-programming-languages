while (true)
{
    Console.WriteLine("введите целое число, сумма цифр которого четная. Для выхода нажмите \"q\"");
    string chislo = Console.ReadLine()+"";
    if(chislo=="q")
    {
        Console.WriteLine("ввели q");
        break;
    }
    
    if(int.TryParse(chislo, out int input))
    {
        int summa = Summ(input);
        if(summa%2==0)
        {
            Console.WriteLine("сумма равна " + summa);
            break;
        }
        else
        Console.WriteLine("Wrong number");

    }
    else
    {
        Console.WriteLine("Wrong input");
    }
}

int Summ(int chislo1)
{
    int summ=0;
    while (chislo1!=0)
    {
        summ += chislo1%10;
        chislo1/=10;
    }
    return summ;
}

