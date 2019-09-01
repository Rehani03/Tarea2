using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.EjerciciosTarea2
{
    public class ArregloDeEstudianteJagged
    {
        //Estos son los ejercicios del Capitulo 6
        
        private double PromedioCalificaciones = 0.0;
        private int numSalones = 0, numEstudiantes = 0;


        /*El ejercicio 4, lo pongo a prueba cuando en un metodo pido los salones y estudiantes y este arreglo es pasado a otro 
        /para ser rellenado*/
        public void ComienzoDeEstudiantes(int opcion)
        {
            //aqui pedimos la cantidad de salones
            Console.Write("Ingrese la cantidad de Salones:");
            numSalones = Convert.ToInt32(Console.ReadLine());

            double[][] calificaciones = new double[numSalones][];

            //aqui pedimos la cantidad de estudiantes por salon
            for (int i = 0; i < numSalones; i++)
            {
                Console.Write("\nIngrese la cantidad de Estudiantes para el Salon {0}:", i + 1);
                numEstudiantes = Convert.ToInt32(Console.ReadLine());
                calificaciones[i] = new double[numEstudiantes];
            }

            RellenarCalificaciones(calificaciones);

            //aqui dependiendo la opcion saco el promedio, la calificacion mas alta o la menor y tambien paso otro arreglo
            switch (opcion)
            {
                case 1:
                    CalcularPromedio(calificaciones);
                    break;
                case 2:
                    CalcularMayorCalificacion(calificaciones);
                    break;
                case 3:
                    CalcularMenorCalificacion(calificaciones);
                    break;
                case 4:
                    RecibirArregloJagged(calificaciones);
                    break;
                default:
                    Console.WriteLine("No existe...");
                    Console.ReadKey();
                    break;
            }
          
        }
        private void RellenarCalificaciones(double [][] calificaciones)
        {
            //aqui ingresamos las calificaciones de cada estudiante perteneciente a su respectivo salon
            for (int x = 0; x < numSalones; x++)
            {
                for (int y = 0; y < numEstudiantes; y++)
                {
                    Console.Write("\nIngrese la calificacion del Estudiante " + (y + 1) + " del Salon " + (x + 1) +":");
                    calificaciones[x][y] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        //aqui calculo el promedio de las calificaciones, correspondiente al Ejercicio 1
        private void CalcularPromedio(double[][] calificaciones)
        {
            double AcumPromedio = 0.0;
            int AcumEstudiantes = 0;
            for (int i = 0; i < calificaciones.Length; i++)
            {
                AcumEstudiantes += calificaciones[i].GetLength(0);
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    AcumPromedio += calificaciones[i][j];
                }
            }
            PromedioCalificaciones = AcumPromedio / (calificaciones.Length * AcumEstudiantes);
            Console.WriteLine("El promedio de calificaciones es:" + Math.Round(PromedioCalificaciones, 2));
            Console.ReadKey();

        }

        //aqui calculo la calificacion mas alta , correspondiente al Ejercicio 2
        private void CalcularMayorCalificacion(double[][] calificaciones)
        {
            double maximo = 0.0;
  
            for (int i = 0; i < calificaciones.Length; i++)
            { 
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    if (calificaciones[i][j] > maximo)
                    {
                        maximo = calificaciones[i][j];
                    }
                }
            }
            Console.WriteLine("La calificaciones mas alta es:" + maximo);
            Console.ReadKey();
        }

        //aqui calculo la calificacion menor, correspondiente al Ejercicio 3
        private void CalcularMenorCalificacion(double[][] calificaciones)
        {
            double minimo = 100;

            for (int i = 0; i < calificaciones.Length; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    if (calificaciones[i][j] < minimo)
                    {
                        minimo = calificaciones[i][j];
                    }
                }
            }
            Console.WriteLine("La calificaciones mas alta es:" + minimo);
            Console.ReadKey();
        }


        //aqui recibo un arreglo jagged, correspondiente al Ejercicio 5
        private void RecibirArregloJagged(double[][] calificaciones)
        {
            for(int i = 0; i<calificaciones.Length; i++)
            {
                for(int j = 0; j<calificaciones.GetLength(0); j++)
                {
                    Console.WriteLine("La Calificacion del Estudiante "+(j+1) +" del salon " +(i+1) +" es: "+calificaciones[i][j]);
                }
            }

            Console.WriteLine("\n\nEstas calificaciones fueron pasados a un metodo y estaban en un arreglo Jagged :)");
            Console.ReadKey();
        }
    }
}
