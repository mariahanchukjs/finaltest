// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] originalArray = {"Hello", "2", "world", ":-)"};
string[] newArray = new string[originalArray.Length];

void createNewArray (string[] originalArray, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <= 3)
        {
            newArray[count] = originalArray[i];
            count++;
        }
    }
}

void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($", {array[i]} ");
    }
    Console.WriteLine();
}