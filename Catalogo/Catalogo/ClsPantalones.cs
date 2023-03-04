using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    abstract class ClsPantalones
    {
        
            public abstract string calidad();
            public abstract string estilo();
            public abstract string color();
            public abstract double precio();

        
       
    }


    class PantalonVaquero : ClsPantalones
    {
        public override string calidad()
        {
            return " gama media-Alta";
        }

        public override string color()
        {
            return " negro";
        }

        public override string estilo()
        {
            return " vaqueros";
        }

        public override double precio()
        {
            return 24.55;
        }
        public void pagarPantalonVaquero()
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
    class PantalonRecto : ClsPantalones
    {
        public override string calidad()
        {
            return " Media ";
        }

        public override string color()
        {
            return " azul";
        }

        public override string estilo()
        {
            return " estilo casual";
        }


        public override double precio()
        {
            return 20.19;
        }
        public void pagarPantalonRecto()
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
    class Pantalon_Skynni : ClsPantalones
    {
        public override string calidad()
        {
            return " Alta_media";
        }

        public override string color()
        {
            return " Gris";
        }

        public override string estilo()
        {
            return " pantalones con diseño roto estilo skaeters ";
        }


        public override double precio()
        {
            return 22.34;
        }
        public void pagarPantalon_Skynni()
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
    class PantalonSlim_fit : ClsPantalones
    {
        public override string calidad()
        {
            return " Media_Baja";
        }

        public override string color()
        {
            return " Azul Marino";
        }

        public override string estilo()
        {
            return " sin adornos panatalon sencillo";
        }

        public override double precio()
        {
            return 21.23;
        }
        public void pagarPantalonSlim_fit()
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
    class PantalonesRegular_Fit : ClsPantalones
    {
        public override string calidad()
        {
            return " Media_Alta";
        }

        public override string color()
        {
            return " blanco";
        }

        public override string estilo()
        {
            return "adorno a los alados con una linea azula ";
        }


        public override double precio()
        {
            return 21.50;
        }
        public void pagarPantalonesRegular_Fit()
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
    class Pantalones_Loose : ClsPantalones
    {
        public override string calidad()
        {
            return " Media_Media";
        }

        public override string color()
        {
            return " celestes";
        }

        public override string estilo()
        {
            return " diseño informal  ";
        }

        public override double precio()
        {
            return 23.32;
        }
        public void pagarPantalones_Loose()
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
    class PantalonRelax_fit : ClsPantalones
    {
        public override string calidad()
        {
            return " gama alta";
        }

        public override string color()
        {
            return " azul negro";
        }

        public override string estilo()
        {
            return " Estilo robusto en los costados";
        }

        public override double precio()
        {
            return 21.12;
        }
        public void pagarPantalonRelax_fit()
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
    class PantaloDrop_Croatch : ClsPantalones
    {
        public override string calidad()
        {
            return " Media_Alta";
        }

        public override string color()
        {
            return " Negro opaco";
        }

        public override string estilo()
        {
            return " Bordado en los bosillos delanteros";
        }

        public override double precio()
        {
            return 21.46;
        }
        public void pagarPantaloDrop_Croatch()
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
    class PantalónHigh_rise : ClsPantalones
    {
        public override string calidad()
        {
            return " gama alta";
        }

        public override string color()
        {
            return " Gris";
        }

        public override string estilo()
        {
            return " estilo comodo en la cintura con diseño desgaste";
        }

        public override double precio()
        {
            return 23.87;
        }
        public void pagarPantalónHigh_risee()
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
    class PantalónLow_rise : ClsPantalones
    {
        public override string calidad()
        {
            return " Alta";
        }

        public override string color()
        {
            return " blanco";
        }

        public override string estilo()
        {
            return " Diseño desgastado en los muslos";
        }


        public override double precio()
        {
            return 20.83;
        }
        public void pagarPantalónLow_rise()
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

