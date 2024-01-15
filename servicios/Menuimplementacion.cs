using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6obligatorio.servicios
{
    internal class Menuimplementacion
    {
        /// <summary>
        /// Metodo que muestra el menu y la seleccion del usuario
        /// </summary>
        /// JL - 15/01/2024  
        /// <returns></returns>
        public int menuYSeleccion()
        {
            int opcionuno;

            // Muestra las opciones del menu
            Console.WriteLine("------------------------------");
            Console.WriteLine("0. Cerrar menú");
            Console.WriteLine("1. Dar de alta nuevo cliente");
            Console.WriteLine("2. Ordenar lista clientes");
            Console.WriteLine("------------------------------");
            // Recoge la seleccion del usuario
            opcionuno = Convert.ToInt32(Console.ReadLine());


            return opcionuno;

        }

    }
}
    

