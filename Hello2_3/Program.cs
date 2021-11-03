//

void FillArray(int[] filled)
{
    int n = filled.Length;
    int i = 0;
    while (i<n)
    {
        filled[i] = new Random().Next(1,100);
        i++;
    }
}

void PrintArray(int[] printed)
{
    int n = printed.Length;
    int i = 0;
    while(i<n)
    {
        Console.WriteLine($"Элемент №{i+1} = {printed[i]}");
        i++;
    }
}

int FindIndex(int found, int[] massiv)
{
    int Lengh = massiv.Length;
    int i = 0;
    while(i < Lengh)
    {
        if(massiv[i] == found)
        {
            return i;            
        }  
        i++;      
    }
    return i+1;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine("Введите число:");
int find = int.Parse(Console.ReadLine());
int element = FindIndex(find, array);
if(element== array.Length + 1)
{
    Console.WriteLine("Вашего числа в массиве нет");
}
else
{
    Console.WriteLine($"Номер элемента {find} в массиве - {element}");
}

