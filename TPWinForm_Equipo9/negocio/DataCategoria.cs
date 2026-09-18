using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using negocio;

namespace negocio
{
    public class DataCategoria
    {
        public List<Categoria> listar()
        {
            List<Categoria> listarCategoria = new List<Categoria>();
            AccesoSQL datos = new AccesoSQL();
            datos.setConsulta("select id,Descripcion from categorias");

            try
            {
                datos.ConsultaBD();
                while (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)datos.Lector["id"];
                    categoria.descripcion = (string)datos.Lector["Descripcion"];
                    listarCategoria.Add(categoria);
                }


                return listarCategoria;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void agregarCategoria(Categoria categoria)
        {

            AccesoSQL datos = new AccesoSQL();
            try
            {
                datos.setConsulta("insert into categorias (descripcion) values ('" + categoria.descripcion + "')");
                datos.ConsultaBD();
                
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
        public void EliminarCategoria(int id)
        {
            AccesoSQL datos = new AccesoSQL();
            try
            {
                datos.setConsulta("DELETE FROM CATEGORIAS WHERE id = " + id);
                datos.ConsultaBD();
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
