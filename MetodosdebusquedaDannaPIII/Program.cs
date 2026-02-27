using System;

namespace MetodosBusqueda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];

            for (int i = 0; i < 20; i++)
            {
                numeros[i] = i + 1;
            }

            Console.WriteLine("METODOS DE BUSQUEDA");
            Console.WriteLine("1. Búsqueda Lineal");
            Console.WriteLine("2. Búsqueda Binaria");
            Console.Write("Seleccione el método (1 o 2): ");
            int opcion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un número del 1 al 20 para buscar: ");
            int numeroBuscar = int.Parse(Console.ReadLine());

            if (numeroBuscar < 1 || numeroBuscar > 20)
            {
                Console.WriteLine("Número fuera del rango permitido.");
                Console.ReadKey();
                return;
            }

            int indice = -1;

            if (opcion == 1)
            {
                Console.WriteLine("\nBuscando con método Lineal...");
                indice = BusquedaLineal(numeros, numeroBuscar);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("\nBuscando con método Binario...");
                indice = BusquedaBinaria(numeros, numeroBuscar);
            }
            else
            {
                Console.WriteLine("Opción inválida.");
                Console.ReadKey();
                return;
            }

            if (indice != -1)
            {
                Console.WriteLine($"\nEl número {numeroBuscar} se encontró en el índice: {indice}");
            }
            else
            {
                Console.WriteLine("\nNúmero no encontrado.");
            }

            Console.ReadKey();
        }

       
        static int BusquedaLineal(int[] arreglo, int valor)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Revisando posición " + i + "...");

                if (arreglo[i] == valor)
                {
                    return i;
                }
            }
            return -1;
        }

       
        static int BusquedaBinaria(int[] arreglo, int valor)
        {
            int izquierda = 0;
            int derecha = arreglo.Length - 1;

            while (izquierda <= derecha)
            {
                Console.WriteLine("Dividiendo el arreglo y verificando el punto medio...");

                int medio = (izquierda + derecha) / 2;

                if (arreglo[medio] == valor)
                    return medio;
                else if (arreglo[medio] < valor)
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }

            return -1;
        }
    }
}