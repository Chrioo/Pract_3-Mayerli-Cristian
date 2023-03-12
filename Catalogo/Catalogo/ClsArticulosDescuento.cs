using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    abstract class ArticulosDescuento
    {
        
        public abstract string descuento();
        

    }
    class MochilaPortatil : ArticulosDescuento
    {
        public override string descuento()
        {
            return "20%";

        }
        public  string calidad()
        {
            return " gama alta";
        }

        public  string color()
        {
            return " negro";
        }

        public string estilo()
        {
            return " negro con diseño de caricaturas";
        }

        public double precio()
        {
            return 45;
        }
        public void pagarMochilaPortatil()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = precio() - (precio() * 0.20);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class MochilaEscolar : ArticulosDescuento
    {
        public override string descuento()
        {
            return "10%";

        }
        public string calidad()
        {
            return " gama alta";
        }

        public string color()
        {
            return " verde";
        }

        public string estilo()
        {
            return " verde con diseño de disney";
        }

        public double precio()
        {
            return 20.50;
        }
        public void pagarMochilaEscolar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = precio() - (precio() * 0.10);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class MochilaViaje : ArticulosDescuento
    {
        public override string descuento()
        {
            return "50%";

        }
        public string calidad()
        {
            return " gama alta";
        }

        public string color()
        {
            return " azul";
        }

        public string estilo()
        {
            return " todo azul";
        }

        public double precio()
        {
            return 100;
        }
        public void pagarMochilaViaje()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = precio() - (precio() * 0.50);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class ZapatoDeBallet : ArticulosDescuento
    {
        ZapatosBallet zapatosBallet = new ZapatosBallet();
       
        public override string descuento()
        {
            return "50%";
        }
        public void pagarBalletDescuento()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = zapatosBallet.precio() - (zapatosBallet.precio() * 0.50);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class ZapatoDeCuero : ArticulosDescuento
    {
        
        ZapatosCuero zapatosCuero = new ZapatosCuero();
        
        public override string descuento()
        {
            return "30%";
        }
        public void pagarCueroDescuento()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = zapatosCuero.precio() - (zapatosCuero.precio() * 0.30);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class ZapatoDeCharol : ArticulosDescuento
    {
        
        ZapatosCharol zapatosCharol = new ZapatosCharol();
        public override string descuento()
        {
            return "40%";
        }
        public void pagarCharolDescuento()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = zapatosCharol.precio() - (zapatosCharol.precio() * 0.40);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class VestidoDeGala : ArticulosDescuento
    {
        vestidoGala vestidoGala = new vestidoGala();
        
        public override string descuento()
        {
            return "20%";
        }
        public void pagarGalaDescuento()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = vestidoGala.precio() - (vestidoGala.precio() * 0.20);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class VestidoDeNoche : ArticulosDescuento
    {
        
        vestidoNoche vestidoNoche = new vestidoNoche();
       
        public override string descuento()
        {
            return "10%";
        }
        public void pagarNocheDescuento()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = vestidoNoche.precio() - (vestidoNoche.precio() * 0.10);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class VestidoDeSeda : ArticulosDescuento
    {
       
        vestidoSeda vestidoSeda = new vestidoSeda();
        public override string descuento()
        {
            return "10%";
        }
        public void pagarSedaDescuento()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = vestidoSeda.precio() - (vestidoSeda.precio() * 0.10);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
}
