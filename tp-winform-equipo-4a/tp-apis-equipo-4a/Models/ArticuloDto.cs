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
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        //[DisplayName("Marca")]
        //public Marca marca { get; set; }
        //[DisplayName("Categoría")]
        //public Categoria IdCategoria { get; set; }
        public decimal Precio { get; set; }
        public List<string> Imagen { get; set; }
    }
}