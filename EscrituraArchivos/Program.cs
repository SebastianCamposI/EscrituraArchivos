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
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //Si el archivo no existe se creará
            //Si ya existe, escribirá en el
            //El true para escribir y no sobreescribir

            string[] lines =
                {
                "Esta es la información de la primera línea",
                "Esta es la segunda línea",
                "Fin del texto"
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
