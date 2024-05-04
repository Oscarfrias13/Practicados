using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicados
{
    public class notas
    {
        public void calificaciones()
        {
            //Declaraciones de variables//
            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            int promedio = 0;
            int division = 3;
            try
            {
                //Captura de datos//
                Console.WriteLine("Ingrese la primera calificacion: ");
                nota1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la segunda calificacion: ");
                nota2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la tercera calificacion: ");
                nota3 = int.Parse(Console.ReadLine());

                promedio = (nota1 + nota2 + nota3) / division;
                if (promedio >= 7)
                {
                    Console.WriteLine($"Felicidades, usted ha sido promovido con {promedio}");

                }
                else
                {
                    Console.WriteLine($"Lo siento, usted no ha sido promovido con {promedio}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"El siguiente error ha occurido {ex.Message}");
            }
        }
    }
}
