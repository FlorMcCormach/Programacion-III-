using Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
		
        public List<Articulo> listar()
        {
            AccesoDatos AccesoDatos = new AccesoDatos();
			List<Articulo> lista = new List<Articulo>();

            try
			{
				
				AccesoDatos.setearConsulta("SELECT a.Id AS IdArticulo, a.Codigo AS CodigoArticulo, a.Nombre AS NombreArticulo, a.Descripcion AS DescripcionArticulo, a.IdMarca, m.Descripcion AS DescripcionMarca, a.IdCategoria, c.Descripcion AS DescripcionCategoria, a.Precio AS PrecioArticulo FROM ARTICULOS a INNER JOIN MARCAS m ON a.IdMarca = m.Id INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id;");
                //("SELECT a.id AS IdArticulo, a.Codigo AS CodigoArticulo, a.Nombre AS NombreArticulo, a.Descripcion AS DescripcionArticulo, m.Descripcion AS DescripcionMarca, c.Descripcion AS DescripcionCategoria, a.Precio AS PrecioArticulo FROM ARTICULOS a INNER JOIN MARCAS m ON a.IdMarca = m.Id INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id;");

                

                AccesoDatos.ejecutarConsulta();
              
				while (AccesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = (int)AccesoDatos.Lector["IdArticulo"];
                    aux.CodigoArticulo = (string)AccesoDatos.Lector["CodigoArticulo"];
                    aux.NombreArticulo = (string)AccesoDatos.Lector["NombreArticulo"];
                    aux.DescripcionArticulo = (string)AccesoDatos.Lector["DescripcionArticulo"];
					aux.PrecioArticulo = (decimal)AccesoDatos.Lector["PrecioArticulo"];
					
					aux.Marca = new Marca();
					aux.Marca.IdMarca = (int)AccesoDatos.Lector["IdMarca"];
					aux.Marca.MarcaDescripcion = (string)AccesoDatos.Lector["DescripcionMarca"];

					aux.Categoria = new Categoria();
					aux.Categoria.IdCategoria = (int)AccesoDatos.Lector["IdCategoria"];
					aux.Categoria.DescripcionCategoria = (string)AccesoDatos.Lector["DescripcionCategoria"];

                    lista.Add(aux);
                }
                return lista;
            }
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				AccesoDatos.cerrarConexion();
			}
        }

        public List<Articulo> buscarArticulo(Articulo articulo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            List<Articulo> lista = new List<Articulo>();

            try
            {
                // Validar que al menos haya un filtro
                bool tieneFiltros =!string.IsNullOrWhiteSpace(articulo.NombreArticulo) || !string.IsNullOrWhiteSpace(articulo.Marca.MarcaDescripcion) ||!string.IsNullOrWhiteSpace(articulo.Categoria.DescripcionCategoria) || !string.IsNullOrWhiteSpace(articulo.CodigoArticulo) || articulo.PrecioArticulo > 0;

                if (!tieneFiltros)
                {
                    throw new ArgumentException("Debe ingresar al menos un filtro de búsqueda.");
                }

               //string consulta ="SELECT a.Id AS IdArticulo, a.Codigo AS CodigoArticulo, a.Nombre AS NombreArticulo, a.Descripcion AS DescripcionArticulo, a.IdMarca, m.Descripcion AS DescripcionMarca, a.IdCategoria, c.Descripcion AS DescripcionCategoria, a.Precio AS PrecioArticulo FROM ARTICULOS a INNER JOIN MARCAS m ON a.IdMarca = m.Id INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id ";  // de esta manera se pueden agregar AND dinámicamente
                string consulta = "SELECT a.Id AS IdArticulo, a.Codigo AS CodigoArticulo, a.Nombre AS NombreArticulo, a.Descripcion AS DescripcionArticulo, a.IdMarca, m.Descripcion AS DescripcionMarca, a.IdCategoria, c.Descripcion AS DescripcionCategoria, a.Precio AS PrecioArticulo, i.ImagenUrl FROM ARTICULOS a INNER JOIN MARCAS m ON a.IdMarca = m.Id INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id LEFT JOIN IMAGENES i ON a.Id = i.IdArticulo";

                bool primerFiltro = true;

                if (!string.IsNullOrWhiteSpace(articulo.CodigoArticulo))
                {
                    consulta += primerFiltro ? " WHERE " : " AND ";
                    consulta += "a.Codigo = @CodArticulo ";
                    accesoDatos.setearParametros("@CodArticulo", articulo.CodigoArticulo);
                    primerFiltro = false;
                }

                // uso el operador ? para validar que categoria no sea null y poder acceder a descripcionCategoria
                if (!string.IsNullOrWhiteSpace(articulo.Categoria?.DescripcionCategoria))
                {
                    consulta += primerFiltro ? " WHERE " : " AND ";
                    consulta += "c.Descripcion LIKE @DescripcionCategoria ";
                    accesoDatos.setearParametros("@DescripcionCategoria", "%" + articulo.Categoria.DescripcionCategoria + "%");
                    primerFiltro = false;
                }
                if (!string.IsNullOrWhiteSpace(articulo.NombreArticulo))
                {
                    consulta += primerFiltro ? " WHERE " : " AND ";
                    consulta += "a.Nombre LIKE @Nombre ";
                    accesoDatos.setearParametros("@Nombre", "%" + articulo.NombreArticulo + "%");
                    primerFiltro = false;
                }

                if (!string.IsNullOrWhiteSpace(articulo.Marca?.MarcaDescripcion))
                {
                    consulta += primerFiltro ? " WHERE " : " AND ";
                    consulta += "m.Descripcion LIKE @DescripcionMarca ";
                    accesoDatos.setearParametros("@DescripcionMarca", "%" + articulo.Marca.MarcaDescripcion + "%");
                    primerFiltro = false;
                }
                if (articulo.PrecioArticulo > 0)
                {
                    consulta += primerFiltro ? " WHERE " : " AND ";
                    consulta += "a.Precio = @Precio ";
                    accesoDatos.setearParametros("@Precio", articulo.PrecioArticulo );
                    primerFiltro = false;
                }


                accesoDatos.setearConsulta(consulta);
                accesoDatos.ejecutarConsulta();

                // leo la consulta y la guardo en una lista
                // creo un diccionario por que resulta que un articulo puede tener mas de una imagen
                Dictionary<int, Articulo> dictArticulos = new Dictionary<int, Articulo>();
                while (accesoDatos.Lector.Read())
                {
                    int idArticulo = (int)accesoDatos.Lector["IdArticulo"];
                    Articulo aux;
                    if (!dictArticulos.ContainsKey(idArticulo))
                    {
                        aux = new Articulo();
                        aux.IdArticulo = idArticulo;
                        aux.CodigoArticulo = (string)accesoDatos.Lector["CodigoArticulo"];
                        aux.NombreArticulo = (string)accesoDatos.Lector["NombreArticulo"];
                        aux.DescripcionArticulo = (string)accesoDatos.Lector["DescripcionArticulo"];
                        aux.PrecioArticulo = (decimal)accesoDatos.Lector["PrecioArticulo"];
                        aux.Marca = new Marca();
                        aux.Marca.IdMarca = (int)accesoDatos.Lector["IdMarca"];
                        aux.Marca.MarcaDescripcion = (string)accesoDatos.Lector["DescripcionMarca"];
                        aux.Categoria = new Categoria();
                        aux.Categoria.IdCategoria = (int)accesoDatos.Lector["IdCategoria"];
                        aux.Categoria.DescripcionCategoria = (string)accesoDatos.Lector["DescripcionCategoria"];

                        aux.Imagenes = new List<Imagen>();
                        

                        dictArticulos.Add(idArticulo, aux); // al diccionario agrego  el articulo completo
                    }
                    else
                    {
                        aux = dictArticulos[idArticulo]; // si ya existe recupero el articulo completo 
                    }

                    if (!accesoDatos.Lector.IsDBNull(accesoDatos.Lector.GetOrdinal("ImagenUrl")))

                    {
                        Imagen auxImagen = new Imagen();
                        auxImagen.IdArticulo = idArticulo;
                        auxImagen.ImagenUrl = accesoDatos.Lector["ImagenUrl"].ToString();

                        
                        aux.Imagenes.Add(auxImagen); 
                    }
                }

                lista = dictArticulos.Values.ToList();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public void modificar(Articulo articulo)
		{
			AccesoDatos accesoDatos = new AccesoDatos();
			try
			{
				accesoDatos.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio WHERE Id = @Id");

				accesoDatos.setearParametros("@Codigo", articulo.CodigoArticulo);
				accesoDatos.setearParametros("@Nombre", articulo.NombreArticulo);
				accesoDatos.setearParametros("@Descripcion", articulo.DescripcionArticulo);
				accesoDatos.setearParametros("@Precio", articulo.PrecioArticulo);
				accesoDatos.setearParametros("@Id", articulo.IdArticulo);

				accesoDatos.setearParametros("@IdMarca", articulo.Marca.IdMarca);
				accesoDatos.setearParametros("@IdCategoria", articulo.Categoria.IdCategoria);


				accesoDatos.ejecutarConsulta();
            }
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
                accesoDatos.cerrarConexion();
			}
        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos accesoDatos = new AccesoDatos();
                accesoDatos.setearConsulta("DELETE FROM ARTICULOS WHERE id = @id");
                accesoDatos.setearParametros("@id", id);
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
