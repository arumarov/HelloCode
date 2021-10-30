void FillArray(int[] collection) // Void - метод, который ничего не возвращает. Не используем оператор return
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
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
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // 1. создаем новый массив, в котором будет 10 элементов

FillArray(array); // 2. Вызвали метод, который заполнил наш массив
array[4] = 4;
array[6] = 4;
PrintArray(array); // 3. Вызвали метод, который распечатал наш массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);