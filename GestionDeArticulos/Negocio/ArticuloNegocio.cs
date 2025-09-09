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
				AccesoDatos.setearConsulta("select id, Codigo, Nombre,Descripcion, Precio from ARTICULOS");
				AccesoDatos.ejecutarConsulta();
				while (AccesoDatos.Lector.Read())
				{
					Articulo aux = new Articulo();
					aux.IdArticulo = (int)AccesoDatos.Lector["id"];
					aux.CodigoArticulo = (string)AccesoDatos.Lector["Codigo"];
					aux.NombreArticulo = (string)AccesoDatos.Lector["Nombre"];
					aux.DescripcionArticulo = (string)AccesoDatos.Lector["Descripcion"];
					aux.PrecioArticulo = (decimal)AccesoDatos.Lector["Precio"];

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
