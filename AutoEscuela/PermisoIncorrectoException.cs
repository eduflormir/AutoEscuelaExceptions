using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEscuela
{
    public class PermisoIncorrectoException : Exception
    {
        public PermisoIncorrectoException(String msg):base(msg)
        {

        }
    }
}
