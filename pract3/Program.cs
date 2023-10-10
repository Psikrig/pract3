using System;
using System.Runtime.InteropServices;


    Console.WriteLine("пианина");
double[] k = new double[12] { 1635, 1732, 1835, 1945, 2060, 2183, 2312, 2450, 2596, 2750, 2914, 3087 };
while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    octav(key);
    klav(k, key);
    if (key.Key == ConsoleKey.Escape)
    { break; }
}
static void octav(ConsoleKeyInfo key)
{
    double[] octave1 = new double[12] { 1635, 1732, 1835, 1945, 2060, 2183, 2312, 2450, 2596, 2750, 2914, 3087 };
    double[] octave2 = new double[12] { 3270, 3465, 3671, 3889, 4120, 4365, 4625, 4900, 5191, 5500, 5827, 6174 };


    if (key.Key == ConsoleKey.F1)
    {
        double[] k = octave1;   

    }
    if (key.Key == ConsoleKey.F2)
    {
        double[] k = octave2;
    }


    
}
static void klav(double[] k, ConsoleKeyInfo key)
{
    if (key.Key == ConsoleKey.A)
    {
        Console.Beep(Convert.ToInt32(k[9]), 400);
    }
    if (key.Key == ConsoleKey.S)
    {
        Console.Beep(Convert.ToInt32(k[11]), 400);
    }
    if (key.Key == ConsoleKey.D)
    {
        Console.Beep(Convert.ToInt32(k[0]), 400);
    }
    if (key.Key == ConsoleKey.F)
    {
        Console.Beep(Convert.ToInt32(k[2]), 400);
    }
    if (key.Key == ConsoleKey.G)
    {
        Console.Beep(Convert.ToInt32(k[4]), 400);
    }
    if (key.Key == ConsoleKey.H)
    {
        Console.Beep(Convert.ToInt32(k[5]), 400);
    }
    if (key.Key == ConsoleKey.J)
    {
        Console.Beep(Convert.ToInt32(k[9]), 400);
    }
    if (key.Key == ConsoleKey.W)
    {
        Console.Beep(Convert.ToInt32(k[10]), 400);
    }
    if (key.Key == ConsoleKey.E)
    {
        Console.Beep(Convert.ToInt32(k[1]), 400);
    }
    if (key.Key == ConsoleKey.T)
    {
        Console.Beep(Convert.ToInt32(k[1]), 400);
    }
    if (key.Key == ConsoleKey.Y)
    {
        Console.Beep(Convert.ToInt32(k[6]), 400);
    }
    if (key.Key == ConsoleKey.U)
    {
        Console.Beep(Convert.ToInt32(k[8]), 400);
    }
