﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Mouses
    {
        public int IdMouse { get; set; }
        public string estado { get; set; }
        public Marca oMarca { get; set; }
        public int numModel { get; set; }

    }
}
