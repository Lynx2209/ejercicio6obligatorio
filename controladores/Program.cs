using ejercicio6obligatorio.Dtos;
using ejercicio6obligatorio.servicios;

namespace ejercicio6.obligatorio.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lista para almacenar los clientes
            List<Clientes> listadelosClientes = new List<Clientes>();

            // Llamamos a las interfaces
            MenuInterfaz landa = new Menuimplementacion();
            Operativainterfaz alpha = new Operativaimplementacion();

            bool cerrarMenu = false;

            int opcionSeleccionada;

            // Bucle esencial y principal del menú
            while (!cerrarMenu)
            {
                // Muestra el menú y obtiene la selección del usuario
                opcionSeleccionada = landa.menuYSeleccion();

                // Evalúa la opción seleccionada
                switch (opcionSeleccionada)
                {
                    // Cierra el menú
                    case 0:
                        cerrarMenu |= true;
                        Console.WriteLine("Menu cerrado");
                        break;
                    // Agrega un nuevo cliente 
                    case 1:
                        Console.WriteLine("Dar alta a los cliente");
                        alpha.añadirClientes(listadelosClientes);
                        break;
                    // Ordena la lista de clientes por edad si la opción en la opción dos 
                    case 2:
                        alpha.ordenarEdades(listadelosClientes);

                        break;
                }
            }


        }
    }
}