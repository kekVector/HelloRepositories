//Практикуемся с функциями(методами) и массивами

// int n1 = 11, n2 = 22, n3 = 33, n4 = 12, n5 = 87, n6 = 2, n7 = 42, n8 = 66, n9 = 72;
//
// int maxim(int num1, int num2, int num3, int num4, int num5,int num6, int num7, int num8, int num9)
// {
//     int max = num1;
//     if(max < num2)
//     {
//         max = num2;
//     }

//     if(max < num3)
//     {
//         max = num3;
//     }

//     if(max < num4)
//     {
//         max = num4;
//     }
//     if(max < num5)
//     {
//         max = num5;
//     }
//     if(max < num6)
//     {
//         max = num6;
//     }
//     if(max < num7)
//     {
//         max = num7;
//     }
//     if(max < num8)
//     {
//         max = num8;
//     }

//     if(max < num9)
//     {
//         max = num9;
//     }
//     return max;

// }
// int result = maxim(n1,n2,n3,n4,n5,n6,n7,n8,n9);
// Console.WriteLine($"Максимальное :{result}");


int[] array = {1,6,3,21,54,5,43,11,9};

for(int i=0; i<=8; i++) 
{
    Console.WriteLine(array[i]);
}
int maxim(int[] massiv)
{
    int n = massiv.Length;
    int max = massiv[0];
     for(int i=1; i<=n-1; i++) 
    {
        if ( massiv[i]>max)
        {
            max = massiv[i];
        }
    }
    return max;
}
Console.WriteLine("Максимальное число в массиве - " + maxim(array));