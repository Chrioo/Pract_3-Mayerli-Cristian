using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    abstract class ClsZapatos
    {
        public abstract string calidad();
        public abstract string estilo();
        public abstract string color();
        public abstract string material();
        public abstract double precio();
    }
    class ZapatosTaconAlto : ClsZapatos
    {
        public override string calidad()
        {
            return " gama media";
        }

        public override string color()
        {
            return " negro";
        }

        public override string estilo()
        {
            return " adornado con lineas";
        }

        public override double precio()
        {
            return 40;
        }
        

        public override string material()
        {
            return " sintético";
        }
        public void pagarTaconAlto()
        {
            double pagar = double.Parse(Console.ReadLine());
            double total = pagar - precio();
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
    class ZapatosTaconBajo : ClsZapatos
    {
        public override string calidad()
        {
            return " gama media";
        }

        public override string color()
        {
            return " azul";
        }

        public override string estilo()
        {
            return " adornado con puntos";
        }

        public override double precio()
        {
            return 60;
        }


        public override string material()
        {
            return " goma";
        }
        public void pagarTaconBajo()
        {
            double pagar = double.Parse(Console.ReadLine());
            double total = pagar - precio();
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
    class ZapatosPlataforma : ClsZapatos
    {
        public override string calidad()
        {
            return " gama alta";
        }

        public override string color()
        {
            return " negro";
        }

        public override string estilo()
        {
            return " todo negro";
        }

        public override double precio()
        {
            return 70;
        }


        public override string material()
        {
            return " neopreno";
        }
        public void pagarPlataforma()
        {
            double pagar = double.Parse(Console.ReadLine());
            double total = pagar - precio();
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
    class ZapatosC : ClsZapatos
    {
        public override string calidad()
        {
            return " gama baja";
        }

        public override string color()
        {
            return " negro";
        }

        public override string estilo()
        {
            return " todo negro";
        }

        public override double precio()
        {
            return 25;
        }


        public override string material()
        {
            return " gamuza";
        }
        public void pagarC()
        {
            double pagar = double.Parse(Console.ReadLine());
            double total = pagar - precio();
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
    class ZapatosPunta : ClsZapatos
    {
        public override string calidad()
        {
            return " gama alta";
        }

        public override string color()
        {
            return " azules";
        }

        public override string estilo()
        {
            return " con diseño de flores";
        }

        public override double precio()
        {
            return 88;
        }


        public override string material()
        {
            return " neopreno";
        }
        public void pagarPunta()
        {
            double pagar = double.Parse(Console.ReadLine());
            double total = pagar - precio();
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
    class ZapatosBallet : ClsZapatos
    {
        public override string calidad()
        {
            return " gama alta";
        }

        public override string color()
        {
            return " rosado";
        }

        public override string estilo()
        {
            return " todo rosado";
        }

        public override double precio()
        {
            return 90;
        }


        public override string material()
        {
            return " tela";
        }
        public void pagarBallet()
        {
            double pagar = double.Parse(Console.ReadLine());
            double total = pagar - precio();
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
    class ZapatosSalon : ClsZapatos
    {
        public override string calidad()
        {
            return " gama media";
        }

        public override string color()
        {
            return " blancos";
        }

        public override string estilo()
        {
            return " todo blanco";
        }

        public override double precio()
        {
            return 60;
        }


        public override string material()
        {
            return " cuero";
        }
        public void pagarSalon()
        {
            double pagar = double.Parse(Console.ReadLine());
            double total = pagar - precio();
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
    class ZapatosCuero : ClsZapatos
    {
        public override string calidad()
        {
            return " gama media";
        }

        public override string color()
        {
            return " marron";
        }

        public override string estilo()
        {
            return " todo marron";
        }

        public override double precio()
        {
            return 50;
        }


        public override string material()
        {
            return " cuero";
        }
        public void pagarCuero()
        {
            double pagar = double.Parse(Console.ReadLine());
            double total = pagar - precio();
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
    class ZapatosGamuza : ClsZapatos
    {
        public override string calidad()
        {
            return " gama alta";
        }

        public override string color()
        {
            return " morado";
        }

        public override string estilo()
        {
            return " adorado con cintas";
        }

        public override double precio()
        {
            return 100;
        }


        public override string material()
        {
            return " gamuza";
        }
        public void pagarGamuza()
        {
            double pagar = double.Parse(Console.ReadLine());
            double total = pagar - precio();
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
    class ZapatosCharol : ClsZapatos
    {
        public override string calidad()
        {
            return " gama alta";
        }

        public override string color()
        {
            return " negro";
        }

        public override string estilo()
        {
            return " todo negro";
        }

        public override double precio()
        {
            return 66;
        }


        public override string material()
        {
            return " charol";
        }
        public void pagarCharol()
        {
            double pagar = double.Parse(Console.ReadLine());
            double total = pagar - precio();
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
