using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

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
				//AccesoDatos.setearConsulta("select id, Codigo, Nombre,Descripcion, Precio from ARTICULOS");
				//AccesoDatos.ejecutarConsulta();
				//while (AccesoDatos.Lector.Read())
				//{
				//	Articulo aux = new Articulo();
				//	aux.IdArticulo = (int)AccesoDatos.Lector["id"];
				//	aux.CodigoArticulo = (string)AccesoDatos.Lector["Codigo"];
				//	aux.NombreArticulo = (string)AccesoDatos.Lector["Nombre"];
				//	aux.DescripcionArticulo = (string)AccesoDatos.Lector["Descripcion"];
				//	aux.PrecioArticulo = (decimal)AccesoDatos.Lector["Precio"];

				//	lista.Add(aux);
				//}
				//return lista;



                AccesoDatos.setearConsulta("SELECT a.id AS IdArticulo, a.Codigo AS CodigoArticulo, a.Nombre AS NombreArticulo, a.Descripcion AS DescripcionArticulo, m.Descripcion AS DescripcionMarca, c.Descripcion AS DescripcionCategoria, a.Precio AS PrecioArticulo FROM ARTICULOS a INNER JOIN MARCAS m ON a.IdMarca = m.Id INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id;");
                AccesoDatos.ejecutarConsulta();
                while (AccesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = (int)AccesoDatos.Lector["IdArticulo"];
                    aux.CodigoArticulo = (string)AccesoDatos.Lector["CodigoArticulo"];
                    aux.NombreArticulo = (string)AccesoDatos.Lector["NombreArticulo"];
                    aux.DescripcionArticulo = (string)AccesoDatos.Lector["DescripcionArticulo"];
					aux.Marca = new Marca();
					aux.Marca.MarcaDescripcion = (string)AccesoDatos.Lector["DescripcionMarca"];
					aux.Categoria = new Categoria();
					aux.Categoria.DescripcionCategoria = (string)AccesoDatos.Lector["DescripcionCategoria"];
					aux.PrecioArticulo = (decimal)AccesoDatos.Lector["PrecioArticulo"];

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
    }
}
