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
            camisaOxford camisaOxford = new camisaOxford();
            string Option;
            List<string> genero= new List<string>() { "Hombre", "Mujer", "para Hombre y Mujer" };
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

                Option = Console.ReadLine();



                switch (Option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("\n¡Ha seleccionado la Opción 1! Presione una tecla para continuar.");
                        List<string> camisas = new List<string>()
                        {
                            "1-Camisa Oxforn","2-Camisa de vestir","3-Camisa de franela","4-Camisa polo","5-Camisa hawaiana","6-Camisa de denim","7-Camisa de lino","8-Camisa de manga corta","9-Camisa western","10-Camisa de cuadros","11-Camisa de cuello mao","12-Camisa Henley","13-Camisa de popelina","14-Camisa de seda","15-Salir"

                        };
                        foreach (string camisa in camisas)
                        {
                            Console.WriteLine(camisa);
                        }
                        List<string> tallaCamisa = new List<string>() { "XS: Extra pequeña", "S: Pequeña", "M: Mediana", "L: Grande", "XL: Extra grande", "XXL: Doble extra grande", "XXXL: Triple extra grande" };
                        do
                        {
                            Console.WriteLine("Ingresa un número del 1 al 5:");
                            Option = Console.ReadLine();

                            switch (Option)
                            {
                                case "1":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 1! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + camisas[0]);
                                    Console.WriteLine("\nTalla: " + tallaCamisa[0]);
                                    Console.WriteLine("\nGenero: "+ genero[0]);
                                    Console.WriteLine("\nCalidad: " + camisaOxford.calidad());
                                    Console.WriteLine("\nEstilo: " + camisaOxford.estilo());
                                    Console.WriteLine("\nColor: " + camisaOxford.color());
                                    Console.WriteLine("\nPrecio: " + camisaOxford.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    double pagar = double.Parse(Console.ReadLine());
                                    double total = pagar - camisaOxford.precio();
                                    if (total < 0)
                                    {
                                        Console.WriteLine("Resultado: debe la cantidad de $" + total);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Resultado: su vuelto es de $" + total);
                                    }

                                    Console.ReadKey();

                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                                case "4":
                                    break;
                                case "5":
                                    break;
                                case "6":
                                    break;
                                case "7":
                                    break;
                                case "8":
                                    break;
                                case "9":
                                    break;
                                case "10":
                                    break;
                                case "11":
                                    break;
                                case "12":
                                    break;
                                case "13":
                                    break;
                                case "14":
                                    break;

                                case "15":
                                    Console.WriteLine("Fin de las consultas");
                                    break;
                                default:
                                    Console.WriteLine("Opción inválida");
                                    break;
                            }

                        }
                        while (Option != "15");
                       
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n¡Ha seleccionado la Opción 2! Presione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("\n¡Ha seleccionado la Opción 3! Presione una tecla para continuar.");
                        Console.WriteLine("-----------------------Catalogo de Vestidos-----------------------\n");
                        List<string> vestidos = new List<string>()
                        {
                            "1-Vestido de gala","2-Vestido de cóctel","3-Vestido largo","4-Vestido corto","5-Vestido de novia","6-Vestido de fiesta","7-Vestido de noche","8-Vestido tubo","9-Vestido de encaje","10-Vestido de seda","11-Salir"

                        };
                        foreach (string vestido in vestidos)
                        {
                            Console.WriteLine(vestido);
                        }
                        List<string> tallaVestido = new List<string>() { "XS: Extra pequeña", "S: Pequeña", "M: Mediana", "L: Grande", "XL: Extra grande", "XXL: Doble extra grande", "XXXL: Triple extra grande" };
                        do
                        {
                            Console.WriteLine("Ingresa un número del 1 al 11:");
                            Option = Console.ReadLine();

                            switch (Option)
                            {
                                case "1":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 1! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + vestidos[0]);
                                    Console.WriteLine("\nTalla: " + tallaVestido[1]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + camisaOxford.calidad());
                                    Console.WriteLine("\nEstilo: " + camisaOxford.estilo());
                                    Console.WriteLine("\nColor: " + camisaOxford.color());
                                    Console.WriteLine("\nPrecio: " + camisaOxford.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    double pagar = double.Parse(Console.ReadLine());
                                    double total = pagar - camisaOxford.precio();
                                    if (total < 0)
                                    {
                                        Console.WriteLine("Resultado: debe la cantidad de $" + total);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Resultado: su vuelto es de $" + total);
                                    }

                                    Console.ReadKey();

                                    break;


                                case "11":
                                    Console.WriteLine("Elegiste la opción final");
                                    break;
                                default:
                                    Console.WriteLine("Opción inválida");
                                    break;
                            }

                        }
                        while (Option != "11");

                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("\n¡Ha seleccionado la Opción 4! Presione una tecla para continuar.");
                        Console.WriteLine("-----------------------Catalogo de zapatos-----------------------\n");
                        List<string> zapatos = new List<string>()
                        {
                            "1-Zapatos de tacón alto","2-Zapatos de tacón bajo","3-Zapatos de plataforma","4-Zapatos de cuña","5-Zapatos de punta","6-Zapatos de ballet","7-Zapatos de salón","8-Zapatos de cuero","9-Zapatos de gamuza","10-Zapatos de charol","11-Salir"

                        };
                        foreach (string zapato in zapatos)
                        {
                            Console.WriteLine(zapato);
                        }
                        List<string> tallaZapato = new List<string>() { "5", "6", "7", "8", "9", "10", "11", "12", "13"};
                        do
                        {
                            Console.WriteLine("Ingresa un número del 1 al 11:");
                            Option = Console.ReadLine();

                            switch (Option)
                            {
                                case "1":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 1! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + zapatos[0]);
                                    Console.WriteLine("\nTalla: " + tallaZapato[1]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + camisaOxford.calidad());
                                    Console.WriteLine("\nEstilo: " + camisaOxford.estilo());
                                    Console.WriteLine("\nColor: " + camisaOxford.color());
                                    Console.WriteLine("\nPrecio: " + camisaOxford.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    double pagar = double.Parse(Console.ReadLine());
                                    double total = pagar - camisaOxford.precio();
                                    if (total < 0)
                                    {
                                        Console.WriteLine("Resultado: debe la cantidad de $" + total);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Resultado: su vuelto es de $" + total);
                                    }

                                    Console.ReadKey();

                                    break;


                                case "11":
                                    Console.WriteLine("Elegiste la opción final");
                                    break;
                                default:
                                    Console.WriteLine("Opción inválida");
                                    break;
                            }

                        }
                        while (Option != "11");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("\n¡Ha seleccionado la Opción 5! Presione una tecla para continuar.");
                        Console.WriteLine("-----------------------Catalogo de Articulos con descuento-----------------------\n");
                        List<string> articulos = new List<string>()
                        {
                            "1-Camisa Oxforn","2-Camisa de vestir","3-Camisa de franela","4-Camisa polo","5-Camisa hawaiana","6-Camisa de denim","7-Camisa de lino","8-Camisa de manga corta","9-Camisa western","10-Camisa de cuadros","11-Camisa de cuello mao","12-Camisa Henley","13-Camisa de popelina","14-Camisa de seda","15-Camisa de satén"

                        };
                        foreach (string articulo in articulos)
                        {
                            Console.WriteLine(articulo);
                        }
                        List<string> tallaArticulo = new List<string>() { "XS: Extra pequeña", "S: Pequeña", "M: Mediana", "L: Grande", "XL: Extra grande", "XXL: Doble extra grande", "XXXL: Triple extra grande" };
                        do
                        {
                            Console.WriteLine("Ingresa un número del 1 al 5:");
                            Option = Console.ReadLine();

                            switch (Option)
                            {
                                case "1":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 1! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + articulos[0]);
                                    Console.WriteLine("\nTalla: " + tallaArticulo[0]);
                                    Console.WriteLine("\nCalidad: " + camisaOxford.calidad());
                                    Console.WriteLine("\nEstilo: " + camisaOxford.estilo());
                                    Console.WriteLine("\nColor: " + camisaOxford.color());
                                    Console.WriteLine("\nPrecio: " + camisaOxford.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    double pagar = double.Parse(Console.ReadLine());
                                    double total = pagar - camisaOxford.precio();
                                    if (total < 0)
                                    {
                                        Console.WriteLine("Resultado: debe la cantidad de $" + total);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Resultado: su vuelto es de $" + total);
                                    }

                                    Console.ReadKey();

                                    break;


                                case "15":
                                    Console.WriteLine("Elegiste la opción final");
                                    break;
                                default:
                                    Console.WriteLine("Opción inválida");
                                    break;
                            }

                        }
                        while (Option != "15");

                        Console.ReadKey();
                        break;
                    case "6":
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
            while (Option !="6");
            Console.ReadLine();


        }
        

    }
   
}
