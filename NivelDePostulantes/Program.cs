using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelDePostulantes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int totalpreguntas = 0;
            int respuestascorrectas = 0;
            decimal porcentaje = 0;

            try
            {
                Console.WriteLine("ingrese el numero total de preguntas:");
                totalpreguntas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese el total de respuestas correctas:");
                respuestascorrectas = Convert.ToInt32(Console.ReadLine()); 
                if (respuestascorrectas > totalpreguntas)
                {
                    Console.WriteLine("error: el numero de respuestas correctas no puede ser mayor que el total de preguntas:");
                    return;

                }
                 porcentaje = (respuestascorrectas / totalpreguntas) * 100;

                Console.WriteLine($"el porcentaje de respuestas correctas es: {porcentaje}%");

                if (porcentaje >= 90)
                {
                    Console.WriteLine("nivel maximo:");
                }
                else if 
                (porcentaje >= 75 && porcentaje < 90)
                {
                    Console.WriteLine("nivel medio:");
                }
                else if (porcentaje >= 50 && porcentaje < 75)
                {
                    Console.WriteLine("nivel regular:");
                }
                else
                {
                    Console.WriteLine("fuera de nivel:");
                }
                          

            }
            catch (Exception)
            {
                Console.WriteLine("error: ingreso un valor no valido, por favor ingrese numeros enteros");
                
            }
        }

    }
}
