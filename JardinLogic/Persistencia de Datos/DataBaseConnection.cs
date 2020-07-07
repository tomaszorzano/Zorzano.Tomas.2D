using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace JardinLogic.Persistencia_de_Datos
{
    public abstract class DataBaseConnection
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;
        protected static DocentesDB ultimaAccion;

        static DataBaseConnection()
        {
            DataBaseConnection.conexion = new SqlConnection(@"Server=DESKTOP-17M3LSM\SQLEXPRESS;Database=JardinUtn;Trusted_Connection=True;");
            DataBaseConnection.comando = new SqlCommand();
            DataBaseConnection.comando.Connection = DataBaseConnection.conexion;
        }

        protected static SqlConnection Conexion
        {
            get
            {
                return DataBaseConnection.conexion;
            }
        }
        protected static SqlCommand Comando
        {
            get
            {
                return DataBaseConnection.comando;
            }
        }
        protected static void Ejecutar()
        {
            try
            {
                DataBaseConnection.Conexion.Open();
                DataBaseConnection.Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new JardinException("Ocurrió un error en la base de datos.", ex);
            }
            finally
            {
                if (DataBaseConnection.Conexion.State == System.Data.ConnectionState.Open)
                {
                    DataBaseConnection.Conexion.Close();
                }
            }
        }




    }
}
