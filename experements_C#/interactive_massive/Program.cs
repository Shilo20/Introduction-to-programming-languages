using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;

static int [] Initialization()
{
    // bool flag = true;
    while (true)
    {
        Console.WriteLine("Press 1 to create random massive and 2 to create massive by ur hands");
        if(int.TryParse(Console.ReadLine(), out int command1))                  // поппробовать реализовать через case
        {
            if(command1 == 1)
            {
                Console.WriteLine("Введите размер массива");
                if(int.TryParse(Console.ReadLine(), out int command2))
                {
                    int [] aaa = CreateRandom(command2);
                    return aaa;
                }
                else
                {
                    Console.WriteLine("Fine, start from beginning... baka");
                }
            }
            else if(command1==2)
            {
                Console.WriteLine("You choosed the difficult way. Write numbers threw space.");
                int [] handmade = CreateByHands();
                if(handmade[0]!=-1)
                    return handmade;
                else
                    Console.WriteLine("debil");
            }
            else
            {
                Console.WriteLine("Baka, read task, all from the beginning");
            }
        }
        else
        {
            Console.WriteLine("Baka, read task");
        }   
    }
}

static int [] CreateRandom(int size)
{
    int [] massive = new int [size];
    for (int i = 0; i < size; i++)
    {
        massive[i]=new Random().Next(1,10);
    }
    return massive;
}

static void PrintArray(int [] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {

        Console.Write(i + " = " + array[i] + "\t");
    }
}

static int [] CreateByHands()
{
    Console.WriteLine("Введите числа для заполнения массива через пробел");
    string[] command3 = Console.ReadLine().Split(' ');
    int length = command3.Length;
    int [] array = new int [length];
    array[0]=-1;
    for (int i = 0; i < length; i++)
    {
        if(int.TryParse(command3[i],out int ii))
        {
            array[i]=ii;
        }
        else
        {
            Console.WriteLine("baka...");
            return array;
        }
    }
    return array;
}

PrintArray(Initialization());

void main()
{
    int [] array = Initialization();
    int index=0;
    PrintArray(array);
    while (true)
    {
        Console.WriteLine("Выберете действие:");
        Console.WriteLine("1-выбрать индекс массива, 2-изменить содержание индекса, 3 для выхода");
        int command4 = int.Parse(Console.ReadLine()+"");

        if(command4==1)
        {
            index=int.Parse(Console.ReadLine()+"");
        }
        else if(command4==2)
        {
            Console.WriteLine("Введите число");
            array[index]=int.Parse(Console.ReadLine()+"");
            PrintArray(array);
        }
        else if (command4==3)
        {
            break;
        }
        else
        {
            Console.WriteLine("baaaaaaaaaka");
        }
    }
}

main();