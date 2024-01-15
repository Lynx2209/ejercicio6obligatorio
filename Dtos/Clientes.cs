using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6obligatorio.Dtos
{
    internal class Clientes
    {
        //  Creacion de los Campos privados
        long idClientes;

        string nombre;

        string apellidos;

        string nombreCompletodelCliente;

        int edades;

        internal long id;

        // Propiedades publicas
        public long IdClientes{ get => idClientes; set => idClientes = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string NombreCompletodelCliente { get => nombreCompletodelCliente; set => nombreCompletodelCliente = value; }
        public int Edad { get => edades; set => edades = value; }

        // Constructores
        public Clientes(long id, string nombre, string apellidos, string nombreCompletodelCliente, int edades)
        {
            this.idClientes = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nombreCompletodelCliente = nombreCompletodelCliente;
            this.edades = edades;

        }

        public Clientes()
        {

        }
        // Método ToString
        public string ToString()
        {
            nombreCompletodelCliente = nombre + " " + apellidos;

            string k = nombreCompletodelCliente + " " + edades;

            return k;
        }
    }
}
    

