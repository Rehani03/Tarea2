using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.EjerciciosTarea2
{
    public class DiccionarioPalabras
    {
        //este es el ejercicio 2 del capitulo 7
        public void DiccionarioHash()
        {
            Console.Clear();
            Hashtable tabla = new Hashtable();
            int cantidad = 0;
            string clave, definicion;

            try
            {
                Console.WriteLine("Ingrese la cantidad de palabras que quiere guardar");
                cantidad = Convert.ToInt32(Console.ReadLine());

                for(int i = 0; i<cantidad; i++)
                {
                    Console.Write("Ingrese la palabra " + (i+1) +":");
                    clave = Console.ReadLine();
                    Console.Write("Ingrese la definicion de la palabra " + (i + 1) + ":");
                    definicion = Console.ReadLine();
                    tabla.Add(clave, definicion);
                }

                Console.WriteLine("Las palabras guardadas en la Hash son:\n\n");
                foreach (DictionaryEntry dato in tabla)
                {
                    Console.WriteLine("{0} : {1}", dato.Key, dato.Value);
                }
                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Error " + error);
                Console.ReadKey();
            }
        }
    }
}
