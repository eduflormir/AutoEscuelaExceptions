﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoEscuela;

namespace Autoescuela
{
    public class Alumno
    {
        public String Nombre { get; set; }

        public enum Permisos { A, B, C, D, E };

        private int _edad;

        // ejemplo de encapsulación
        public int Edad
        {
            get {return _edad; }
            set
            {
                if (value < 18 || value > 65)
                    throw new EdadIncorrectaException(value);
                _edad = value;
            }
        }
        
    private Permisos _permiso;

        public Permisos Permiso
        {
            get { return _permiso; }
            set
            {
                if ((int)value > (int)Actual + 1)
                {
                    var msg = $"El permiso actual {Actual} no "
                        + $"permite optar al permiso {value}";
                    throw new PermisoIncorrectoException(msg);

                }


                _permiso = value;
            }
        }

        public Permisos Actual { get; set; }
}
}
