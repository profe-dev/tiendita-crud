using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProyectoTiendita
{
    public class Data_Usuarios
    {
        public Prop_Usuarios Login_user(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection SqlCon = new MySqlConnection();
            SqlCon = Conexion.getInstancia().CrearConexion();
            SqlCon.Open();

            string query = "select id_usuario, password, nombre_usuario, id_tipo from tb_usuarios where usuario like @usuario";
            MySqlCommand Comando = new MySqlCommand(query, SqlCon);
            Comando.Parameters.AddWithValue("@usuario", usuario);

            reader = Comando.ExecuteReader();

            Prop_Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Prop_Usuarios();
                usr.Id = int.Parse(reader["id_usuario"].ToString());
                usr.Password = reader["password"].ToString();
                usr.Nombre = reader["nombre_usuario"].ToString();
                usr.Id_tipo = int.Parse(reader["id_tipo"].ToString());
            }
            return usr;
        }
    }
}
