//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.
/*
int[] Array=ArrayGet(12,-9,9);
Console.WriteLine($"Массив: [{String.Join(',',Array)}]");
int[] Summ=SumGet(Array);
Console.WriteLine($"Сумма положительных: {Summ[0]} \nСумма отрицательных: {Summ[1]}");


// Метод возвращает массив

int[] ArrayGet(int Size, int MinVal, int MaxVal)
{
    int[] Result = new int[Size];
    for (int i = 0; i<Size; i++)
    {
        Result[i] = new Random().Next(MinVal, MaxVal+1);
    }
    return Result;
}

// Метод находит сумму элементов массива
int[] SumGet(int[] Massive)
{
    int[] Result= new int[2];
    int PositiveSum = 0;
    int NegativeSum = 0;
    foreach (int item in Massive)
    {
        PositiveSum += item > 0? item : 0;
        NegativeSum += item < 0? item : 0;
    }
    Result[0] = PositiveSum;
    Result[1] = NegativeSum;
    return Result;
}    
*/
/*// Задача 1: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
int[] Array = ArrayGet(12, -9, 9);
Console.WriteLine($"Массив начальный: [{String.Join(',', Array)}]");
int[] Swap = SwapGet(Array);
Console.WriteLine($"Замена            [{String.Join(',', Swap)}]");


// Метод возвращает массив

int[] ArrayGet(int Size, int MinVal, int MaxVal)
{
    int[] Result = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        Result[i] = new Random().Next(MinVal, MaxVal + 1);
    }
    return Result;
}

// Метод замены элементов массива
int[] SwapGet(int[] Massive)
{
    for (int i = 0; i < Massive.Length; i++)
    {
        Massive[i] *= -1;
    }
    return Massive;
}

// Задача 2. Присутствует ли заданное число в массиве
int Number = 4;
int[] Array = ArrayGet(5, 0, 9);
Console.WriteLine($"Массив начальный: [{String.Join(',', Array)}]");
int[] Value = FindGet(Array, Number);
if (Value.Length == 0) Console.WriteLine("Таких чисел нет");
else Console.WriteLine($"Индексы таких элементов [{String.Join(',', Value)}]");


// Метод возвращает массив
int[] ArrayGet(int Size, int MinVal, int MaxVal)
{
    int[] Result = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        Result[i] = new Random().Next(MinVal, MaxVal + 1);
    }
    return Result;
}

// Метод замены элементов массива
int[] FindGet(int[] Massive, int Find)
{
    int count=0;
    for (int i = 0; i < Massive.Length; i++)
    {
        count += Massive[i]==Find? 1 : 0;
    }
    int[] Position = new int[count];
    int j = 0;
    for (int i = 0; i < Massive.Length; i++)
    {
        if (Massive[i]==Find) 
        {
            Position[j++]=i;
        }
    }
    return Position;
}

// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] array = GetArray(5, 1, 33);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine("Введите искомое число: ");
int number = int.Parse(Console.ReadLine()!);
string result = "";

foreach (int el in array)
{
    result = el == number ? "Да" : "Нет";
    if (result == "Да") break;
}

Console.WriteLine(result);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
*/
// Задача 3: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] array = GetArray(123, 0, 500);
Console.WriteLine($"[{String.Join(",", array)}]");
int num = GetCount(array);
Console.WriteLine($"Количество элементов: {num}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int GetCount(int[] Array)
{
    int Count = 0;
    foreach (int item in Array)
    {
        Count += item >= 10 && item <= 99 ? 1 : 0;
    }
    return Count;
}
