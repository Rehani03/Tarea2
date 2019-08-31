using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class Menu
    {
        private int opcion, numero;

        public void Start()
        {
            
            Tarea2.EjerciciosTarea2.Factorial factorialNumero = new EjerciciosTarea2.Factorial();
            Tarea2.EjerciciosTarea2.DeNumeroALetras convertir = new EjerciciosTarea2.DeNumeroALetras();
            do
            {
                try
                {


                    Console.Clear();

                    Console.WriteLine("                     Programacion Aplicada I");
                    Console.WriteLine("                           Tarea 2");
                    Console.WriteLine("                    Rehani Cordero 2017-0302\n\n");
                    Console.WriteLine("1. Calcular Factorial de un numero");
                    Console.WriteLine("2. Ingresar un numero en digitos e imprimirlo en letras");
                    Console.WriteLine("3. Salir");
                    Console.Write("Opcion:");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Ingrese un numero:");
                            numero = Convert.ToInt32(Console.ReadLine());
                            factorialNumero.calcularFactorial(numero);
                            break;
                        case 2:
                            Console.Clear();
                            Console.Write("Ingrese el numero a convertir:");
                            numero = Convert.ToInt32(Console.ReadLine());
                            convertir.ConvertirNumeros(numero);
                            Console.ReadKey();
                            break;
                        case 3:

                            Environment.Exit(1);
                            break;

                        default:
                            Console.WriteLine("Esta opcion no existe");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception error)
                { 
                    Console.WriteLine("Error " + error);
                    Console.ReadKey();
                }
            }
            while (opcion != 3);
        }
    }
}
