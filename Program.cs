using System;

namespace TiendaCamisas
{
    class Program
    {
        static void Main
            (string[] a)
        {
            // Solicitar la cantidad de camisas y el precio de las camisas al usuario
            Console.Write("Ingrese la cantidad de camisas que desea comprar: ");
            int cantidadCamisas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el precio de una camisa: ");
            double precioCamisa = Convert.ToDouble(Console.ReadLine());

            double costoTotal = 0;

            if (cantidadCamisas == 1)
            {
                // Si se lleva una camisa, el precio es el costo
                costoTotal = precioCamisa;
            }
            else if (cantidadCamisas >= 2 && cantidadCamisas <= 5)
            {
                // Si se lleva entre 2 y 5 camisas, se aplica un descuento del 15%
                costoTotal = cantidadCamisas * precioCamisa * 0.85;
            }
            else if (cantidadCamisas > 5)
            {
                // Si se lleva más de 5 camisas, se aplica un descuento del 20%
                costoTotal = cantidadCamisas * precioCamisa * 0.80;
            }
            else
            {
                Console.WriteLine("Cantidad de camisas no válida. Debe comprar al menos una camisa.");
                return; // Salir del programa si la cantidad no es válida
            }

            Console.WriteLine("Costo total a pagar: C" + costoTotal);

            Console.ReadLine(); // Mantener la consola abierta hasta que el usuario presione Enter
        }
    }
}
