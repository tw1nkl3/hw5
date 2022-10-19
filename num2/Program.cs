/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] array = new int[10];
fillArray(array);
printArray(array);

Console.WriteLine(countOdd_elements(array));

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

int countOdd_elements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 != 0)
        {
            count += arr[i];
        }
    }
    return count;
}