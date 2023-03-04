using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    abstract class ClsCamisas
    {
        public abstract string calidad();
        public abstract string estilo();
        public abstract string color();
        public abstract double precio();

        public abstract string talla();
    }


    class camisaOxford : ClsCamisas
    {
        public override string calidad()
        {
            return " gama media-Alta";
        }

        public override string color()
        {
            return " negro";
        }
        public override string talla()
        {
            return " M ";
        }
        public override string estilo()
        {
            return " Botonada";
        }

        public override double precio()
        {
            return 12.23;
        }
        public void pagarcamisaOxford()
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
    class CamisasdeVestir : ClsCamisas
    {
        public override string calidad()
        {
            return " Media_Alta";
        }

        public override string color()
        {
            return " negro ";
        }

        public override string estilo()
        {
            return " fino bordado en el cuello";
        }

        public override string talla()
        {
            return " L ";
        }

        public override double precio()
        {
            return 20.19;
        }
        public void pagarCamisasdeVestir()
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
    class Camisadefranela : ClsCamisas
    {
        public override string calidad()
        {
            return " Alta_media";
        }

        public override string color()
        {
            return " Gris y Blanco";
        }

        public override string estilo()
        {
            return " estilo cuadriculado ";
        }

        public override string talla()
        {
            return " M,L";
        }

        public override double precio()
        {
            return 18.23;
        }
        public void pagarCamisadefranela()
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
    class Camisapolo : ClsCamisas
    {
        public override string calidad()
        {
            return " Media_Baja";
        }

        public override string color()
        {
            return " Blanca";
        }

        public override string estilo()
        {
            return " De cuello alto";
        }

        public override string talla()
        {
            return " M,L ";
        }

        public override double precio()
        {
            return 15.23;
        }
        public void pagarCamisapolo()
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
    class Camisa_hawaiana : ClsCamisas
    {
        public override string calidad()
        {
            return " Media";
        }

        public override string color()
        {
            return " Roja";
        }

        public override string estilo()
        {
            return " Estilo florar con flores blancas ";
        }

        public override string talla()
        {
            return " M,L ";
        }


        public override double precio()
        {
            return 17.43;
        }
        public void pagarCamisa_hawaiana()
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
    class CamisaDedenim : ClsCamisas
    {
        public override string calidad()
        {
            return " Media";
        }

        public override string color()
        {
            return " celestes";
        }

        public override string estilo()
        {
            return " diseño informal  ";
        }

        public override string talla()
        {
            return " M,l ";
        }

        public override double precio()
        {
            return 17.42;
        }
        public void pagarCamisaDedenim()
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
    class Camisadelino : ClsCamisas
    {
        public override string calidad()
        {
            return " alta";
        }

        public override string color()
        {
            return "  negro";
        }

        public override string estilo()
        {
            return " diseños en las magas con bordado";
        }

        public override string talla()
        {
            return " M,L ";
        }

        public override double precio()
        {
            return 19.12;
        }
        public void pagarCamisadelino()
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
    class Camisademangacorta : ClsCamisas
    {
        public override string calidad()
        {
            return " Media";
        }

        public override string color()
        {
            return " Negro ";
        }

        public override string estilo()
        {
            return " Camisa con Estanpado ";
        }

        public override string talla()
        {
            return " M,L";
        }

        public override double precio()
        {
            return 17.52;
        }
        public void pagarCamisademangacorta()
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
    class Camisawestern : ClsCamisas
    {
        public override string calidad()
        {
            return " alta";
        }

        public override string color()
        {
            return " Gris";
        }

        public override string estilo()
        {
            return " Camisa con diseño en los hombros";
        }
        public override string talla()
        {
            return " M,L";
        }
        public override double precio()
        {
            return 19.21;
        }
        public void pagarCamisawestern()
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
    class Camisadecuadros : ClsCamisas
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
            return " Diseño a Cuadros";
        }
        public override string talla()
        {
            return " M,L ";
        }


        public override double precio()
        {
            return 19.99;
        }
        public void pagarCamisadecuadros()
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

        class Camisadecuellomao : ClsCamisas
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
                return " Diseño en los hombros";
            }
            public override string talla()
            {
                return " M,L ";
            }


            public override double precio()
            {
                return 19.99;
            }
            public void pagarCamisadecuellomao()
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


        class CamisaHenley : ClsCamisas
        {
            public override string calidad()
            {
                return " Alta";
            }

            public override string color()
            {
                return " Negra";
            }

            public override string estilo()
            {
                return " Diseño de Botones en el Cuello";
            }
            public override string talla()
            {
                return " M,L ";
            }


            public override double precio()
            {
                return 17.99;
            }
            public void pagarCamisaHenley()
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


        class Camisadepopelina : ClsCamisas
        {
            public override string calidad()
            {
                return " Media_Alta";
            }

            public override string color()
            {
                return " Celetes ";
            }

            public override string estilo()
            {
                return " Diseño de Botones en el Cuello";
            }
            public override string talla()
            {
                return " M,L,Xl ";
            }


            public override double precio()
            {
                return 19.99;
            }
            public void pagarCamisadepopelina()
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

        class Camisadeseda : ClsCamisas
        {
            public override string calidad()
            {
                return " Media";
            }

            public override string color()
            {
                return "  Morada ";
            }

            public override string estilo()
            {
                return " Diseño de Simple y Formal";
            }
            public override string talla()
            {
                return " M,L,Xl ";
            }


            public override double precio()
            {
                return 19.99;
            }
            public void pagarCamisadeseda()
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


}
