using System;
class Program
{
    static void Main(String[] args)
    {
        //Percorrendo todos os 100 números
        for (int numero = 1; numero <= 100; numero++)
        {
            if(numero % 3 == 0)
            {
                Console.WriteLine(numero);
            }
        }

        //Percorrendo somente os números múltiplos de 3
        for (int numero = 3; numero <= 100; numero+=3)
        {
            Console.WriteLine(numero);
        }
    }
}