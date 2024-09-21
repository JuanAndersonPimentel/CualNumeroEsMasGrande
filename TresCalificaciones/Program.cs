using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresCalificaciones
{
    public class Program
    {
        static void Main(string[] args)
        {
			decimal calificacion1 = 0;
			decimal calificacion2 = 0;
			decimal calificacion3 = 0;
            decimal promedio = 0;

			try
			{
				Console.WriteLine("ingrese la primera calificacion:");
				calificacion1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("ingrese la segunda calificacion:");
                calificacion2 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("ingrese la tercera calificacion:");
                calificacion3 = Convert.ToDecimal(Console.ReadLine());

                 promedio = calificacion1 + calificacion2 + calificacion3 / 3;

                Console.WriteLine($"el promedio es: {promedio}");

                if (promedio > 7)
                {
                    Console.WriteLine($"el alumno aprobo:");
                }
                else
                {
                    Console.WriteLine($"el alunmo reprebo:");
                }
       
            }
			catch (Exception)
			{
                Console.WriteLine("error: ingreso un valor no valido,favor de ingresar valores numerico:");
			
			}


        }
    }
}
