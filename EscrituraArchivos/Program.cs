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
        static void Main(string[] args)
        {
            Console.Write("Ingresa un nombre: ");
            string nombre = Console.ReadLine();
            StreamWriter sw = new StreamWriter("Nombres.txt", true);
            //Si el archivo no existe se creará
            //Si ya existe, escribirá en el
            //El true para escribir y no sobreescribir

            string[] lines =
            {
                nombre
            };
            foreach(string line in lines)
            {
                sw.WriteLine(line);
            }
            sw.Close();

            Console.WriteLine("Escribiendo el archivo..");
            Console.ReadLine();
        }
    }
}
