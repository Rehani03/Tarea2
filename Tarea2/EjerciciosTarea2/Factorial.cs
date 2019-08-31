using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.EjerciciosTarea2
{
    public class Factorial
    {
        public void calcularFactorial(int numero)
        {
            double resultado = 1;
            for(int i = 1; i<=numero; i++)
            {
                resultado = resultado * i;
            }

            Console.WriteLine("El factorial de " + numero + " es: " + Math.Round(resultado, 2));
            Console.ReadKey();
        }
    }
}
