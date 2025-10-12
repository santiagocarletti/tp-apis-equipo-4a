using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id AS IdArticulo, A.Codigo AS codigoArticulo, A.Nombre AS nombreArticulo, A.Descripcion AS articuloDescripcion, M.Id AS IdMarca, M.Descripcion AS marcaDescripcion, CA.Id AS IdCategoria, CA.Descripcion AS categoriaDescripcion, A.Precio AS precioArticulo, I.ImagenUrl AS ImagenUrl, I.Id AS IdImagen FROM ARTICULOS A LEFT JOIN IMAGENES I ON I.IdArticulo = A.Id LEFT JOIN MARCAS M ON M.Id = A.IdMarca LEFT JOIN CATEGORIAS CA ON CA.Id = A.IdCategoria ORDER BY A.Id, I.Id;";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                Articulo ultCarga = null;

                while (lector.Read())
                {
                    int idArtBD = lector["IdArticulo"] != DBNull.Value ? Convert.ToInt32(lector["IdArticulo"]) : 0;

                    if (ultCarga != null && ultCarga.Id == idArtBD)
                    {
                        string imagenUrl = Convert.ToString(lector["ImagenUrl"]);
                        ultCarga.Imagen.Add(imagenUrl);
                        continue;
                    }
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["IdArticulo"];
                    aux.Codigo = (string)lector["codigoArticulo"];
                    aux.Nombre = (string)lector["nombreArticulo"];
                    aux.Descripcion = (string)lector["articuloDescripcion"];
                    aux.marca = new Marca();
                    aux.marca.Id = (int)lector["IdMarca"];
                    aux.marca.Descripcion = (string)lector["marcaDescripcion"];
                    aux.IdCategoria = new Categoria();
                    if (!(lector["IdCategoria"] is DBNull))
                        aux.IdCategoria.Id = (int)lector["IdCategoria"];
                    if (!(lector["categoriaDescripcion"] is DBNull))
                        aux.IdCategoria.Descripcion = (string)lector["categoriaDescripcion"];
                    else
                        aux.IdCategoria.Descripcion = "";
                    aux.Precio = (decimal)lector["precioArticulo"];
                    aux.Imagen = new List<string>();
                    aux.Imagen.Add(Convert.ToString(lector["ImagenUrl"]));

                    lista.Add(aux);
                    ultCarga = aux;
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.abrirConexion();
                datos.setearConsulta(
                    "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) " +
                    "VALUES (@codigo, @nombre, @descripcion, @precio, @idMarca, @idCategoria); " +
                    "SELECT SCOPE_IDENTITY();"
                );
                datos.setearParametro("@codigo", nuevo.Codigo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@precio", nuevo.Precio);
                datos.setearParametro("@idMarca", nuevo.marca.Id);
                datos.setearParametro("@idCategoria", nuevo.IdCategoria.Id);

                int idArticulo = datos.ejecutarAccionconreturn();
                nuevo.Id = idArticulo;

                datos.limpiarParametros();

                
                if (nuevo.Imagen != null && nuevo.Imagen.Count > 0)
                {
                    foreach (string url in nuevo.Imagen)
                    {
                        if (!string.IsNullOrEmpty(url))
                        {
                            datos.setearConsulta(
                                "INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)"
                            );
                            datos.setearParametro("@IdArticulo", idArticulo);
                            datos.setearParametro("@ImagenUrl", url);
                            datos.ejecutarAccion();
                            datos.limpiarParametros();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo articulo)
        {
            AccesoDatos datosTablaArticulos = new AccesoDatos();

            try
            {
                datosTablaArticulos.abrirConexion();
                datosTablaArticulos.setearConsulta("UPDATE ARTICULOS SET " +
                    "Codigo = @codigo, " +
                    "Nombre = @nombre, " +
                    "Descripcion = @descripcion, " +
                    "IdMarca = @idmarca, " +
                    "IdCategoria = @idcategoria, " +
                    "Precio = @precio " +
                    "WHERE Id = @id");

                datosTablaArticulos.setearParametro("@id", articulo.Id);
                datosTablaArticulos.setearParametro("@codigo", articulo.Codigo);
                datosTablaArticulos.setearParametro("@nombre", articulo.Nombre);
                datosTablaArticulos.setearParametro("@descripcion", articulo.Descripcion);
                datosTablaArticulos.setearParametro("@idmarca", articulo.marca.Id);
                datosTablaArticulos.setearParametro("@idcategoria", articulo.IdCategoria.Id);
                datosTablaArticulos.setearParametro("@precio", articulo.Precio);
                datosTablaArticulos.ejecutarAccion();
                datosTablaArticulos.limpiarParametros();

                datosTablaArticulos.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @idarticulo");
                datosTablaArticulos.setearParametro("@idarticulo", articulo.Id);
                datosTablaArticulos.ejecutarMasAcciones();
                datosTablaArticulos.limpiarParametros();

                foreach (string imagen in articulo.Imagen)
                {
                    if (imagen == "")
                    { continue; }

                    datosTablaArticulos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idarticulo, @imagenurl)");
                    datosTablaArticulos.setearParametro("@imagenurl", imagen);
                    datosTablaArticulos.setearParametro("@idarticulo", articulo.Id);
                    datosTablaArticulos.ejecutarMasAcciones();
                    datosTablaArticulos.limpiarParametros();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datosTablaArticulos.cerrarConexion();
            }
        }

        public void eliminar(int Id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.abrirConexion();
                datos.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @Id;" + "delete from ARTICULOS where Id = @Id;");
                datos.setearParametro("@Id", Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List <Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                string consulta = "SELECT A.Id AS IdArticulo, A.Codigo AS codigoArticulo, A.Nombre AS nombreArticulo, A.Descripcion AS articuloDescripcion, M.Id AS IdMarca, M.Descripcion AS marcaDescripcion, CA.Id AS IdCategoria, CA.Descripcion AS categoriaDescripcion, A.Precio AS precioArticulo, I.ImagenUrl AS ImagenUrl, I.Id AS IdImagen FROM ARTICULOS A LEFT JOIN IMAGENES I ON I.IdArticulo = A.Id LEFT JOIN MARCAS M ON M.Id = A.IdMarca LEFT JOIN CATEGORIAS CA ON CA.Id = A.IdCategoria WHERE ";

                if(campo == "Precio")
                {
                    switch(criterio)
                    {
                        case "Menor a":
                            consulta += "A.Precio < " + filtro;
                            break;
                        case "Igual a":
                            consulta += "A.Precio = " + filtro;
                            break;
                        case "Mayor a":
                            consulta += "A.Precio > " + filtro;
                            break;
                    }
                }
                else if (campo == "Nombre")   
                {
                    switch (criterio) 
                    {
                    case "Empieza con":
                        consulta += "A.Nombre LIKE '" + filtro + "%'";
                        break;
                    case "Contiene":
                        consulta += "A.Nombre LIKE '%" + filtro + "%'";
                        break;
                    case "Finaliza con":
                        consulta += "A.Nombre LIKE '%" + filtro + "'";
                        break;
                    }
                    
                }
                else
                {
                    switch (criterio)
                    {
                        case "Empieza con":
                            consulta += "M.Descripcion LIKE '" + filtro + "%'";
                            break;
                        case "Contiene":
                            consulta += "M.Descripcion LIKE '%" + filtro + "%'";
                            break;
                        case "Finaliza con":
                            consulta += "M.Descripcion LIKE '%" + filtro + "'";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                Articulo ultCarga = null;

                while (datos.Lector.Read())
                {
                    int idArtBD = datos.Lector["IdArticulo"] != DBNull.Value ? Convert.ToInt32(datos.Lector["IdArticulo"]) : 0;

                    if (ultCarga != null && ultCarga.Id == idArtBD)
                    {
                        string imagenUrl = Convert.ToString(datos.Lector["ImagenUrl"]);
                        ultCarga.Imagen.Add(imagenUrl);
                        continue;
                    }

                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["IdArticulo"];
                    aux.Codigo = (string)datos.Lector["codigoArticulo"];
                    aux.Nombre = (string)datos.Lector["nombreArticulo"];
                    aux.Descripcion = (string)datos.Lector["articuloDescripcion"];
                    aux.marca = new Marca();
                    aux.marca.Id = (int)datos.Lector["IdMarca"];
                    aux.marca.Descripcion = (string)datos.Lector["marcaDescripcion"];
                    aux.IdCategoria = new Categoria();
                    if (!(datos.Lector["IdCategoria"] is DBNull))
                        aux.IdCategoria.Id = (int)datos.Lector["IdCategoria"];
                    if (!(datos.Lector["categoriaDescripcion"] is DBNull))
                        aux.IdCategoria.Descripcion = (string)datos.Lector["categoriaDescripcion"];
                    else
                        aux.IdCategoria.Descripcion = "";

                    aux.Precio = (decimal)datos.Lector["precioArticulo"];
                    aux.Imagen = new List<string>();
                    aux.Imagen.Add(Convert.ToString(datos.Lector["ImagenUrl"]));

                    lista.Add(aux);
                    ultCarga = aux;
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Articulo obtenerPorId(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            Articulo articulo = new Articulo();

            try
            {
                datos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, " +
                                     "C.Descripcion AS Categoria, M.Descripcion AS Marca, I.ImagenUrl " +
                                     "FROM Articulos A " +
                                     "LEFT JOIN Categorias C ON A.IdCategoria = C.Id " +
                                     "LEFT JOIN Marcas M ON A.IdMarca = M.Id " +
                                     "LEFT JOIN Imagenes I ON I.IdArticulo = A.Id " +
                                     "WHERE A.Id = @idArticulo");
                datos.setearParametro("@idArticulo", idArticulo);
                datos.ejecutarLectura();

                bool banderaImagenes = false;

                while (datos.Lector.Read())
                {
                    if (banderaImagenes)
                    {
                        articulo.Imagen.Add(Convert.ToString(datos.Lector["ImagenUrl"]));
                        continue;
                    }

                    articulo.Id = Convert.ToInt32(datos.Lector["Id"]);
                    articulo.Codigo = Convert.ToString(datos.Lector["Codigo"]);
                    articulo.Nombre = Convert.ToString(datos.Lector["Nombre"]);
                    articulo.Descripcion = Convert.ToString(datos.Lector["Descripcion"]);
                    articulo.Precio = Convert.ToDecimal(datos.Lector["Precio"]);

                    articulo.marca = new Marca
                    {
                        Descripcion = Convert.ToString(datos.Lector["Marca"])
                    };

                    articulo.IdCategoria = new Categoria
                    {
                        Descripcion = Convert.ToString(datos.Lector["Categoria"])
                    };

                    // Manejo de imágenes
                    articulo.Imagen = new List<string>();
                    articulo.Imagen.Add(Convert.ToString(datos.Lector["ImagenUrl"]));

                    banderaImagenes = true;
                }

                return articulo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public string agregarImagenes(int id, List<string> listaImagenes)
        {
            Articulo articulo = obtenerPorId(id);

            if (articulo.Id == 0)
            { return "Error: El Artículo no existe"; }

            AccesoDatos datos = new AccesoDatos();
            datos.abrirConexion();
            try
            {
                int vuelta = 0;
                foreach (string imagen in listaImagenes)
                {
                    if (imagen == "")
                    { continue; }
                    datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idarticulo, @imagenurl)");
                    datos.setearParametro("@imagenurl", imagen);
                    datos.setearParametro("@idarticulo", id);
                    if (vuelta == 0)
                    {
                        datos.ejecutarAccion();
                    }
                    else
                    {
                        datos.ejecutarMasAcciones();
                    }
                    datos.limpiarParametros();
                    vuelta++;
                }

                return "Cargadas " + vuelta.ToString() + " imágenes en el artículo " + id;

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
                    