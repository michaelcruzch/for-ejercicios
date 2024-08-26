using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares 
            //y el mínimo de los números impares.

            int n, contadorPar = 0, contadorImpar = 0, maxPar = 0, minImpar = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                if(n % 2 == 0){
                    contadorPar++;
                    if(contadorPar == 1)
                        maxPar = n;
                    else if(n > maxPar)
                        maxPar = n;
                    contadorImpar++;
                }else if(contadorImpar == 1)
                    minImpar = n;
                else if(n < minImpar)
                    minImpar = n;


            }
            Console.WriteLine("El maximo de los numero pares es: " + maxPar + "y el minimo de los numero impares es: " + minImpar);
        }
    }
}
