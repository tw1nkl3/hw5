/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] array = new int[10];
fillArray(array);
printArray(array);

Console.WriteLine(countEven(array));

int[] fillArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void printArray(int[] arr)
{
    Console.WriteLine(string.Join(", ", arr));
}

int countEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}