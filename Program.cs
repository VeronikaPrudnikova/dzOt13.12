// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size)
{
    int[]array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i}] is {array[i]}");
    }
}

void ShowCountEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
       if(array[i] % 2 == 0) count++;
    }
    Console.Write($"из {array.Length} чисел, {count} четный");
}


Console.Write("Сколько будет элементов: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);
ShowArray(myArray);
ShowCountEvenNumbers(myArray);
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i}] is {array[i]}");
    }
}

int SumOddNum(int[] array)
{
    int sum = 0;
    int step = 2;

    for(int i = 1; i < array.Length; i = i + step)
    {
        sum = sum + array[i]; 
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значения массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значения массива: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = SumOddNum(myArray);
Console.WriteLine("Сумма нечетных элементов: " + result);
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRandomArray(int size)
{
    double[]array = new double[size];

    for(int i = 0; i < size; i++)
    {   
        int randomValue = new Random().Next(100, 1000);
        double randomValueDouble = Convert.ToDouble(randomValue);
        double randomForArray = randomValueDouble / 100;
        array[i] = randomForArray;
        // Console.WriteLine($"{randomValue}, {randomValueDouble}, {randomForArray} ");
        // array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i}] is {array[i]}");
    }
}

double GetMin(double[] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double GetMax(double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size);
ShowArray(myArray);

double min = GetMin(myArray);
double max = GetMax(myArray);
double result = max - min;
Console.WriteLine($"максимальное {max}, минимальное {min}, разница {result}");