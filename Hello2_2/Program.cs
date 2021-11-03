// See https://aka.ms/new-console-template for more information
//Ищем введенный индекс элемента в массиве
int[] array = {1,6,3,21,54,5,43,11,9};
int Lengh = array.Length;
int found = int.Parse(Console.ReadLine());
for(int i =0; i<Lengh; i++)
{
    if(array[i] == found)
    {
        Console.WriteLine($"Индекс вашего числа {i}");
        break;
    }
    if(i == Lengh-1)
    {
        Console.WriteLine("Вашего числа в массиве нет");
    }
}
