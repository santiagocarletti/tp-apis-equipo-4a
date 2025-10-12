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
        public Articulo Get(int id)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            return negocio.obtenerPorId(id);
        }

        // POST: api/Articulo
        public HttpResponseMessage Post([FromBody]ArticuloDto articulo)
        {
            //ArticuloNegocio negocio = new ArticuloNegocio();
            //Articulo nuevo = new Articulo();
            //nuevo.Codigo = articulo.Codigo;
            //nuevo.Nombre = articulo.Nombre;
            //nuevo.Descripcion = articulo.Descripcion;
            //nuevo.marca = new Marca { Id = articulo.IdMarca };
            //nuevo.IdCategoria = new Categoria { Id = articulo.IdCategoria };
            //nuevo.Precio = articulo.Precio;
            //nuevo.Imagen = articulo.Imagen;

            var negocio = new ArticuloNegocio();
            var marcaNegocio = new MarcaNegocio();
            var categoriaNegocio = new CategoriaNegocio();

            Marca marca = marcaNegocio.listar().Find(x => x.Id == articulo.IdMarca);
            Categoria categoria = categoriaNegocio.listar().Find(x => x.Id == articulo.IdCategoria);

            if (marca == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La marca no existe.");

            if (categoria == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La categoría no existe.");

            var nuevo = new Articulo
            {
                Codigo = articulo.Codigo,
                Nombre = articulo.Nombre,
                Descripcion = articulo.Descripcion,
                marca = marca,
                IdCategoria = categoria,
                Precio = articulo.Precio,
                Imagen = articulo.Imagen
            };

            try
            {
                negocio.agregar(nuevo);
                return Request.CreateResponse(HttpStatusCode.OK, "Artículo agregado correctamente.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Error al agregar el artículo");
            }
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
        [HttpPost]
        [Route("api/Articulo/AgregarImagenes")]
        public IHttpActionResult Post([FromBody] ImagenesDto imagenes)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                string imagenResultado = negocio.agregarImagenes(imagenes.Id, imagenes.Imagenes);
                return Ok(imagenResultado);
            }
            catch (Exception ex)
            {
                return BadRequest("Error al cargar imágenes: " + ex.Message);
            }
        }
    }
}
