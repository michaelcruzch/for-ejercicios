using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 numeros y calcule y emita por pantalla cueantos son positivos(mayores a cero).
            //Se debe mostrar un solo valor: el conteo final.

            int n, con = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());
                if(n > 0)
                    con++;
            }
            Console.WriteLine("La cantidad de numero mayores a cero son: " + con);
        }
    }
}
