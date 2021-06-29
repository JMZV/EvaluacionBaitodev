using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiAhorcado.Pal;

namespace ApiAhorcado.Controllers
{
    public class wordController : ApiController
    {
        [HttpGet]
        public List<Palabra> word()
        {
            //ListaPalabras Palabras = new ListaPalabras.Datos;
            return ListaPalabras.Datos;
        }


        [HttpGet]
        public RespuestaPalabra word(int Id, [FromBody] string Nombre)
        {
            if (Nombre == null)
            {
                Palabra palabra = ListaPalabras.Datos.Find(p => p.Id == Id);
                var caracteres = palabra.Nombre.Length.ToString();
                RespuestaPalabra respuesta = new RespuestaPalabra();
                respuesta.Respuesta = caracteres;
                respuesta.Tipo = 0;
                return respuesta;
            }
            else
            {
                RespuestaPalabra respuesta = new RespuestaPalabra
                {
                    Respuesta = "ok",
                    Posiciones = new List<int>() { 1, 2 },
                    Tipo = 1
                };
                return respuesta;
            }
        }



    }
}
