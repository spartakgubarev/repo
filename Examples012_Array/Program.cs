// Сортировка массива по возрастанию
// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//     int cout = array.Length;
//     for (int i = 0; i < cout; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// void SelectoinSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectoinSort(arr);
// PrintArray(arr);


// Сортировка массива по убыванию
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int cout = array.Length;
    for (int i = 0; i < cout; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectoinSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);
SelectoinSort(arr);
PrintArray(arr);
