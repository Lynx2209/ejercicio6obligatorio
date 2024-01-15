using ejercicio6obligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6obligatorio.servicios
{
    internal class Operativaimplementacion
    {
        internal class OperativaImplementacion : Operativainterfaz
        {
            /// <summary>
            /// Metodo para agregar un nuevo cliente a la lista 
            /// </summary>
            /// JL - 15/01/2024
            /// <param name="listaAntigua"></param>
            public void agregarCliente(List<Clientes> listaAntigua)
            {
                // Crea u nuevo cliente con la informacion dada por el usuario
                Clientes cliente = crearNewCliente();

                // agrega un nuevo cliente
                listaAntigua.Add(cliente);

            }
            /// <summary>
            /// Metodo privado que solicita toda la informacion  al usuario
            /// </summary>
            /// JL - 15/01/2024
            /// <returns></returns>
            private Clientes crearNewCliente()
            {
                //Solicita al usuario todos los datos para añadir un cliente
                Clientes newCliente = new Clientes();

                Console.WriteLine("Escriba el id");
                newCliente.IdClientes = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Escriba su nombre");
                newCliente.Nombre = Console.ReadLine();

                Console.WriteLine("Escriba sus apellidos");
                newCliente.Apellidos = Console.ReadLine();

                Console.WriteLine("Escriba la edad");
                newCliente.Edad = Convert.ToInt32(Console.ReadLine());

                return newCliente;

            }
            /// <summary>
            /// Metodo para ordenar los clientes por edades
            /// </summary>
            /// JL - 15/01/2024
            /// <param name="listaAntigua"></param>
            public void ordenarEdades(List<Clientes> listaAntigua)
            {

                int edades = listaAntigua.Count;

                // // Ordena la lista por edad atraves del metodo Burbuja
                if (listaAntigua.Count >= 3)
                {
                    // Bucle anidado para recorrer toda la lista
                    for (int filas = 0; filas < listaAntigua.Count; filas++)
                    {
                        for (int columnas = 0; columnas < listaAntigua.Count - 1 - filas; columnas++)
                        {
                            // Intercambia las posiciones entre clientes dependiendo de la edad que tengan
                            if (listaAntigua[columnas + 1].Edad > listaAntigua[columnas].Edad)
                            {
                                int aux = listaAntigua[columnas + 1].Edad;
                                listaAntigua[columnas + 1].Edad = listaAntigua[columnas].Edad;
                                listaAntigua[columnas].Edad = aux;


                            }

                        }
                    }
                    Console.WriteLine("Estos son los clientes ordenados de forma descendente");

                    // Muestra la lista de clientes ordenada
                    foreach (Clientes cliente in listaAntigua)
                    {
                        Console.WriteLine(cliente.ToString());
                    }

                }
                else
                {
                    Console.WriteLine("Debe añadir minimo 3 usuarios para poder ordenarlos");
                }

            }



        }
    }
}

