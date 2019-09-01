using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.EjerciciosTarea2
{
    public class AgendaHash
    {
        //este es el ejercicio 5 del capitulo 7
        
        public void agenda()
        {
            Console.Clear();
            Hashtable agendaHash = new Hashtable();
            int cantidad = 0;
            double numero = 0;
            string nombre; 
           
            try
            {
                Console.WriteLine("Ingrese la cantidad de Personas a guardar en la agenda:");
                cantidad = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write("Nombre de la persona " +(i+1) +":");
                    nombre = Console.ReadLine();
                    Console.Write("Numero de la persona " +(i+1) +":");
                    numero = Convert.ToDouble(Console.ReadLine());
                    agendaHash.Add(numero, nombre);
                }

                Console.WriteLine("\n\nLas personas y numeros guardados son:\n");
                foreach (DictionaryEntry dato in agendaHash)
                {
                    Console.WriteLine("{0}: {1}", dato.Key, dato.Value);
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
