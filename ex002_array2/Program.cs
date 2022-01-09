int[] array = { 13, 354, 56, 67, 78, 78, 64, 90 };

int n = array.Length;
int find = 78;

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