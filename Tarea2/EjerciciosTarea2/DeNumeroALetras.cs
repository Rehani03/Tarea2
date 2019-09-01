using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.EjerciciosTarea2
{
    public class DeNumeroALetras
    {
        //este es el Ejercicio 5 del Capitulo 5
        public void ConvertirNumeros(double numero)
        {
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                case 6:
                    Console.WriteLine("Seis");
                    break;
                case 7:
                    Console.WriteLine("Siete");
                    break;
                case 8:
                    Console.WriteLine("Ocho");
                    break;
                case 9:
                    Console.WriteLine("Nueve");
                    break;
                case 10:
                    Console.WriteLine("Diez");
                    break;
                case 11:
                    Console.WriteLine("Once");
                    break;
                case 12:
                    Console.WriteLine("Doce");
                    break;
                case 13:
                    Console.WriteLine("Trece");
                    break;
                case 14:
                    Console.WriteLine("Catorce");
                    break;
                case 15:
                    Console.WriteLine("Quince");
                    break;
                case 16:
                    Console.WriteLine("Dieciseis");
                    break;
                case 17:
                    Console.WriteLine("Diecisiete");
                    break;
                case 18:
                    Console.WriteLine("Dieciocho");
                    break;
                case 19:
                    Console.WriteLine("Diecinueve");
                    break;
                case 20:
                    Console.WriteLine("Vente");
                    break;
                default:
                    Console.WriteLine("Este numero aun no existe en este programa, por favor, espere nuevas actualizaciones :)");
                    break;
            }
        }
    }
}
