using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    abstract class ClsVestidos
    {
        public abstract string calidad();
        public abstract string estilo();
        public abstract string color();
        public abstract string largo();
        public abstract double precio();

    }
    class vestidoGala : ClsVestidos
    {
        public override string calidad()
        {
            return" gama media";
        }

        public override string color()
        {
            return " violeta";
        }

        public override string estilo()
        {
            return " adornado con flores";
        }

        public override string largo()
        {
            return " largo con cola";
        }

        public override double precio()
        {
            return 56.90;
        }
        public void pagarVestidoGala()
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
    class vestidoCoctel : ClsVestidos
    {
        public override string calidad()
        {
            return " gama baja";
        }

        public override string color()
        {
            return " celeste";
        }

        public override string estilo()
        {
            return " solo de color celeste y decotado";
        }

        public override string largo()
        {
            return " corto";
        }

        public override double precio()
        {
            return 30.90;
        }
        public void pagarVestidoCoctel()
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
    class vestidolargo : ClsVestidos
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
            return " adornado con mariposas ";
        }

        public override string largo()
        {
            return " largo";
        }

        public override double precio()
        {
            return 100;
        }
        public void pagarVestidoLargo()
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
    class vestidoCorto : ClsVestidos
    {
        public override string calidad()
        {
            return " gama baja";
        }

        public override string color()
        {
            return " rojo y amarillo";
        }

        public override string estilo()
        {
            return " adornado con cintas amarillas";
        }

        public override string largo()
        {
            return " corto";
        }

        public override double precio()
        {
            return 15;
        }
        public void pagarVestidoCorto()
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
    class vestidoNovia : ClsVestidos
    {
        public override string calidad()
        {
            return " gama alta";
        }

        public override string color()
        {
            return " blanco";
        }

        public override string estilo()
        {
            return " adornado con flores";
        }

        public override string largo()
        {
            return " largo";
        }

        public override double precio()
        {
            return 250;
        }
        public void pagarVestidoNovia()
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
    class vestidoFiesta : ClsVestidos
    {
        public override string calidad()
        {
            return " gama media";
        }

        public override string color()
        {
            return " morado, rosado y blanco";
        }

        public override string estilo()
        {
            return " fondo con patrones de cuadros ";
        }

        public override string largo()
        {
            return " largo";
        }

        public override double precio()
        {
            return 30;
        }
        public void pagarVestidoFiesta()
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
    class vestidoNoche : ClsVestidos
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
            return " adornado con brillantina";
        }

        public override string largo()
        {
            return " largo";
        }

        public override double precio()
        {
            return 90;
        }
        public void pagarVestidoNoche()
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
    class vestidoTubo : ClsVestidos
    {
        public override string calidad()
        {
            return " gama baja";
        }

        public override string color()
        {
            return " verde";
        }

        public override string estilo()
        {
            return " fondo con patrones de puntos";
        }

        public override string largo()
        {
            return " corto";
        }

        public override double precio()
        {
            return 10;
        }
        public void pagarVestidoTubo()
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
    class vestidoEncaje : ClsVestidos
    {
        public override string calidad()
        {
            return " gama alta";
        }

        public override string color()
        {
            return " anaranjado";
        }

        public override string estilo()
        {
            return " adornado con mochos";
        }

        public override string largo()
        {
            return " mediano";
        }

        public override double precio()
        {
            return 75;
        }
        public void pagarVestidoEncaje()
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
    class vestidoSeda : ClsVestidos
    {
        public override string calidad()
        {
            return " gama media";
        }

        public override string color()
        {
            return " blanco";
        }

        public override string estilo()
        {
            return " todo blanco";
        }

        public override string largo()
        {
            return " mediano con cola";
        }

        public override double precio()
        {
            return 20;
        }
        public void pagarVestidoSeda()
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
