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
            AccesoDatos AccesoDatos = new AccesoDatos();
            try
            {
                AccesoDatos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                AccesoDatos.ejecutarConsulta();

                while (AccesoDatos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.IdCategoria = (int)AccesoDatos.Lector["Id"];
                    aux.DescripcionCategoria = (string)AccesoDatos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;            
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                AccesoDatos.cerrarConexion();
            }
        }
    }
}
