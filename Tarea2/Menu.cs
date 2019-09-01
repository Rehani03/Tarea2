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
        private const int PROMEDIO = 1, MAYOR = 2, MENOR = 3, JAGGED =4;

        public void Start()
        {
            
            Tarea2.EjerciciosTarea2.Factorial factorialNumero = new EjerciciosTarea2.Factorial();
            Tarea2.EjerciciosTarea2.DeNumeroALetras convertir = new EjerciciosTarea2.DeNumeroALetras();
            Tarea2.EjerciciosTarea2.ArregloDeEstudianteJagged arreglosEstudiante = new EjerciciosTarea2.ArregloDeEstudianteJagged();
            Tarea2.EjerciciosTarea2.PromedioArrayList promedio = new EjerciciosTarea2.PromedioArrayList();
            Tarea2.EjerciciosTarea2.DiccionarioPalabras diccionario = new EjerciciosTarea2.DiccionarioPalabras();
            Tarea2.EjerciciosTarea2.AgendaHash agendaNueva = new EjerciciosTarea2.AgendaHash();
            Tarea2.EjerciciosTarea2.FormatoFecha fecha = new EjerciciosTarea2.FormatoFecha();
            Tarea2.EjerciciosTarea2.CadenasEnOrden ordenCadena = new EjerciciosTarea2.CadenasEnOrden();

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
                    Console.WriteLine("3. Calcular Promedio de arreglo Jagged");
                    Console.WriteLine("4. Calcular Mayor Calificacion de arreglo Jagged");
                    Console.WriteLine("5. Calcular Menor Calificacion de arreglo Jagged");
                    Console.WriteLine("6. Programa que pasa un arreglo Jagged a una funcion");
                    Console.WriteLine("7. Calcular Promedio de Calificaciones de un Salon de Clase en ArrayList");
                    Console.WriteLine("8. Diccionario de Palabras en HashTable");
                    Console.WriteLine("9. Agenda de Contactos en HashTable");
                    Console.WriteLine("10.Programa que muestra la fecha y hora en formato AM/PM");
                    Console.WriteLine("11.Programa que muestra dos cadenas en orden alfabetico");
                    Console.WriteLine("12. Salir");
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
                            Console.Clear();
                            arreglosEstudiante.ComienzoDeEstudiantes(PROMEDIO);
                            break;
                        case 4:
                            Console.Clear();
                            arreglosEstudiante.ComienzoDeEstudiantes(MAYOR);
                            break;
                        case 5:
                            Console.Clear();
                            arreglosEstudiante.ComienzoDeEstudiantes(MENOR);
                            break;
                        case 6:
                            Console.Clear();
                            arreglosEstudiante.ComienzoDeEstudiantes(JAGGED);
                            break;
                        case 7:
                            promedio.CalcularPromedioArrayList();
                            break;
                        case 8:
                            diccionario.DiccionarioHash();
                            break;
                        case 9:
                            agendaNueva.agenda();
                            break;
                        case 10:
                            fecha.MostrarFechaHora();
                            break;
                        case 11:
                            ordenCadena.MostrarCadenas();
                            break;
                        case 12:
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
            while (opcion != 12);
        }
    }
}
