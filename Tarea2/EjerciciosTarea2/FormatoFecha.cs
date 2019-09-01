using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.EjerciciosTarea2
{
    public class FormatoFecha
    {
        //Ejercicio 1 del Capitulo 8.
        //Muestra la fecha en formato AM o FM seguido de dia, mes, año.
        public void MostrarFechaHora()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToString("hh : mm tt  dd/MM/yyyy"));
            Console.ReadKey();
        }
    }
}
