using System;

public static class ConsoleSpiner
{
    static int counter;
    static ConsoleSpiner()
    {
        counter = 0;
    }
    public static void Spin()
    {
        counter++;
        switch (counter % 4)
        {
            case 0: Console.Write("/"); break;
            case 1: Console.Write("-"); break;
            case 2: Console.Write("\\"); break;
            case 3: Console.Write("|"); break;
        }
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }
}