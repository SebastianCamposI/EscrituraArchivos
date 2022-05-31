using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        public class Peliculas
        {
            public string Nombre, Director;
            public int Año;
            public Peliculas(string Nombre, string Director, int Año)
            {
                this.Nombre = Nombre;
                this.Director = Director;
                this.Año = Año;

            }

            public void DesplegarDatos()
            {
                Console.WriteLine("Nombre de la película: " + this.Nombre);
                Console.WriteLine("Nombre del director: " + this.Director);
                Console.WriteLine("Año de estreno: " + this.Año);
            } 
        }

        static void Main(string[] args)
        {
            Console.Write("Ingresa el nombre de la película: ");
            string Nombre = Console.ReadLine();
            Console.Write("Ingresa el nombre del director: ");
            string Director = Console.ReadLine();
            Console.Write("Ingresa el año del estreno: ");
            int Año = int.Parse(Console.ReadLine());
            Peliculas PE = new Peliculas(Nombre, Director, Año);
            StreamWriter sw = new StreamWriter("Peliculas.txt", true);

            sw.WriteLine("Película: " + PE.Nombre);
            sw.WriteLine("Director: " + PE.Director);
            sw.WriteLine("Año: " + PE.Año);
            sw.Close();

            Console.WriteLine("Escribiendo el archivo..");
            Console.ReadLine();
        }
    }
}
