using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class Menu
    {
        public void Start()
        {
            int opcion;
            try
            {

                do
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
                            Console.ReadKey();
                            break;
                        case 2:
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
                while (opcion != 3);
            }
            catch (Exception error)
            {

                Console.WriteLine("Error " + error);
                Console.ReadKey();
            }
        }
    }
}
