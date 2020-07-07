using JardinLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using JardinLogic.Persistencia_de_Datos;

namespace JardinApp
{
    public partial class FrmSecundario : Form
    {
        private Alumno alumnoaEvaluar;
        private Docente docenteqEvalua;
        private Aula aula;
        private Evaluacion evaluacion;
        List<Alumno> aprobados;
        List<Alumno> desaprobados;
        public FrmSecundario(Alumno alumno, Docente docente, Aula aula)
        {
            InitializeComponent();
            this.docenteqEvalua = docente;
            this.alumnoaEvaluar = alumno;
            this.aula = aula;
            evaluacion = new Evaluacion();
            aprobados = new List<Alumno>();
            desaprobados = new List<Alumno>();
        }

        private void FrmSecundario_Load(object sender, EventArgs e)
        {
            this.txtAlumno.Text = alumnoaEvaluar.ToString();
            this.txtDocente.Text = docenteqEvalua.ToString();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            int nota1 = Convert.ToInt32(this.numericUpDown1.Value);
            int nota2 = Convert.ToInt32(this.numericUpDown2.Value);
            int notaFinal = Convert.ToInt32(this.numericUpDownFinal.Value);
            string observaciones = this.txtObservacion.ToString();

            if (this.numericUpDownFinal.Value >= 4)
            {
                DateTime fecha = new DateTime();
                fecha = DateTime.Now;
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop ), String.Format(@"{0}_{1} .xml", alumnoaEvaluar.ToString(), fecha.ToString("ddMMyyyy")));
                Serializador<Alumno>.SerializarAXml(alumnoaEvaluar, ruta);
                
                aprobados.Add(alumnoaEvaluar);
                evaluacion.Evaluar(alumnoaEvaluar.IdAlumno, docenteqEvalua.Id, aula.IdAula, nota1, nota2, notaFinal, observaciones);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                DateTime fecha = new DateTime();
                fecha = DateTime.Now;
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"{0}_{1} .xml", alumnoaEvaluar.ToString(), fecha.ToString("ddMMyyyy")));
                Serializador<Alumno>.SerializarAXml(alumnoaEvaluar, ruta);
                desaprobados.Add(alumnoaEvaluar);
                evaluacion.Evaluar(alumnoaEvaluar.IdAlumno, docenteqEvalua.Id, aula.IdAula, nota1, nota2, notaFinal, observaciones);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
