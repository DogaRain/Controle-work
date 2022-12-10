string[] array;
Console.WriteLine("Введите массив строк через пробел");
var stroka = Console.ReadLine();
array = stroka.Split(' ');

string[] rebuildArray(string[] array)
{
    string[] result = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
        result[j] = array[i];
        j++;
        }
    }
    return result;
    
}