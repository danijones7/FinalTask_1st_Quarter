// Написать программу, которая из имеющегося массива строк формирует массиа из строк, длина которых меньше, либо равна 3 символам.

string [] CutThreeOrLessSymbolsElementsOfArray(string[] array1)
{
    string[] array2 = new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    return array2;
}


void PrintArray(string [] arr)  // Выводит на печать заданный или полученный массив 
{
    System.Console.WriteLine("[" + string.Join(" ", arr) + "]");
}

string[] array1 = new string[4] { "hello", "2", "world", ":-)" };
string[] array2 = CutThreeOrLessSymbolsElementsOfArray(array1);
PrintArray(array2);
