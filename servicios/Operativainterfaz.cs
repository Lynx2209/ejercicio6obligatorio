using ejercicio6obligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6obligatorio.servicios
{
    internal interface Operativainterfaz
    {
        internal interface Operativainterfaz
        {
            /// <summary>
            /// Metodo para agregar un nuevo cliente a la lista
            /// </summary>
            /// JL - 15/01/2024
            /// <param name="listaAntigua"></param>
            public void agregarCliente(List<Clientes> listaAntigua);

            /// <summary>
            /// Metodo privado que solicita toda la informacion  al usuario
            /// </summary>
            /// JL - 15/01/2024
            /// <param name="listaAntigua"></param>
            public void ordenarEdades(List<Clientes> listaAntigua);

        }
    }
}
}
