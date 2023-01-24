// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] FillArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
       Console.Write($"Введите {i+1} значение массива: ");
       array[i] = Console.ReadLine();
       Console.WriteLine();
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int length = int.Parse(Console.ReadLine());
    return length;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


Console.Clear();
int length = EnterData("Введите количество элементов массива: ");
string[] array = FillArray(length);
string[] result_array = new string[array.Length];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        result_array[count] = array[i];
        count++;
    }
}
PrintArray(result_array);