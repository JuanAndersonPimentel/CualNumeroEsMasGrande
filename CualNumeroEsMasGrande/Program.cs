using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CualNumeroEsMasGrande
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int suma = 0;
            int resta = 0;
            int producto = 0;
            int cociente = 0;

            try
            {
                Console.WriteLine("ingrese el primer numero:");
               num1= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese el segundo numero:");
                num2= Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                {
                    suma = num1 + num2;
                    resta = num1 - num2;

                    Console.WriteLine($"esta es la suma y la resta de los numeros ingresados por teclado:{suma} y {resta}");
                }
                else
                { 
                    producto = num1 * num2;

                    cociente = num1 / num2;
                }
             
                    

            }
            catch (Exception)
            {
                Console.WriteLine("error: favor de ingresar numeros:");
               
            }
            
        }
    }
}
