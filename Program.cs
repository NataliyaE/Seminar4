int[] array = new int [8];

    void FillArray(int[] collection)
    {
        int length = collection.Length;
        int index = 0;
        while (index < length)
        {
            collection[index] = new Random().Next(1,10);
            index++;
        }
    }


void PrintArray (int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{collection[position]}\t");
        position++;
    }
}

FillArray(array);
PrintArray(array);