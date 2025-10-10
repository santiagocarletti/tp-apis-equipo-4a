using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace tp_apis_equipo_4a.Models
{
    public class ArticuloDto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public decimal Precio { get; set; }
        public List<string> Imagen { get; set; }

        //public override string ToString()
        //{
        //    return marca.Descripcion;
        //}
    }
}