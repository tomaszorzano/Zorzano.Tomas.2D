using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Globalization;

namespace JardinLogic
{
    [Serializable]
    public class Docente
    {


        // ELEMENTS
        [XmlElement("Id")]
        public int Id { get; set; }

        [XmlElement("Apellido")]
        public string Apellido { get; set; }

        [XmlElement("Nombre")]
        public string Nombre { get; set; }

        [XmlElement("Edad")]
        public int Edad { get; set; }

        [XmlElement("Sexo")]
        public string Sexo { get; set; }

        [XmlElement("Dni")]
        public int Dni { get; set; }

        [XmlElement("Direccion")]
        public string Direccion { get; set; }

        [XmlElement("Email")]
        public string Email { get; set; }

        // CONSTRUCTOR
        public Docente()
        { }

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }




        //#region Atributos
        //private string nombre;
        //private string apellido;
        //private int edad;
        //private int dni;
        //private string sexo;
        //private string direccion;
        //private string email;
        //private int id;

        //private List<Docente> arrayOfDocentes;

        //public List<Docente> ArrayOfDocente
        //{
        //    get { return this.arrayOfDocentes; }
        //    set { this.arrayOfDocentes = value; }
        //}

        //#endregion

        //#region Propiedades
        //public int Id
        //{
        //    get { return this.id; }
        //    set { this.id = value; }
        //}
        //public string Email
        //{
        //    get { return email; }
        //    set { email = value; }
        //}


        //public string Direccion
        //{
        //    get { return direccion; }
        //    set { direccion = value; }
        //}


        //public string Sexo
        //{
        //    get { return sexo; }
        //    set { sexo = value; }
        //}


        //public int Dni
        //{
        //    get { return dni; }
        //    set { dni = value; }
        //}


        //public int Edad
        //{
        //    get { return edad; }
        //    set { edad = value; }
        //}


        //public string Apellido
        //{
        //    get { return apellido; }
        //    set { apellido = value; }
        //}

        //public string Nombre
        //{
        //    get { return nombre; }
        //    set { nombre = value; }
        //}


        //#endregion

        //#region Constructores
        //public Docente()
        //{

        //}
        //public Docente(string nombre, string apellido, int edad, int dni, string sexo, string direccion, string email)
        //{
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.edad = edad;
        //    this.dni = dni;
        //    this.sexo = sexo;
        //    this.direccion = direccion;
        //    this.email = email;
        //}
        //#endregion






    }


}
