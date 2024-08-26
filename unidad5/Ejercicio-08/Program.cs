using System;

namespace Ejecicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Hacer un programa que solicite 20 numeros y luego mostrar por pantalla el menor de ellos
            // y la posicion en la que fue ingresado

            int n, min = 0, pos = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                if(x == 0){
                    min = n;
                    pos = x + 1;
                }else if(n < min){
                    min = n;
                    pos = x + 1;
                }


            }
            Console.WriteLine("El numero menor es: " + min + " y su posicion es: " + pos);

            
        }
    }
}
