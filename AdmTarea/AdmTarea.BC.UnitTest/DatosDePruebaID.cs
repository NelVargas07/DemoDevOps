﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdmTarea.BC.Modelos;

namespace AdmTarea.BC.UnitTest
{
    public class DatosDePruebaID
    {
        public static Tarea Tarea()
        {
            return new Tarea()
            {
                id = 2,
                nombre = "tarea 01",
                estaListo = true,
                secreto = "prueba 1"
            };
        }
    }
}
