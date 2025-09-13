using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos AccesoDatos = new AccesoDatos();
            try
            {
                AccesoDatos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                AccesoDatos.ejecutarConsulta();

                while (AccesoDatos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.IdMarca = (int)AccesoDatos.Lector["Id"];
                    if(!(AccesoDatos.Lector["Descripcion"] is DBNull))
                        aux.MarcaDescripcion = (string)AccesoDatos.Lector["Descripcion"];
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
