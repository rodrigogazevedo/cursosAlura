﻿using System;
class Program
{
    static void Main(string[] args)
    {
        int fatorial = 1;

        for (int i = 1; i <= 10; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " +i+ " = " +fatorial);
        }


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}