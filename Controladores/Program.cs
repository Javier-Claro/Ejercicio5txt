using Ejercicio5txt.Servicios;
using System;

namespace Ejercicio5txt.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {
            MenuIntfz mi = new MenuImpl();
            OperativaIntfz oi = new OperativaImpl();
            int opcionSeleccionada;
            bool cerrarMenu = false;
            string rutaFile = "C:\\Users\\csi22-jzarcia\\Desktop\\textoACambiar.txt";

            do
            {
                opcionSeleccionada = mi.mostrarMenu();
                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrarMenu |= true;
                        break;
                    case 1:
                        oi.escrituraDeFila(rutaFile);
                        break;
                    case 2:
                        oi.escrituraDePosicion(rutaFile);
                        break;
                    default:
                        Console.WriteLine("No es una opcion valida, vuelvalo a intentar");
                        break;
                }

            } while (!cerrarMenu);
        }
    }
}