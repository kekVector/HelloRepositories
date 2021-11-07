// Сформировать случайным образом N-элементный массив, заполненный однозначными целыми числами разных знаков. Задать k и выяснить

// сколько раз повторяется k в массиве
// сколько элементов находится между первым и последним k
// сколько раз встречается k

int N = 10;

int[] RndMassive(int n)
{
    int[] arr = new int[n];
    for(int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(-3, 3);
    }
    return arr;
}
void PrintMassiv(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] array = RndMassive(N);
array[1] = 1;
array[7] = 1;
PrintMassiv(array);
int k = 1; // Что ищем
int countK = 0; // Количество К в массиве
int Num1 = -1, Num2 = -1; // Порядковые номера первого и последнего К
for (int i = 0; i < array.Length; i++)
{
    if(array[i] == k)
    {
        if(Num1 != -1) Num2 = i;
        else Num1 = i;
        countK++;   
    }
}
Console.WriteLine();
Console.WriteLine($"Количество встречающихся {k} в массиве - {countK}");
Console.WriteLine($"Количество элементов между первым и последним {Num2 - Num1 - 1}");