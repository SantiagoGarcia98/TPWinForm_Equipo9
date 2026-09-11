using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    class DataArticulo
    {
        public List<Articulo> ListarArticulo()
        {
            List <Articulo> list = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try 
            {
                conexion.ConnectionString = "server = localhost\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security = true; ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = ("select A.id, A.codigo,A.nombre, A.descripcion, A.idMarca,M.Descripcion as marca, A.idcategoria,C.Descripcion as categoria,A.precio from articulos A Left join Marcas M on a.idmarca=m.id left join categorias c on a.idcategoria = c.id");
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)lector["id"];
                    aux.Codigo = (string)lector["codigo"];
                    aux.Nombre = (string)lector["nombre"];
                    aux.Descripcion = (string)lector["descripcion"];

                    aux.NombreMarca = new Marca();
                    if (lector["idMarca"] != DBNull.Value)
                        aux.NombreMarca.Id = (int)lector["idMarca"];
                    aux.NombreMarca.descripcion = lector["Marca"] != DBNull.Value //Dejo este comentario aca para explicar que hice : // "¿la columna Marca tiene algo?"
                        ? (string)lector["Marca"] // si: usa ese texto
                        : ""; // el : significa que no: entonces devuelve "";

                    aux.TipoCategoria = new Categoria();
                    if (lector["IdCategoria"] != DBNull.Value)
                        aux.TipoCategoria.Id = (int)lector["IdCategoria"];
                    aux.TipoCategoria.descripcion = lector["Categoria"] != DBNull.Value
                        ? (string)lector["Categoria"]
                        : "";
                    //aux.NombreMarca.Id =(int)lector["idMarca"];

                    aux.Precio = (decimal)lector["precio"];

                    list.Add(aux); 
                }

                conexion.Close();
                return list;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
