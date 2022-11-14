// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []
Console.Clear();
Console.WriteLine("Сколько элементов будем вводить?");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
//Заполнение массива
int i = 0;
while (i < array.Length)
{
    Console.WriteLine($"введите {i}-й элемент массива:");
    array[i] = Console.ReadLine();
    i++;
}
Console.WriteLine("Ваш массив:");
show(array);
//Создание массива результатов
string[] result = new string[CountSize(array)];
// заполнение массива результатов
i = 0;
n = 0;
while (i < array.Length)
{
    if (size(array[i]))
    {
        result[n] = array[i];
        n++;

    }

    i++;
}
Console.WriteLine("Результирующий массив ");
show(result);
//Процедура вывода массива
void show(string[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write($" {array[i]}");
        i++;
    }
    Console.WriteLine();
}

// Процедура подсчета количества элементов нужного размера
int CountSize(string[] array)
{
    int n = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (size(array[i])) n++;

        i++;
    }
    return n;
}



bool size(string s) // Процедура проверки длинны элемента
{
    if (s.Length < 4)
        return true;
    else return false;
}
