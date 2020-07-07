using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JardinLogic;
using System.Data.SqlClient;

namespace JardinLogic.Persistencia_de_Datos
{
    public class DocentesDB : DataBaseConnection


    {

        public static void Insert(string nombre, string apellido, int edad, int dni, string sexo, string direccion, string email)
        {
            DocentesDB.Comando.CommandText = "INSERT INTO dbo.Docentes (nombre, apellido, edad, sexo, dni, direccion, email) VALUES (@nombre, @apellido, @edad, @sexo, @dni, @direccion, @email);";
            DocentesDB.Comando.Parameters.Clear();
            //DocentesDB.Comando.Parameters.AddWithValue("@idDocente", id);
            DocentesDB.Comando.Parameters.AddWithValue("@nombre", nombre);
            DocentesDB.Comando.Parameters.AddWithValue("@apellido", apellido);
            DocentesDB.Comando.Parameters.AddWithValue("@edad", edad);
            DocentesDB.Comando.Parameters.AddWithValue("@sexo", sexo);
            DocentesDB.Comando.Parameters.AddWithValue("@dni", dni);
            DocentesDB.Comando.Parameters.AddWithValue("@direccion", direccion);
            DocentesDB.Comando.Parameters.AddWithValue("@email", email);
            DocentesDB.Ejecutar();


        }

        public static void InsertEvaluacion(int idAlumno, int idDocente, int aula, int nota1, int nota2, int notaFinal, string observaciones)
        {
            DocentesDB.Comando.CommandText = "INSERT INTO dbo.Evaluaciones (idAlumno, idDocente, idAula, nota_1, nota_2, notaFinal, observaciones) VALUES (@idAlumno, @idDocente, @idAula, @nota_1, @nota_2, @notaFinal, @Observaciones);";
            DocentesDB.Comando.Parameters.Clear();
            DocentesDB.Comando.Parameters.AddWithValue("@idAlumno", idAlumno);
            DocentesDB.Comando.Parameters.AddWithValue("@idDocente", idDocente);
            DocentesDB.Comando.Parameters.AddWithValue("@idAula", aula);
            DocentesDB.Comando.Parameters.AddWithValue("@nota_1", nota1);
            DocentesDB.Comando.Parameters.AddWithValue("@nota_2", nota2);
            DocentesDB.Comando.Parameters.AddWithValue("@notaFinal", notaFinal);
            DocentesDB.Comando.Parameters.AddWithValue("@observaciones", observaciones);
            DocentesDB.Ejecutar();

        }

        public static List<Alumno> SelectAll()
        {
            List<Alumno> alumnosList = new List<Alumno>();

            try
            {
                DocentesDB.Comando.CommandText = "SELECT * FROM dbo.Alumnos";

                DocentesDB.Conexion.Open();
                SqlDataReader sqlReader = DocentesDB.Comando.ExecuteReader();

                while (sqlReader.Read())
                {
                    int id = Convert.ToInt32(sqlReader["idAlumnos"]);
                    string nombre = sqlReader["nombre"].ToString();
                    string apellido = sqlReader["apellido"].ToString();
                    string direccion = sqlReader["direccion"].ToString();
                    string responsable = sqlReader["responsable"].ToString();
                    int edad = Convert.ToInt32(sqlReader["edad"]);
                    int dni = Convert.ToInt32(sqlReader["dni"]);
                    Alumno alumno = new Alumno(id, nombre, apellido, dni, edad, direccion, responsable);
                    alumnosList.Add(alumno);
                }
            }
            catch (Exception ex)
            {
                throw new JardinException("Error al tratar de obtener los Aulas de la base de datos", ex);
            }
            finally
            {
                if (DocentesDB.Conexion.State == System.Data.ConnectionState.Open)
                {
                    DocentesDB.Conexion.Close();
                }
            }

            return alumnosList;
        }
        public static List<Aula> SelectAllAula()
        {
            List<Aula> AulasList = new List<Aula>();

            try
            {
                DocentesDB.Comando.CommandText = "SELECT * FROM dbo.Aulas";

                DocentesDB.Conexion.Open();
                SqlDataReader sqlReader = DocentesDB.Comando.ExecuteReader();

                while (sqlReader.Read())
                {
                    int id = Convert.ToInt32(sqlReader["idAula"]);
                    string salita = sqlReader["salita"].ToString();

                    Aula Aula = new Aula(id, salita);
                    AulasList.Add(Aula);
                }
            }
            catch (Exception ex)
            {
                throw new JardinException("Error al tratar de obtener los Aulas de la base de datos", ex);
            }
            finally
            {
                if (DocentesDB.Conexion.State == System.Data.ConnectionState.Open)
                {
                    DocentesDB.Conexion.Close();
                }
            }

            return AulasList;
        }
    }
}
