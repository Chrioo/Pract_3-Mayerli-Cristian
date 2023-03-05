using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        abstract class Prenda
        {
            String tipo;
            String tallas;
            String caracteristicas;

            public Prenda(String tipo, String tallas, String caracteristicas)
            {
                this.tipo = tipo;
                this.tallas = tallas;
                this.caracteristicas = caracteristicas;
            }

            public abstract String getPrenda();

            public String toString()
            {
                return "Tipo: " + tipo + "\nTallas disponibles: " + tallas  + "\nCaracterísticas: " + caracteristicas +  "\nCalidad: " + getPrenda();
            }
        }


        class Pantalon  
        {
            String material;
            String calidad;
            String tallas;
            String Caracteristicas;

        public Pantalon(String tallas, String caracteristicas, String material, String calidad)
            {
                this.Caracteristicas= caracteristicas;
                this.tallas = tallas;
                this.material = material;
                this.calidad = calidad;

            }

            public String getPrenda()
            {
                return calidad;
            }
        }

        class Camisa 
        {
            String  diseños;
            String calidad;
            String Caracteristicas;
            String tallas;

        
            public Camisa(String tallas, String caracteristicas, String diseños, String calidad)
            {
                this.Caracteristicas= caracteristicas;
                this.tallas = tallas;
                this.diseños = diseños;
                this.calidad = calidad;
            }

            public String getCalidad()
            {
                return calidad;
            }
        }

    }

}
