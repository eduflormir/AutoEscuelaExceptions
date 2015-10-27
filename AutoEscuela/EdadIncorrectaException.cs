using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEscuela
{
    public class EdadIncorrectaException:ApplicationException
    {
        public EdadIncorrectaException(int edad) : base("La edad es incorrecta "+edad)
        {
            Console.WriteLine("La edad es incorrecta: {0} \n", edad);
        }
    }
}
