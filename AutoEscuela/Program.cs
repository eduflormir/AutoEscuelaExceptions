using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoescuela
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Escribe tu nombre:");
            //String nombre = Console.ReadLine();

            //Console.WriteLine("Escribe tu edad: ");
            //int edad = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Escribe tu permiso actual: ");
            //string permisoActual = Console.ReadLine();

            //Console.WriteLine("Escribe tu permiso deseado: ");
            //string permisoDeseado = Console.ReadLine();

                
                var c = new Alumno()
                {
                    Nombre = "Eduardo",
                    Edad = 19,
                    Actual = Alumno.Permisos.A,
                    Permiso = Alumno.Permisos.C
                };
            
            
        }
    }
}
