using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.IdCategoria = (int)accesoDatos.Lector["Id"];

                    if(!(accesoDatos.Lector["Descripcion"] is DBNull))
                        aux.DescripcionCategoria = (string)accesoDatos.Lector["Descripcion"];

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
                accesoDatos.cerrarConexion();
            }
        }
    }
}
