int[] array = {1, 12, 31, 4, 18, 16, 17, 18}; // чисел может быть сколько угодно

int n = array.Length; // длина (количество элементов) массива
int find = 18;

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