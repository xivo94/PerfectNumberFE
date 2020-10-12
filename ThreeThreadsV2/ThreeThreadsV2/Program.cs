using System;
using System.Threading;


class TwoThreads
{
    static void Main()
    {
        new Thread(Go).Start();      // Call Go() on a new thread
        new Thread(Walk).Start();
        new Thread(newF).Start();
        //Go();                        // Call Go() on the main threa



        Console.ReadKey();

    }

    static void Go()
    {
        // Declare and use a local variable - 'cycles'
        for (int cycles = 0; cycles < 3000; cycles++) Console.Write('?');
    }

    static void Walk()
    {
        // Declare and use a local variable - 'cycles'
        for (int cycles = 0; cycles < 1000; cycles++) Console.Write('-');
    }

    static void newF()
    {
        for(int i= 0; i< 3500; i++)
        {
            Console.Write("*");
        }
    }

}