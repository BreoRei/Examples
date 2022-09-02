int[] array = { 11, 13, 54, 98, 25, 48, 56, 45, 98 };

int n = array.Length;
int find = 98;

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