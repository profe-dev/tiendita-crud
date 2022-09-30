using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProyectoTiendita
{
    public class Data_Articulos
    {
        public DataTable Listado_ar(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string query = "select a.codigo_ar," +
                                  "a.descripcion_ar," +
                                  "a.marca_ar," +
                                  "b.descripcion_um," +
                                  "c.descripcion_ca," +
                                  "a.stock_actual_ar," +
                                  "a.codigo_um," +
                                  "a.codigo_ca " +
                                  "from tb_articulos a " +
                                  "inner join tb_unidad_medidas b on a.codigo_um=b.codigo_um " +
                                  "inner join tb_categorias c on a.codigo_ca=c.codigo_ca " +
                                  "where a.descripcion_ar like '" + cTexto + "'" +
                                  "order by a.codigo_ar";

                MySqlCommand Comando = new MySqlCommand(query, SqlCon);
                Comando.CommandTimeout = 60;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
                            
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if(SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }
    }
}
