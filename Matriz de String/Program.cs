using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_de_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] alumnos = new string[7, 2];
            for (int i = 0; i < alumnos.GetLength(0); i++)
            {
                Console.WriteLine("Ingresa el nombre del Alumno " + (i+1));
                alumnos[i, 0] = Console.ReadLine();
                Console.WriteLine("Ingresa el nombre del Salón " + (i+1));
                alumnos[i, 1] = Console.ReadLine();
            }
            Console.WriteLine("Ingresa el sal{on a consultar de los alumnos a ver ");
            string salon = Console.ReadLine();
            for (int i = 0; i < alumnos.GetLength(0); i++)
            {
                if (alumnos[i, 1] == salon)
                {
                    for (int j = 0; j < alumnos.GetLength(1); j++)
                    {
                        Console.Write(alumnos[i,j] + " | ");
                    }
                }
            }

            Console.Read();
        }
    }
}
