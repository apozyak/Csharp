int[]array = {1, 23, 35, 24, 6, 17, 52, 24, 83, 29};
int n = array.Length;
int find = 24;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
    Console.WriteLine(index);
    break;
    }

    index++;
}

