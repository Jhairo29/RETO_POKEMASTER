using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Pokemon
    {
        public int IdPokemon { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Alimentacion { get; set; }
        public string Tamaño { get; set; }
        public string Peso { get; set; }
        public string Rareza { get; set; }
        public string DatoCurioso { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}