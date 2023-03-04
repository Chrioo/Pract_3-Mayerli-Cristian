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
            //Clases de Camisas
            camisaOxford camisaOxford = new camisaOxford();
            CamisasdeVestir camisasdeVestir = new CamisasdeVestir();
            Camisadefranela camisadefranela= new Camisadefranela(); 
            Camisapolo camisapolo= new Camisapolo();
            Camisa_hawaiana camisa_Hawaiana= new Camisa_hawaiana();
            CamisaDedenim  camisaDedenim= new CamisaDedenim();  
            Camisadecuadros camisadecuadros = new Camisadecuadros();    
            Camisadelino camisadelino = new Camisadelino(); 
            Camisademangacorta camisademangacorta = new Camisademangacorta();
            Camisawestern camisawestern = new Camisawestern();
            //Clases de Pantalones
            PantalonVaquero pantalonVaquero = new PantalonVaquero();
            PantalonRecto pantalonRecto = new PantalonRecto();
            Pantalon_Skynni pantalon_Skynni = new Pantalon_Skynni();
            PantalonSlim_fit pantalonSlim_Fit = new PantalonSlim_fit();
            PantalonesRegular_Fit pantalonesRegular_Fit= new PantalonesRegular_Fit();
            Pantalones_Loose pantalones_Loose = new Pantalones_Loose();
            PantalonRelax_fit pantalonRelax_Fit = new PantalonRelax_fit();
            PantaloDrop_Croatch pantaloDrop_Croatch = new PantaloDrop_Croatch();
            PantalónHigh_rise pantalónHigh_Rise = new PantalónHigh_rise();
            PantalónLow_rise pantalónLow_Rise = new PantalónLow_rise();
             //Clases de vestidos
             vestidoGala vestidoGala = new vestidoGala();
            vestidoCoctel vestidoCoctel= new vestidoCoctel();
            vestidolargo vestidolargo = new vestidolargo(); 
            vestidoCorto vestidoCorto=new vestidoCorto();
            vestidoNovia vestidoNovia = new vestidoNovia();
            vestidoFiesta vestidoFiesta = new vestidoFiesta();
            vestidoNoche vestidoNoche= new vestidoNoche();
            vestidoTubo vestidoTubo=new vestidoTubo();
            vestidoEncaje vestidoEncaje = new vestidoEncaje();
            vestidoSeda vestidoSeda=new vestidoSeda();
            //Clases de zapatos
            ZapatosTaconAlto taconAlto = new ZapatosTaconAlto();
            ZapatosTaconBajo taconBajo = new ZapatosTaconBajo();
            ZapatosPlataforma plataforma = new ZapatosPlataforma();
            ZapatosC zapatosC = new ZapatosC();
            ZapatosPunta zapatosPunta = new ZapatosPunta();
            ZapatosBallet zapatosBallet = new ZapatosBallet();
            ZapatosSalon zapatosSalon = new ZapatosSalon();
            ZapatosCuero zapatosCuero = new ZapatosCuero();
            ZapatosGamuza zapatosGamuza = new ZapatosGamuza();
            ZapatosCharol zapatosCharol = new ZapatosCharol();

            //Clases de articulos con descuento
            MochilaPortatil mochilaPortatil = new MochilaPortatil();
            MochilaEscolar mochilaEscolar = new MochilaEscolar();
            MochilaViaje mochilaViaje = new MochilaViaje();
            ZapatoDeBallet zapatoDeBallet = new ZapatoDeBallet();
            ZapatoDeCuero zapatoDeCuero = new ZapatoDeCuero();
            ZapatoDeCharol zapatoDeCharol = new ZapatoDeCharol();
            VestidoDeGala vestidoDeGala = new VestidoDeGala();
            VestidoDeNoche vestidoDeNoche = new VestidoDeNoche();
            VestidoDeSeda vestidoDeSeda = new VestidoDeSeda();

            string Option;
            //Lista de generos para las prendas
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
                            "1-Camisa Oxforn","2-Camisa de vestir","3-Camisa de franela","4-Camisa polo","5-Camisa hawaiana","6-Camisa de denim","7-Camisa de lino","8-Camisa de manga corta","9-Camisa western","10-Camisa de cuadros","11-Salir"

                        };
                        foreach (string camisa in camisas)
                        {
                            Console.WriteLine(camisa);
                        }
                        List<string> tallaCamisa = new List<string>() { "XS extra pequeña", "S pequeña", "M mediana", "L grande", "XL extra grande", "XXL doble extra grande", "XXXL triple extra grande" };
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
                                    Console.WriteLine("\nTalla: " + tallaCamisa[1]);
                                    Console.WriteLine("\nGenero: "+ genero[1]);
                                    Console.WriteLine("\nCalidad: " + camisaOxford.calidad());
                                    Console.WriteLine("\nEstilo: " + camisaOxford.estilo());
                                    Console.WriteLine("\nColor: " + camisaOxford.color());
                                    Console.WriteLine("\nPrecio: " + camisaOxford.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    camisaOxford.pagarcamisaOxford();

                                    Console.ReadKey();

                                    break;
                                case "2":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 2! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + camisas[0]);
                                    Console.WriteLine("\nTalla: " + tallaCamisa[2]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + camisasdeVestir.calidad());
                                    Console.WriteLine("\nEstilo: " + camisasdeVestir.estilo());
                                    Console.WriteLine("\nColor: " + camisasdeVestir.color());
                                    Console.WriteLine("\nPrecio: " + camisasdeVestir.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    camisasdeVestir.pagarCamisasdeVestir();
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 3! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + camisas[2]);
                                    Console.WriteLine("\nTalla: " + tallaCamisa[3]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + camisadefranela.calidad());
                                    Console.WriteLine("\nEstilo: " + camisadefranela.estilo());
                                    Console.WriteLine("\nColor: " + camisadefranela.color());
                                    Console.WriteLine("\nPrecio: " + camisadefranela.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    camisadefranela.pagarCamisadefranela();
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 4! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + camisas[3]);
                                    Console.WriteLine("\nTalla: " + tallaCamisa[2]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + camisapolo.calidad());
                                    Console.WriteLine("\nEstilo: " + camisapolo.estilo());
                                    Console.WriteLine("\nColor: " + camisapolo.color());
                                    Console.WriteLine("\nPrecio: " + camisapolo.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    camisapolo.pagarCamisapolo();
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 5! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + camisas[4]);
                                    Console.WriteLine("\nTalla: " + tallaCamisa[2]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + camisa_Hawaiana.calidad());
                                    Console.WriteLine("\nEstilo: " + camisa_Hawaiana.estilo());
                                    Console.WriteLine("\nColor: " + camisa_Hawaiana.color());
                                    Console.WriteLine("\nPrecio: " + camisa_Hawaiana.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    camisa_Hawaiana.pagarCamisa_hawaiana();
                                    Console.ReadKey();
                                    break;
                                case "6":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 6! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + camisas[5]);
                                    Console.WriteLine("\nTalla: " + tallaCamisa[3]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + camisaDedenim.calidad());
                                    Console.WriteLine("\nEstilo: " + camisaDedenim.estilo());
                                    Console.WriteLine("\nColor: " + camisaDedenim.color());
                                    Console.WriteLine("\nPrecio: " + camisaDedenim.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    camisaDedenim.pagarCamisaDedenim();
                                    Console.ReadKey();
                                    break;
                                case "7":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 7! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + camisas[6]);
                                    Console.WriteLine("\nTalla: " + tallaCamisa[3]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + camisadelino.calidad());
                                    Console.WriteLine("\nEstilo: " + camisadelino.estilo());
                                    Console.WriteLine("\nColor: " + camisadelino.color());
                                    Console.WriteLine("\nPrecio: " + camisadelino.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    camisadelino.pagarCamisadelino();
                                    Console.ReadKey();
                                    break;
                                case "8":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 8! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + camisas[7]);
                                    Console.WriteLine("\nTalla: " + tallaCamisa[2]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + camisademangacorta.calidad());
                                    Console.WriteLine("\nEstilo: " + camisademangacorta.estilo());
                                    Console.WriteLine("\nColor: " + camisademangacorta.color());
                                    Console.WriteLine("\nPrecio: " + camisademangacorta.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    camisademangacorta.pagarCamisademangacorta();
                                    Console.ReadKey();
                                    break;
                                case "9":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 9! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + camisas[8]);
                                    Console.WriteLine("\nTalla: " + tallaCamisa[2]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + camisawestern.calidad());
                                    Console.WriteLine("\nEstilo: " + camisawestern.estilo());
                                    Console.WriteLine("\nColor: " + camisawestern.color());
                                    Console.WriteLine("\nPrecio: " + camisawestern.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    camisawestern.pagarCamisawestern();
                                    Console.ReadKey();
                                    break;
                                case "10":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 10! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + camisas[9]);
                                    Console.WriteLine("\nTalla: " + tallaCamisa[2]);
                                    Console.WriteLine("\nGenero: " + genero[3]);
                                    Console.WriteLine("\nCalidad: " + camisadecuadros.calidad());
                                    Console.WriteLine("\nEstilo: " + camisadecuadros.estilo());
                                    Console.WriteLine("\nColor: " + camisadecuadros.color());
                                    Console.WriteLine("\nPrecio: " + camisadecuadros.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    camisadecuadros.pagarCamisadecuadros();
                                    Console.ReadKey();
                                    break;
                                case "11":
                                    Console.WriteLine("¡Eligio salir! fin de las consultas");
                                    break;
                                default:
                                    Console.WriteLine("Opción inválida");
                                    break;
                            }

                        }
                        while (Option != "11");
                       
                        Console.ReadKey();
                        break;
                    case "2":

                        Console.Clear();
                        Console.WriteLine("\n¡Ha seleccionado la Opción 2! Presione una tecla para continuar.");
                        Console.WriteLine("-----------------------Catalogo de Pantalones-----------------------\n");
                        List<string> pantalones = new List<string>()
                        {
                            "1-PantalonVaquero","2-PantalonRecto","3-Pantalon_Skynni","4-PantalonSlim_fit","5-PantalonesRegular_Fit","6-Pantalones_Loose","7-PantalonRelax_fit","8-PantaloDrop_Croatch","9-PantalónHigh_rise","10-PantalónLow_rise","11-Salir"

                        };
                        foreach (string pantalon in pantalones)
                        {
                            Console.WriteLine(pantalon);
                        }
                        List<string> tallaPantalones = new List<string>() { "XS extra pequeña", "S pequeña", "M mediana", "L grande", "XL extra grande", "XXL doble extra grande", "XXXL triple extra grande" };
                        do
                        {
                            Console.WriteLine("Ingresa un número del 1 al 5:");
                            Option = Console.ReadLine();

                            switch (Option)
                            {
                                case "1":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 1! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + pantalones[0]);
                                    Console.WriteLine("\nTalla: " + tallaPantalones[1]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + pantalonVaquero.calidad());
                                    Console.WriteLine("\nEstilo: " + pantalonVaquero.estilo());
                                    Console.WriteLine("\nColor: " + pantalonVaquero.color());
                                    Console.WriteLine("\nPrecio: " + pantalonVaquero.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    pantalonVaquero.pagarPantalonVaquero();

                                    Console.ReadKey();

                                    break;
                                case "2":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 2! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + pantalones[0]);
                                    Console.WriteLine("\nTalla: " + tallaPantalones[2]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + pantalonRecto.calidad());
                                    Console.WriteLine("\nEstilo: " + pantalonRecto.estilo());
                                    Console.WriteLine("\nColor: " + pantalonRecto.color());
                                    Console.WriteLine("\nPrecio: " + pantalonRecto.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    pantalonRecto.pagarPantalonRecto();
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 3! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + pantalones[2]);
                                    Console.WriteLine("\nTalla: " + tallaPantalones[3]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + pantalon_Skynni.calidad());
                                    Console.WriteLine("\nEstilo: " + pantalon_Skynni.estilo());
                                    Console.WriteLine("\nColor: " + pantalon_Skynni.color());
                                    Console.WriteLine("\nPrecio: " + pantalon_Skynni.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    pantalon_Skynni.pagarPantalon_Skynni();
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 4! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + pantalones[3]);
                                    Console.WriteLine("\nTalla: " + tallaPantalones[2]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + pantalonSlim_Fit.calidad());
                                    Console.WriteLine("\nEstilo: " + pantalonSlim_Fit.estilo());
                                    Console.WriteLine("\nColor: " + pantalonSlim_Fit.color());
                                    Console.WriteLine("\nPrecio: " + pantalonSlim_Fit.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    pantalonSlim_Fit.pagarPantalonSlim_fit();
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 5! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + pantalones[4]);
                                    Console.WriteLine("\nTalla: " + tallaPantalones[2]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + pantalonesRegular_Fit.calidad());
                                    Console.WriteLine("\nEstilo: " + pantalonesRegular_Fit.estilo());
                                    Console.WriteLine("\nColor: " + pantalonesRegular_Fit.color());
                                    Console.WriteLine("\nPrecio: " + pantalonesRegular_Fit.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    pantalonesRegular_Fit.pagarPantalonesRegular_Fit();
                                    Console.ReadKey();
                                    break;
                                case "6":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 6! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + pantalones[5]);
                                    Console.WriteLine("\nTalla: " + tallaPantalones[3]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + pantalones_Loose.calidad());
                                    Console.WriteLine("\nEstilo: " + pantalones_Loose.estilo());
                                    Console.WriteLine("\nColor: " + pantalones_Loose.color());
                                    Console.WriteLine("\nPrecio: " + pantalones_Loose.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    pantalones_Loose.pagarPantalones_Loose();
                                    Console.ReadKey();
                                    break;
                                case "7":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 7! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + pantalones[6]);
                                    Console.WriteLine("\nTalla: " + tallaPantalones[3]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + pantalonRelax_Fit.calidad());
                                    Console.WriteLine("\nEstilo: " + pantalonRelax_Fit.estilo());
                                    Console.WriteLine("\nColor: " + pantalonRelax_Fit.color());
                                    Console.WriteLine("\nPrecio: " + pantalonRelax_Fit.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    pantalonRelax_Fit.pagarPantalonRelax_fit();
                                    Console.ReadKey();
                                    break;
                                case "8":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 8! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + pantalones[7]);
                                    Console.WriteLine("\nTalla: " + tallaPantalones[2]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + pantaloDrop_Croatch.calidad());
                                    Console.WriteLine("\nEstilo: " + pantaloDrop_Croatch.estilo());
                                    Console.WriteLine("\nColor: " + pantaloDrop_Croatch.color());
                                    Console.WriteLine("\nPrecio: " + pantaloDrop_Croatch.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    pantaloDrop_Croatch.pagarPantaloDrop_Croatch();
                                    Console.ReadKey();
                                    break;
                                case "9":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 9! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + pantalones[8]);
                                    Console.WriteLine("\nTalla: " + tallaPantalones[2]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nCalidad: " + pantalónHigh_Rise.calidad());
                                    Console.WriteLine("\nEstilo: " + pantalónHigh_Rise.estilo());
                                    Console.WriteLine("\nColor: " + pantalónHigh_Rise.color());
                                    Console.WriteLine("\nPrecio: " + pantalónHigh_Rise.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    pantalónHigh_Rise.pagarPantalónHigh_risee();
                                    Console.ReadKey();
                                    break;
                                case "10":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 10! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + pantalones[9]);
                                    Console.WriteLine("\nTalla: " + tallaPantalones[2]);
                                    Console.WriteLine("\nGenero: " + genero[3]);
                                    Console.WriteLine("\nCalidad: " + pantalónLow_Rise.calidad());
                                    Console.WriteLine("\nEstilo: " + pantalónLow_Rise.estilo());
                                    Console.WriteLine("\nColor: " + pantalónLow_Rise.color());
                                    Console.WriteLine("\nPrecio: " + pantalónLow_Rise.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    pantalónLow_Rise.pagarPantalónLow_rise();
                                    Console.ReadKey();
                                    break;

                            }
                        }
                        while (Option != "11");
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
                        List<string> tallaVestido = new List<string>() { "XS extra pequeña", "S pequeña", "M mediana", "L grande", "XL extra grande", "XXL doble extra grande", "XXXL triple extra grande" };
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
                                    Console.WriteLine("\nCalidad: " + vestidoGala.calidad());
                                    Console.WriteLine("\nEstilo: " + vestidoGala.estilo());
                                    Console.WriteLine("\nColor: " + vestidoGala.color());
                                    Console.WriteLine("\nPrecio: $" + vestidoGala.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    vestidoGala.pagarVestidoGala();
                                    Console.ReadKey();

                                    break;
                                case "2":
                                    
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 2! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + vestidos[1]);
                                    Console.WriteLine("\nTalla: " + tallaVestido[2]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + vestidoCoctel.calidad());
                                    Console.WriteLine("\nEstilo: " + vestidoCoctel.estilo());
                                    Console.WriteLine("\nColor: " + vestidoCoctel.color());
                                    Console.WriteLine("\nPrecio: $" + vestidoCoctel.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    vestidoCoctel.pagarVestidoCoctel();
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 3! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + vestidos[2]);
                                    Console.WriteLine("\nTalla: " + tallaVestido[3]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + vestidolargo.calidad());
                                    Console.WriteLine("\nEstilo: " + vestidolargo.estilo());
                                    Console.WriteLine("\nColor: " + vestidolargo.color());
                                    Console.WriteLine("\nPrecio: $" + vestidolargo.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    vestidolargo.pagarVestidoLargo();
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 4! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + vestidos[3]);
                                    Console.WriteLine("\nTalla: " + tallaVestido[1]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + vestidoCorto.calidad());
                                    Console.WriteLine("\nEstilo: " + vestidoCorto.estilo());
                                    Console.WriteLine("\nColor: " + vestidoCorto.color());
                                    Console.WriteLine("\nPrecio: $" + vestidoCorto.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    vestidoCorto.pagarVestidoCorto();
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 5! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + vestidos[4]);
                                    Console.WriteLine("\nTalla: " + tallaVestido[4]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + vestidoNovia.calidad());
                                    Console.WriteLine("\nEstilo: " + vestidoNovia.estilo());
                                    Console.WriteLine("\nColor: " + vestidoNovia.color());
                                    Console.WriteLine("\nPrecio: $" + vestidoNovia.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    vestidoNovia.pagarVestidoNovia();
                                    Console.ReadKey();
                                    break;
                                case "6":
                                    
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 6! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + vestidos[5]);
                                    Console.WriteLine("\nTalla: " + tallaVestido[5]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + vestidoFiesta.calidad());
                                    Console.WriteLine("\nEstilo: " + vestidoFiesta.estilo());
                                    Console.WriteLine("\nColor: " + vestidoFiesta.color());
                                    Console.WriteLine("\nPrecio: $" + vestidoFiesta.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    vestidoFiesta.pagarVestidoFiesta();
                                    Console.ReadKey();
                                    break;
                                case "7":
                                    
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 7! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + vestidos[6]);
                                    Console.WriteLine("\nTalla: " + tallaVestido[0]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + vestidoNoche.calidad());
                                    Console.WriteLine("\nEstilo: " + vestidoNoche.estilo());
                                    Console.WriteLine("\nColor: " + vestidoNoche.color());
                                    Console.WriteLine("\nPrecio: $" + vestidoNoche.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    vestidoNoche.pagarVestidoNoche();
                                    Console.ReadKey();
                                    break;
                                case "8":
                                    
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 8! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + vestidos[7]);
                                    Console.WriteLine("\nTalla: " + tallaVestido[3]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + vestidoTubo.calidad());
                                    Console.WriteLine("\nEstilo: " + vestidoTubo.estilo());
                                    Console.WriteLine("\nColor: " + vestidoTubo.color());
                                    Console.WriteLine("\nPrecio: $" + vestidoTubo.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    vestidoTubo.pagarVestidoTubo();
                                    Console.ReadKey();
                                    break;
                                case "9":
                                    
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 9! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + vestidos[8]);
                                    Console.WriteLine("\nTalla: " + tallaVestido[2]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + vestidoEncaje.calidad());
                                    Console.WriteLine("\nEstilo: " + vestidoEncaje.estilo());
                                    Console.WriteLine("\nColor: " + vestidoEncaje.color());
                                    Console.WriteLine("\nPrecio: $" + vestidoEncaje.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    vestidoEncaje.pagarVestidoEncaje();
                                    Console.ReadKey();
                                    break;
                                case "10":
                                    
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 10! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + vestidos[9]);
                                    Console.WriteLine("\nTalla: " + tallaVestido[0]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + vestidoSeda.calidad());
                                    Console.WriteLine("\nEstilo: " + vestidoSeda.estilo());
                                    Console.WriteLine("\nColor: " + vestidoSeda.color());
                                    Console.WriteLine("\nPrecio: $" + vestidoSeda.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    vestidoSeda.pagarVestidoSeda();
                                    Console.ReadKey();
                                    break;
                                case "11":
                                    Console.WriteLine("¡Eligio salir! fin de las consultas");
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
                        //talla desde el 0 al 8
                        List<string> tallaZapato = new List<string>() { "5", "6", "7", "8", "9", "10", "11", "12", "13"};
                        //marca desde el 0 al 9
                        List<string> marca = new List<string>() { "Nike", "Adidas", "Puma", "Vans", "New Balance", "Gucci", "Prada", "Balenciaga", "Jimmy Choo", "Stuart Weitzman." };
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
                                    Console.WriteLine("\nMarca: " + marca[0]);
                                    Console.WriteLine("\nCalidad: " + taconAlto.calidad());
                                    Console.WriteLine("\nEstilo: " + taconAlto.estilo());
                                    Console.WriteLine("\nColor: " + taconAlto.color());
                                    Console.WriteLine("\nMaterial: " + taconAlto.material());
                                    Console.WriteLine("\nPrecio: $" +taconAlto.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    taconAlto.pagarTaconAlto();
                                    Console.ReadKey();

                                    break;
                                case "2":

                                    Console.WriteLine("\n¡Ha seleccionado la Opción 2! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + zapatos[1]);
                                    Console.WriteLine("\nTalla: " + tallaZapato[4]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nMarca: " + marca[8]);
                                    Console.WriteLine("\nCalidad: " + taconBajo.calidad());
                                    Console.WriteLine("\nEstilo: " + taconBajo.estilo());
                                    Console.WriteLine("\nColor: " + taconBajo.color());
                                    Console.WriteLine("\nMaterial: " + taconBajo.material());
                                    Console.WriteLine("\nPrecio: $" + taconBajo.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    taconBajo.pagarTaconBajo();
                                    Console.ReadKey();
                                    break;
                                case "3":

                                    Console.WriteLine("\n¡Ha seleccionado la Opción 3! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + zapatos[2]);
                                    Console.WriteLine("\nTalla: " + tallaZapato[3]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nMarca: " + marca[6]);
                                    Console.WriteLine("\nCalidad: " + plataforma.calidad());
                                    Console.WriteLine("\nEstilo: " + plataforma.estilo());
                                    Console.WriteLine("\nColor: " + plataforma.color());
                                    Console.WriteLine("\nMaterial: " + plataforma.material());
                                    Console.WriteLine("\nPrecio: $" + plataforma.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    plataforma.pagarPlataforma();
                                    Console.ReadKey();
                                    break;
                                case "4":

                                    Console.WriteLine("\n¡Ha seleccionado la Opción 4! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + zapatos[3]);
                                    Console.WriteLine("\nTalla: " + tallaZapato[3]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nMarca: " + marca[4]);
                                    Console.WriteLine("\nCalidad: " + zapatosC.calidad());
                                    Console.WriteLine("\nEstilo: " + zapatosC.estilo());
                                    Console.WriteLine("\nColor: " + zapatosC.color());
                                    Console.WriteLine("\nMaterial: " + zapatosC.material());
                                    Console.WriteLine("\nPrecio: $" + zapatosC.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    zapatosC.pagarC();
                                    Console.ReadKey();
                                    break;
                                case "5":

                                    Console.WriteLine("\n¡Ha seleccionado la Opción 5! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + zapatos[4]);
                                    Console.WriteLine("\nTalla: " + tallaZapato[5]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nMarca: " + marca[0]);
                                    Console.WriteLine("\nCalidad: " + zapatosPunta.calidad());
                                    Console.WriteLine("\nEstilo: " + zapatosPunta.estilo());
                                    Console.WriteLine("\nColor: " + zapatosPunta.color());
                                    Console.WriteLine("\nMaterial: " + zapatosPunta.material());
                                    Console.WriteLine("\nPrecio: $" + zapatosPunta.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    zapatosPunta.pagarPunta();
                                    Console.ReadKey();
                                    break;
                                case "6":

                                    Console.WriteLine("\n¡Ha seleccionado la Opción 6! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + zapatos[5]);
                                    Console.WriteLine("\nTalla: " + tallaZapato[4]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nMarca: " + marca[2]);
                                    Console.WriteLine("\nCalidad: " + zapatosBallet.calidad());
                                    Console.WriteLine("\nEstilo: " + zapatosBallet.estilo());
                                    Console.WriteLine("\nColor: " + zapatosBallet.color());
                                    Console.WriteLine("\nMaterial: " + zapatosBallet.material());
                                    Console.WriteLine("\nPrecio: $" + zapatosBallet.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    zapatosBallet.pagarBallet();
                                    Console.ReadKey();
                                    break;
                                case "7":

                                    Console.WriteLine("\n¡Ha seleccionado la Opción 7! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + zapatos[6]);
                                    Console.WriteLine("\nTalla: " + tallaZapato[8]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nMarca: " + marca[9]);
                                    Console.WriteLine("\nCalidad: " + zapatosSalon.calidad());
                                    Console.WriteLine("\nEstilo: " + zapatosSalon.estilo());
                                    Console.WriteLine("\nColor: " + zapatosSalon.color());
                                    Console.WriteLine("\nMaterial: " + zapatosSalon.material());
                                    Console.WriteLine("\nPrecio: $" + zapatosSalon.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    zapatosSalon.pagarSalon();
                                    Console.ReadKey();
                                    break;
                                case "8":

                                    Console.WriteLine("\n¡Ha seleccionado la Opción 8! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + zapatos[7]);
                                    Console.WriteLine("\nTalla: " + tallaZapato[7]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nMarca: " + marca[4]);
                                    Console.WriteLine("\nCalidad: " + zapatosCuero.calidad());
                                    Console.WriteLine("\nEstilo: " + zapatosCuero.estilo());
                                    Console.WriteLine("\nColor: " + zapatosCuero.color());
                                    Console.WriteLine("\nMaterial: " + zapatosCuero.material());
                                    Console.WriteLine("\nPrecio: $" + zapatosCuero.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    zapatosCuero.pagarCuero();
                                    Console.ReadKey();
                                    break;
                                case "9":

                                    Console.WriteLine("\n¡Ha seleccionado la Opción 9! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + zapatos[8]);
                                    Console.WriteLine("\nTalla: " + tallaZapato[1]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nMarca: " + marca[0]);
                                    Console.WriteLine("\nCalidad: " + zapatosGamuza.calidad());
                                    Console.WriteLine("\nEstilo: " + zapatosGamuza.estilo());
                                    Console.WriteLine("\nColor: " + zapatosGamuza.color());
                                    Console.WriteLine("\nMaterial: " + zapatosGamuza.material());
                                    Console.WriteLine("\nPrecio: $" + zapatosGamuza.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    zapatosGamuza.pagarGamuza();
                                    Console.ReadKey();
                                    break;
                                case "10":

                                    Console.WriteLine("\n¡Ha seleccionado la Opción 10! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: " + zapatos[9]);
                                    Console.WriteLine("\nTalla: " + tallaZapato[6]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nMarca: " + marca[6]);
                                    Console.WriteLine("\nCalidad: " + zapatosCharol.calidad());
                                    Console.WriteLine("\nEstilo: " + zapatosCharol.estilo());
                                    Console.WriteLine("\nColor: " + zapatosCharol.color());
                                    Console.WriteLine("\nMaterial: " + zapatosCharol.material());
                                    Console.WriteLine("\nPrecio: $" + zapatosCharol.precio());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    zapatosCharol.pagarCharol();
                                    Console.ReadKey();
                                    break;
                                case "11":
                                    Console.WriteLine("¡Eligio salir! fin de las consultas");
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

                        Console.WriteLine("-----------------------Mochilas-----------------------\n");
                        Console.WriteLine("\n1 - Mochila para portatil-----------------------------$45.00-------20%");
                        Console.WriteLine("\n2 - Mochila escolar-----------------------------------$20.50-------10%");
                        Console.WriteLine("\n3 - Michila para viajes-----------------------------  $100.0-------50%\n");

                        Console.WriteLine("-----------------------Zapatos-----------------------\n");
                        Console.WriteLine("\n4 - Zapatos de ballet---------------------------------$90.0-------50%");
                        Console.WriteLine("\n5 - Zapatos de cuero----------------------------------$50.0-------30%");
                        Console.WriteLine("\n6 - Zapatos de charol---------------------------------$66.0-------40%\n");

                        Console.WriteLine("-----------------------Vestidos-----------------------\n");
                        Console.WriteLine("\n7 - Vetido de gala------------------------------------$56.90-------20%");
                        Console.WriteLine("\n8 - Vestido de noche----------------------------------$90.0-------10%");
                        Console.WriteLine("\n9 - Vestido de seda-----------------------------------$20.0-------10% \n");

                        Console.WriteLine("----------------------------------------------\n");
                        Console.WriteLine("\n10 - Salir");
                        List<string> tallaZapatoArticulo = new List<string>() { "5", "6", "7", "8", "9", "10", "11", "12", "13" };
                        //marca desde el 0 al 9
                        List<string> marcaArticulo = new List<string>() { "Nike", "Adidas", "Puma", "Vans", "New Balance", "Gucci", "Prada", "Balenciaga", "Jimmy Choo", "Stuart Weitzman." };
                        List<string> tallaArticulo = new List<string>() { "XS extra pequeña", "S pequeña", "M mediana", "L grande", "XL extra grande", "XXL doble extra grande", "XXXL triple extra grande" };
                        do
                        {
                            Console.WriteLine("Ingresa un número del 1 al 10:");
                            Option = Console.ReadLine();

                            switch (Option)
                            {
                                case "1":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 1! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto:  Mochila para portatil" );
                                    Console.WriteLine("\nCalidad: " + mochilaPortatil.calidad());
                                    Console.WriteLine("\nEstilo: " + mochilaPortatil.estilo());
                                    Console.WriteLine("\nColor: " + mochilaPortatil.color());
                                    Console.WriteLine("\nPrecio: $" + mochilaPortatil.precio());
                                    Console.WriteLine("\nDescuento: " + mochilaPortatil.descuento());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    mochilaPortatil.pagarMochilaPortatil();
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 2! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto:  Mochila escolar");
                                    Console.WriteLine("\nCalidad: " + mochilaEscolar.calidad());
                                    Console.WriteLine("\nEstilo: " + mochilaEscolar.estilo());
                                    Console.WriteLine("\nColor: " + mochilaEscolar.color());
                                    Console.WriteLine("\nPrecio: $" + mochilaEscolar.precio());
                                    Console.WriteLine("\nDescuento: " + mochilaEscolar.descuento());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    mochilaEscolar.pagarMochilaEscolar();
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 3! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto:  Mochila para viajes");
                                    Console.WriteLine("\nCalidad: " + mochilaViaje.calidad());
                                    Console.WriteLine("\nEstilo: " + mochilaViaje.estilo());
                                    Console.WriteLine("\nColor: " + mochilaViaje.color());
                                    Console.WriteLine("\nPrecio: $" + mochilaViaje.precio());
                                    Console.WriteLine("\nDescuento: " + mochilaViaje.descuento());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    mochilaViaje.pagarMochilaViaje();
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 4! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: zapatos de ballet");
                                    Console.WriteLine("\nTalla: " + tallaZapatoArticulo[4]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nMarca: " + marcaArticulo[2]);
                                    Console.WriteLine("\nCalidad: " + zapatosBallet.calidad());
                                    Console.WriteLine("\nEstilo: " + zapatosBallet.estilo());
                                    Console.WriteLine("\nColor: " + zapatosBallet.color());
                                    Console.WriteLine("\nMaterial: " + zapatosBallet.material());
                                    Console.WriteLine("\nPrecio: $" + zapatosBallet.precio());
                                    Console.WriteLine("\nDescuento: " + zapatoDeBallet.descuento());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    zapatoDeBallet.pagarBalletDescuento();
                                    Console.ReadKey();
                                    break;
                                case "5":

                                    Console.WriteLine("\n¡Ha seleccionado la Opción 5! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: zapatos de cuero");
                                    Console.WriteLine("\nTalla: " + tallaZapatoArticulo[7]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nMarca: " + marcaArticulo[4]);
                                    Console.WriteLine("\nCalidad: " + zapatosCuero.calidad());
                                    Console.WriteLine("\nEstilo: " + zapatosCuero.estilo());
                                    Console.WriteLine("\nColor: " + zapatosCuero.color());
                                    Console.WriteLine("\nMaterial: " + zapatosCuero.material());
                                    Console.WriteLine("\nPrecio: $" + zapatosCuero.precio());
                                    Console.WriteLine("\nDescuento: " + zapatoDeCuero.descuento());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    zapatoDeCuero.pagarCueroDescuento();
                                    Console.ReadKey();
                                    break;
                                case "6":

                                    Console.WriteLine("\n¡Ha seleccionado la Opción 6! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: zapatos de charol");
                                    Console.WriteLine("\nTalla: " + tallaZapatoArticulo[6]);
                                    Console.WriteLine("\nGenero: " + genero[2]);
                                    Console.WriteLine("\nMarca: " + marcaArticulo[6]);
                                    Console.WriteLine("\nCalidad: " + zapatosCharol.calidad());
                                    Console.WriteLine("\nEstilo: " + zapatosCharol.estilo());
                                    Console.WriteLine("\nColor: " + zapatosCharol.color());
                                    Console.WriteLine("\nMaterial: " + zapatosCharol.material());
                                    Console.WriteLine("\nPrecio: $" + zapatosCharol.precio());
                                    Console.WriteLine("\nDescuento: " + zapatoDeCharol.descuento());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    zapatoDeCharol.pagarCharolDescuento();
                                    Console.ReadKey();
                                    break;
                                case "7":
                                    Console.WriteLine("\n¡Ha seleccionado la Opción 7! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: vestido de gala"  );
                                    Console.WriteLine("\nTalla: " + tallaArticulo[1]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + vestidoGala.calidad());
                                    Console.WriteLine("\nEstilo: " + vestidoGala.estilo());
                                    Console.WriteLine("\nColor: " + vestidoGala.color());
                                    Console.WriteLine("\nPrecio: $" + vestidoGala.precio());
                                    Console.WriteLine("\nDescuento: " + vestidoDeGala.descuento());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    vestidoDeGala.pagarGalaDescuento();
                                    Console.ReadKey();
                                    break;
                                case "8":

                                    Console.WriteLine("\n¡Ha seleccionado la Opción 8! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: vestido de noche" );
                                    Console.WriteLine("\nTalla: " + tallaArticulo[0]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + vestidoNoche.calidad());
                                    Console.WriteLine("\nEstilo: " + vestidoNoche.estilo());
                                    Console.WriteLine("\nColor: " + vestidoNoche.color());
                                    Console.WriteLine("\nPrecio: $" + vestidoNoche.precio());
                                    Console.WriteLine("\nDescuento: " + vestidoDeNoche.descuento());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    vestidoDeNoche.pagarNocheDescuento();
                                    Console.ReadKey();
                                    break;
                                case "9":

                                    Console.WriteLine("\n¡Ha seleccionado la Opción 9! ");
                                    Console.WriteLine("********** Datos del producto ********** ");
                                    Console.WriteLine("\nProducto: vestido de seda" );
                                    Console.WriteLine("\nTalla: " + tallaArticulo[0]);
                                    Console.WriteLine("\nGenero: " + genero[1]);
                                    Console.WriteLine("\nCalidad: " + vestidoSeda.calidad());
                                    Console.WriteLine("\nEstilo: " + vestidoSeda.estilo());
                                    Console.WriteLine("\nColor: " + vestidoSeda.color());
                                    Console.WriteLine("\nPrecio: $" + vestidoSeda.precio());
                                    Console.WriteLine("\nDescuento: " + vestidoDeSeda.descuento());
                                    Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                    vestidoDeSeda.pagarSedaDescuento();
                                    Console.ReadKey();
                                    break;
                                case "10":
                                    Console.WriteLine("¡Eligio salir! fin de las consultas");
                                    break;
                                default:
                                    Console.WriteLine("Opción inválida");
                                    break;
                            }

                        }
                        while (Option != "10");

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
