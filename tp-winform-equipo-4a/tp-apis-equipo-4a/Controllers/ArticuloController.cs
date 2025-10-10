using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dominio;
using negocio;
using tp_apis_equipo_4a.Models;

namespace tp_apis_equipo_4a.Controllers
{
    public class ArticuloController : ApiController
    {
        // GET: api/Articulo
        public IEnumerable<Articulo> Get()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            return negocio.listar();
        }

        // GET: api/Articulo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Articulo
        public void Post([FromBody]ArticuloDto articulo)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo nuevo = new Articulo();
            nuevo.Codigo = articulo.Codigo;
            nuevo.Nombre = articulo.Nombre;
            nuevo.Descripcion = articulo.Descripcion;
            nuevo.marca = new Marca { Id = articulo.IdMarca };
            nuevo.IdCategoria = new Categoria { Id = articulo.IdCategoria };
            nuevo.Precio = articulo.Precio;
            nuevo.Imagen = articulo.Imagen;

            negocio.agregar(nuevo);
        }

        // PUT: api/Articulo/5
        public void Put(int id, [FromBody]ArticuloDto articulo)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo nuevo = new Articulo();
            nuevo.Codigo = articulo.Codigo;
            nuevo.Nombre = articulo.Nombre;
            nuevo.Descripcion = articulo.Descripcion;
            nuevo.marca = new Marca { Id = articulo.IdMarca };
            nuevo.IdCategoria = new Categoria { Id = articulo.IdCategoria };
            nuevo.Precio = articulo.Precio;
            nuevo.Imagen = articulo.Imagen;
            nuevo.Id = id;

            negocio.modificar(nuevo);

        }

        // DELETE: api/Articulo/5
        public void Delete(int id)
        {
           ArticuloNegocio negocio = new ArticuloNegocio();
           negocio.eliminar(id);
        }
    }
}
