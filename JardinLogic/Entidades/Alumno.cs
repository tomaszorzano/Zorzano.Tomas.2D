using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinLogic
{
    [Serializable]
    public class Alumno
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        private string direccion;
        private string responsable;
        private int idAlumno;



        #endregion

        #region Propiedades
        public int IdAlumno
        {
            get { return this.idAlumno; }
            set { this.idAlumno = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public string Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }

        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }
        #endregion

        #region Constructores
        public Alumno()
        {

        }

        public Alumno(int id, string nombre, string apellido, int dni, int edad, string direccion, string responsable)
        {
            this.idAlumno = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
            this.direccion = direccion;
            this.responsable = responsable;

        }
        #endregion

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }

    }
}
