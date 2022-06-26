int[] array = { 1, 2, 3, 4, 15, 6, 7, 8, 9, 13, 13, 15, 28 };

int n = array.Length;
int find = 15;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}