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
void ShowArray (string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] +" ");
    }
}
array = rebuildArray(array);
ShowArray(array);