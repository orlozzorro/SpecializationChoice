// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string[] NewArray(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) j++;
    }
    string[] newArray = new string[j];
    j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }

    return newArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

string[] str = { "Hello", "2", "world", ":-)" };
System.Console.WriteLine("Исходный массив");
PrintArray(str);
System.Console.WriteLine("Новый массив, с элементами меньше 3:");
PrintArray(NewArray(str));