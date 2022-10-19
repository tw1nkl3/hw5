/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

int[] array = new int[10];
fillArray(array);
printArray(array);

Console.WriteLine(difference(array));

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

int difference(int[] arr)
{
    int min = 1000000;
    int max = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max - min;
} 