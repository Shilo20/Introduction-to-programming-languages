// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.

// Пример

// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] = 4 => [6 18 5 7] (элемент 7 не имеет пары)

void SummFirstLast(int[] array)
{
    int oldlenth= array.Length;
    int length = array.Length;
    if(length%2==1)
        {
            length++;
        }
    int[] array1 = new int [length/2];
    Console.WriteLine("умножение");
    for(int i=0; i<length/2; i++) //здесь не разделили на 2
    {
        if(array[i]==array[oldlenth-i-1]) //проверте условие
        {
            array1[i]=array[i];
            Console.Write(array1[i]+"\t");
            continue;
        }
        array1[i]=array[i] * array[oldlenth-i-1];
        Console.Write(array1[i]+"\t");
    }
    Console.WriteLine();
}

int[] test = new int [new Random().Next(4, 9)];
Console.WriteLine("length = " + test.Length);
for(int i = 0; i < test.Length; i++)
{
    test[i]= new Random().Next(0, 9);
    Console.Write(test[i] + "\t");
}
Console.WriteLine();
SummFirstLast(test);