using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 10 numeros y luego calcule y emita el mayor de los primos de la lista.
            //En caso de no haber ningun numero primo, debera aclararlo con un cartel.

            int n, primo = 0, max = 0, con;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());

                con = 0;

                for (int y = 1; y <= n; y++)
                {
                    if(n % y == 0)
                        con++;
                }

                if(con == 2){
                    if(primo == 0){
                        max = n;
                        primo = 1;
                    }else if(n > max)
                        max = n;
                }

            }
            Console.WriteLine("El numero primo mayor es:  " + max);



        }
    }
}
