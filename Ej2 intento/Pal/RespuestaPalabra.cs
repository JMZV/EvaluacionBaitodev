using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAhorcado.Pal
{
    public class RespuestaPalabra
    {
        public string Respuesta { get; set; }
        public List<int> Posiciones { get; set; }
        public int Tipo { get; set; }
    }
}