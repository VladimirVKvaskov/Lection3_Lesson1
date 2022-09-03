Console.Clear();

void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {

        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        //position = position + 1;
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        //index = index + 1;
        index++;
    }
    return position;

}

int[] array = new int[10];

FillArray(array);
array[4] = 13;
array [6] = 13;

PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array,444);
Console.WriteLine(pos);

