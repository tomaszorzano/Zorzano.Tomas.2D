using JardinLogic.Persistencia_de_Datos;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinLogic
{
    public class Evaluacion
    {
        #region Atributos
        private int idAula;
        private int idAlumno;
        private int idDocente;
        private int nota_1;
        private int nota_2;
        private int notaFinal;
        private string observaciones;
        private List<Evaluacion> evaluaciones = new List<Evaluacion>();
        #endregion

        #region Propiedades
        public int IdDocente
        {
            get { return this.idDocente; }
            set { this.idDocente = value; }
        }
        public int IdAlumno
        {
            get { return this.idAlumno; }
            set { this.idAlumno = value; }
        }
        public int IdAula
        {
            get { return this.idAula; }
            set { this.idAula = value; }
        }
        public List<Evaluacion> Evaluaciones
        {
            get { return this.evaluaciones; }
            set { this.evaluaciones = value; }
        }
        public string Observaciones
        {
            get { return this.observaciones; }
            set { this.observaciones = value; }
        }


        public int NotaFinal
        {
            get { return this.notaFinal; }
            set { this.notaFinal = value; }
        }


        public int Nota_2
        {
            get { return this.nota_2; }
            set { this.nota_2 = value; }
        }


        public int Nota_1

        {
            get { return this.nota_1; }
            set { this.nota_1 = value; }
        }
        #endregion

        #region Constructores
        public Evaluacion()
        {

        }

        public Evaluacion(int idAlumno, int idDocente, int idAula, int nota1, int nota2, int notaFinal, string observaciones)
        {
            this.idAlumno = idAlumno;
            this.idDocente = idDocente;
            this.idAula = idAula;
            this.nota_1 = nota1;
            this.nota_2 = nota2;
            this.notaFinal = notaFinal;
            this.observaciones = observaciones;
            
        }
        #endregion

        public void Evaluar(int idAlumno, int idDocente, int idAula, int nota1, int nota2, int notaFinal, string observacion)
        {
            Evaluacion evaluacion = new Evaluacion(idAlumno,idDocente,idAula,nota1,nota2,notaFinal,observacion);
            this.evaluaciones.Add(evaluacion);
            DocentesDB.InsertEvaluacion(idAlumno, idDocente, idAula, nota1, nota2, notaFinal, observacion);

        }
    }
}
