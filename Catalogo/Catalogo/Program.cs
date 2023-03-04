using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Option = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.WriteLine("____________________________Bienvenido____________________________\n");

                Console.WriteLine("____________________________  Menu  ____________________________\n");

                Console.WriteLine("1. Catalogo de camisas\n");
                Console.WriteLine("2. Catalogo de pantalones\n");
                Console.WriteLine("3. Catalogo de vestidos\n");
                Console.WriteLine("4. Catalogo de zapatos\n");
                Console.WriteLine("5. Catalogo  de articulos con descuento\n");
                Console.WriteLine("6. Salir\n");
                Console.Write("Seleccione una opción (1-6): ");

                Option = Convert.ToInt32(Console.ReadLine());



                switch (Option)
                {
                    case 1:
                        Console.WriteLine("\n¡Ha seleccionado la Opción A! Presione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\n¡Ha seleccionado la Opción B! Presione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\n¡Ha seleccionado la Opción C! Presione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\n¡Ha seleccionado la Opción B! Presione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("\n¡Ha seleccionado la Opción C! Presione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("\n¡Gracias por usar nuestro catalogo! Presione una tecla para salir.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nERROR: La opcion seleccionada es icorrecta ");
                        
                        break;
                }
                Console.ReadKey();
            }
            while (Option !=6);
            Console.ReadLine();


        }
        

    }
   
}
