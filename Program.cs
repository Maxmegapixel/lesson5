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
// Задача 1: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
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