// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int amount = int.Parse(Console.ReadLine()!);
string[] array = new string[amount];
string[] arrayNew = new string[array.Length];
CreatArray(array, arrayNew);

string[] CreatArray(string[] array, string[] arrayNew)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент: ");
        array[i] = Console.ReadLine()!;
        if (array[i].Length <= 3)
        {
            arrayNew[count] = array[i];
            count++;
        }

    }
 Array.Resize(ref arrayNew, count);
    return arrayNew;
}

void PrintArray(string[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}