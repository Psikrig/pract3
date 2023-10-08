using System.Runtime.InteropServices;


    Console.WriteLine("пианина");
double[] k = new double[12] { 1635, 1732, 1835, 1945, 2060, 2183, 2312, 2450, 2596, 2750, 2914, 3087 };
while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    int w = 0;
    if (key.Key == ConsoleKey.A)
    {
        w = 1;
    }
    if (key.Key == ConsoleKey.S)
    {
        w = 2;
    }
    if (key.Key == ConsoleKey.D)
    {
        w = 3;
    }
    if (key.Key == ConsoleKey.F)
    {
        w = 4;
    }
    if (key.Key == ConsoleKey.G)
    {
        w = 5;
    }
    if (key.Key == ConsoleKey.H)
    {
        w = 6;
    }
    if (key.Key == ConsoleKey.J)
    {
        w = 7;
    }
    if (key.Key == ConsoleKey.W)
    {
        w = 8;
    }
    if (key.Key == ConsoleKey.E)
    {
        w = 9;
    }
    if (key.Key == ConsoleKey.T)
    {
        w = 10;
    }
    if (key.Key == ConsoleKey.Y)
    {
        w = 11;
    }
    if (key.Key == ConsoleKey.U)
    {
        w = 12;
    }
    if (key.Key == ConsoleKey.F1)
    {
        w = 13;
    }
    if (key.Key == ConsoleKey.F2)
    {
        w = 14;
    }
    octav(w);
    klav(k, w);
    if (key.Key == ConsoleKey.Escape)
    { break; }
}
static void octav(int w)
{
    double[] octave1 = new double[12] { 1635, 1732, 1835, 1945, 2060, 2183, 2312, 2450, 2596, 2750, 2914, 3087 };
    double[] octave2 = new double[12] { 3270, 3465, 3671, 3889, 4120, 4365, 4625, 4900, 5191, 5500, 5827, 6174 };


    if (w==13)
    {
        double[] k = octave1;   

    }
    if (w == 14)
    {
        double[] k = octave2;
    }


    
}
static void klav(double[] k,int w)
{
 
        if (w == 1)
        {
            Console.Beep(Convert.ToInt32(k[9]), 400);
        }
        if (w == 2)
        {
            Console.Beep(Convert.ToInt32(k[11]), 400);
        }
        if (w == 3)
        {
            Console.Beep(Convert.ToInt32(k[0]), 400);
        }
        if (w == 4)
        {
            Console.Beep(Convert.ToInt32(k[2]), 400);
        }
        if (w == 5)
        {
            Console.Beep(Convert.ToInt32(k[4]), 400);
        }
        if (w == 6)
        {
            Console.Beep(Convert.ToInt32(k[5]), 400);
        }
        if (w == 7)
        {
            Console.Beep(Convert.ToInt32(k[9]), 400);
        }
        if (w == 8)
        {
            Console.Beep(Convert.ToInt32(k[10]), 300);
        }
        if (w == 9)
        {
            Console.Beep(Convert.ToInt32(k[1]), 400);
        }
        if (w == 10)
        {
            Console.Beep(Convert.ToInt32(k[3]), 400);
        }
        if (w == 11)
        {
            Console.Beep(Convert.ToInt32(k[6]), 400);
        }
        if (w == 12)
        {
            Console.Beep(Convert.ToInt32(k[8]), 400);
        }
         
}
