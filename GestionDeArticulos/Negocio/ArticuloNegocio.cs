using Dominio;
using System;
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


                accesoDatos.cerrarConexion();
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
    }
}
