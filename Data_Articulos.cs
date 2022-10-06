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

        public string Guardar_ar(int nOpcion, Prop_Articulos oAr)
        {
            string Rpta = "";
            string query = "";

            MySqlConnection SqlCon = new MySqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                if (nOpcion == 1) //Nuevo Registro
                {
                    query = "insert into tb_articulos (descripcion_ar," +
                        "marca_ar, " +
                        "codigo_um, " +
                        "codigo_ca, " +
                        "stock_actual_ar, " +
                        "fecha_crea, " +
                        "fecha_modifica) " +
                        "values ('"+oAr.Descripcion_ar+"', " +
                        "'"+oAr.Marca_ar+"', " +
                        "'"+oAr.Codigo_um+"', " +
                        "'"+oAr.Codigo_ca+"', " +
                        "'"+oAr.Stock_actual+"', " +
                        "'"+oAr.Fecha_crea+"', " +
                        "'"+oAr.Fecha_modifica+"')";
                        
                }
                else //Actualizar Registro
                {
                    query = "update tb_articulos set descripcion_ar= '" + oAr.Descripcion_ar + "'," +
                                "marca_ar='" + oAr.Marca_ar + "'," +
                                "codigo_um='" + oAr.Codigo_um + "'," +
                                "codigo_ca='" + oAr.Codigo_ca + "'," +
                                "stock_actual_ar='" + oAr.Stock_actual + "'," +
                                "fecha_modifica='" + oAr.Fecha_modifica + "'" +
                                " where codigo_ar='" + oAr.Codigo_ar + "'";
                }
                MySqlCommand Comando = new MySqlCommand(query, SqlCon);
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Rpta;
        }

        public string Eliminar_ar(int nCodigo_ar)
        {
            string Rpta = "";
            string query = "";

            MySqlConnection SqlCon = new MySqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                query = "delete from tb_articulos where codigo_ar='" + nCodigo_ar + "'";

                MySqlCommand Comando = new MySqlCommand(query, SqlCon);
                SqlCon.Open();

                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";

            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return Rpta;

        }
    }
}
