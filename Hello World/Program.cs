﻿using System.ComponentModel;

namespace Hello_World;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        int c = 0;
        c = Add(a, b);
        Console.WriteLine($"The sum of {a} and {b} is {c}");
        
    }

    static int Add(int var1, int var2)
    {
        return var1 + var2;
    }
}

