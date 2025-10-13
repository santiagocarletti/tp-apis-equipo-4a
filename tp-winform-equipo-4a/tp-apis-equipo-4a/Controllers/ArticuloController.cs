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
        [HttpGet]
        [Route("api/Articulo")]
        public IEnumerable<Articulo> Get()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            return negocio.listar();
        }

        // GET: api/Articulo/5
        [HttpGet]
        [Route("api/Articulo/{id}")]
        public Articulo Get(int id)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            return negocio.obtenerPorId(id);
        }

        // POST: api/Articulo
        [HttpPost]
        [Route("api/Articulo")]
        public IHttpActionResult Post([FromBody] ArticuloDto articulo)
        {
            var negocio = new ArticuloNegocio();
            var marcaNegocio = new MarcaNegocio();
            var categoriaNegocio = new CategoriaNegocio();

            if (articulo == null)
            {
                return Content(HttpStatusCode.BadRequest, "Verifique el formato enviado.");
            }
            if (articulo.Codigo == null || articulo.Codigo.Trim() == "")
                return Content(HttpStatusCode.BadRequest, "Código de Artículo obligatorio.");

            Marca marca = marcaNegocio.listar().Find(x => x.Id == articulo.IdMarca);
            Categoria categoria = categoriaNegocio.listar().Find(x => x.Id == articulo.IdCategoria);

            if (articulo.IdMarca <= 0)
                return Content(HttpStatusCode.BadRequest, "El ID de la marca debe ser válido.");

            if (marca == null)
                return Content(HttpStatusCode.BadRequest, "La marca no existe.");

            if (articulo.IdCategoria <= 0)
                return Content(HttpStatusCode.BadRequest, "ID de Categoría inválido.");

            if (categoria == null)
                return Content(HttpStatusCode.BadRequest, "La categoría no existe.");

            if (negocio.existeCodigo(articulo.Codigo))
                return Content(HttpStatusCode.BadRequest, "Código de Artículo ya existente");

            if (articulo.Nombre == null || articulo.Nombre.Trim() == "")
                return Content(HttpStatusCode.BadRequest, "Nombre de Artículo obligatorio.");

            if (articulo.Descripcion == null || articulo.Descripcion.Trim() == "")
                return Content(HttpStatusCode.BadRequest, "Descripción de Artículo obligatoria.");

            if (articulo.Precio <= 0)
                return Content(HttpStatusCode.BadRequest, "El precio debe ser mayor a 0.");

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
                return Content(HttpStatusCode.OK, "Artículo agregado correctamente.");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, "Error al agregar el artículo");
            }
        }

        // PUT: api/Articulo/5
        [HttpPut]
        [Route("api/Articulo/{id}")]
        public IHttpActionResult Put(int id, [FromBody]ArticuloDto articulo)
        {
            var negocio = new ArticuloNegocio();
            var marcaNegocio = new MarcaNegocio();
            var categoriaNegocio = new CategoriaNegocio();

            if (articulo == null)
            {
                return Content(HttpStatusCode.BadRequest, "Verifique el formato enviado.");
            }
            if (articulo.Codigo == null || articulo.Codigo.Trim() == "")
                return Content(HttpStatusCode.BadRequest, "Código de Artículo obligatorio.");

            Marca marca = marcaNegocio.listar().Find(x => x.Id == articulo.IdMarca);
            Categoria categoria = categoriaNegocio.listar().Find(x => x.Id == articulo.IdCategoria);

            if (articulo.IdMarca <= 0)
                return Content(HttpStatusCode.BadRequest, "El ID de la marca debe ser válido.");

            if (marca == null)
                return Content(HttpStatusCode.BadRequest, "La marca no existe.");

            if (articulo.IdCategoria <= 0)
                return Content(HttpStatusCode.BadRequest, "ID de Categoría inválido.");

            if (categoria == null)
                return Content(HttpStatusCode.BadRequest, "La categoría no existe.");

             if (articulo.Codigo == null || articulo.Codigo.Trim() == "")
                return Content(HttpStatusCode.BadRequest, "Código de Artículo obligatorio.");

            if (articulo.Nombre == null || articulo.Nombre.Trim() == "")
                return Content(HttpStatusCode.BadRequest, "Nombre de Artículo obligatorio.");

            if (articulo.Descripcion == null || articulo.Descripcion.Trim() == "")
                return Content(HttpStatusCode.BadRequest, "Descripción de Artículo obligatoria.");

            if (articulo.Precio <= 0)
                return Content(HttpStatusCode.BadRequest, "El precio debe ser mayor a 0.");

            if (negocio.existeCodigo(articulo.Codigo, id))
                return Content(HttpStatusCode.BadRequest, "Código de Artículo ya existente para otro artículo.");

            Articulo nuevo = new Articulo();
            nuevo.Codigo = articulo.Codigo;
            nuevo.Nombre = articulo.Nombre;
            nuevo.Descripcion = articulo.Descripcion;
            nuevo.marca = new Marca { Id = articulo.IdMarca };
            nuevo.IdCategoria = new Categoria { Id = articulo.IdCategoria };
            nuevo.Precio = articulo.Precio;
            nuevo.Imagen = articulo.Imagen;
            nuevo.Id = id;

            try
            {
                negocio.modificar(nuevo);
                return Content(HttpStatusCode.OK, "Artículo modificado correctamente.");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, "Error al modificar el artículo.");
            }

        }

        // DELETE: api/Articulo/5
        [HttpDelete]
        [Route("api/Articulo/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var negocio = new ArticuloNegocio();
            try
            {
                negocio.eliminar(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Artículo eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Error al eliminar el artículo.");
            }
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
