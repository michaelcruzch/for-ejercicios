using System;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10 numeros y luego mostrar por pantalla el maximo de ellos
            // y la posicion en la que fue ingresado

            int n, pos = 0, maxNum = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());

                if(x == 0){
                    maxNum = n;
                    pos = 1;
                }else if(n > maxNum){
                    maxNum = n;
                    pos = x + 1;
                }
            }
            Console.WriteLine ("El maximo es: " + maxNum + " y la posicion es: " + pos);
        }
    }
}
