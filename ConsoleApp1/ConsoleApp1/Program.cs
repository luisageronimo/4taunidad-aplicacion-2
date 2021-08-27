using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicación2
{
    class Program
    {
        static void Main(string[] args)
        {
            char op = 's';
            string archivo = "";
            int OP;

            while (op == 's')
            {
                Console.WriteLine("Que desea hacer: \n1. Crear Archivo \n2. Escribir Archivo \n3. Visualizar contenido \n4. Salir ");
                OP = int.Parse(Console.ReadLine());
                string nombre;

                Console.Clear();
                if (OP == 1)
                {
                    StreamWriter ar;
                    Console.WriteLine("Que nombre le pondrá a su archivo: ");
                    archivo = Console.ReadLine();
                    ar = File.CreateText(archivo + ".txt");
                    nombre = archivo;

                    ar.Close();
                }
                if (OP == 2)
                {
                    EscribirArchivo(archivo);
                }
                if (OP == 3)
                {
                    MostrarContenido(archivo);
                }

                Console.ReadKey();
                if (OP == 4)
                {
                    Console.WriteLine("Deseo salir");
                }
                Console.Clear();
                Console.WriteLine("Quisiera Continuar ['s/n']");
                op = char.Parse(Console.ReadLine());

            }
        }
        static void EscribirArchivo(string nombre)
        {
            StreamWriter ar;
            Console.WriteLine("Que escribira: ");
            ar = File.AppendText(nombre);
            ar.WriteLine(Console.ReadLine());
            ar.Close();
        }
        static void MostrarContenido(string ruta)
        {
            StreamReader ar;
            ar = File.OpenText(ruta);
            Console.WriteLine(ar.ReadToEnd());
        }
    }
}
