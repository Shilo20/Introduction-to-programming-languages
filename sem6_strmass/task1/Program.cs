char [,] array = {{'a','b','c'}, {'a','b','c'}};
string str = "";
foreach (char i in array)
{
    str+=i;
}
Console.WriteLine(str);