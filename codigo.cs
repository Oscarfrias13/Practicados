using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicados
{
    public class codigos
    {
      public void codigo ()
        {
            //Declaraciones de variables//
            int numero1 = 0;
            int numero2 = 0;
            int suma = 0;
            int diferancia = 0;
            decimal division = 0;

            try
            {
                //Captura de datos//
                Console.WriteLine("Digite el primer numero: ");
                numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite el segundo numero: ");
                numero2 = int.Parse(Console.ReadLine());

                if (numero1 > numero2)
                {
                    Console.WriteLine("Numero 1 es mayor que numero dos");
                    suma = numero1 + numero2;
                    Console.WriteLine($"La suma de {numero1} y {numero2} es igual a {suma}");
                    diferancia = numero1 - numero2;
                    Console.WriteLine($"La diferencia entre {numero1} y {numero2} es igual a {diferancia}");

                }
                if (numero1 == numero2)
                {
                    Console.WriteLine("Los numeros son iguales, por favor, ingrese numeros diferentes.");
                    
                }
                else
                {
                    Console.WriteLine("Numero 2 es mayor que uno");
                    division = numero2 / numero1;
                    Console.WriteLine($"La division entre {numero2} y {numero1} es igual a {division}");
                }

            }
            catch (Exception ex) 
            {
                Console.WriteLine($"El siguiente ha occurrido:{ex.Message}");

            }
            ;


        }

    }
}
