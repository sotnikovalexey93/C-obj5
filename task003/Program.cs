/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76


*/


int size = ReadInt("Введите размерность массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int maxFillarray = numbers[0];
int minFillarray = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxFillarray)
    {
        maxFillarray = numbers[i];
    }
    if (numbers[i] < minFillarray)
    {
        minFillarray = numbers[i];
    }
}

void FillArrayRandomNumbers(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)  
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillarray - minFillarray}");