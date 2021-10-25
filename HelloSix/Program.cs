int xa = 30, ya = 1,
    xb = 1, yb = 10, 
    xc = 60, yc = 10;
Console.Clear();

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");



int i = 0, x = 0, y = 0;
while (i <10000)
{
    int RundomUp = new Random().Next(0, 3);
    if (RundomUp == 0) 
    {
        x = (x + xa)/2;
        y = (y + ya)/2;

    }
    if (RundomUp == 1) 
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
        
    }
    if (RundomUp == 2) 
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
        
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    i++;
}