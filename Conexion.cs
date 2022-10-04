using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace ProyectoTiendita
{
    public class Conexion
    {
        //Variables locales para la conexión
        private string Base;
        private string Server;
        private string Port;
        private string User;
        private string Password;
        private static Conexion Con = null;

        //Definir método para la conexión
        private Conexion() 
        {
            this.Base = "db_tiendita";
            this.Server = "localhost";
            this.Port = "3306";
            this.User = "root";
            this.Password = "Sierra21";
        } 

        public MySqlConnection CrearConexion()
        {
            MySqlConnection Cadena = new MySqlConnection();

            try
            {
                Cadena.ConnectionString = "datasource=" + this.Server +
                                          "; port=" + this.Port +
                                          "; username=" + this.User +
                                          "; password=" + this.Password +
                                          "; database=" + this.Base;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }


    }
}
