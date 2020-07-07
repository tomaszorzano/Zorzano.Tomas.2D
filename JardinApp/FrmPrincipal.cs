using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using JardinLogic;

using System.Xml;
using System.Xml.Serialization;
using System.IO;
using JardinLogic.Persistencia_de_Datos;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace JardinApp
{
    delegate void Evaluar(object o);
    public partial class FrmPrincipal : Form
    {
        List<Docente> listaDocentes;
        List<Alumno> listaAlumnos;
        List<Alumno> listaAlumnosEvaluados;
        List<Aula> listaAulas;
        List<Alumno> aprobados;
        List<Alumno> desaprobados;
        string rutaAprobados = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\APROBADOS");
        string rutaDesaprobados = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\DESAPROBADOS");
        Queue<Docente> colaDocentes;
        Queue<Alumno> colaAlumnos;
        Queue<Aula> colaAulas;
        Stopwatch stopwatch;
        event Evaluar EvaluarProximo;
        Random random;
        Thread thread;
        const int TIEMPOEVALUACION = 8000;
        int cargoalumnos = 0;
        Thread threadC;
        

        FrmSecundario frmSecundario;
        public FrmPrincipal()
        {
            InitializeComponent();
            listaDocentes = new List<Docente>();
            listaAlumnos = new List<Alumno>();
            listaAlumnosEvaluados = new List<Alumno>();
            listaAulas = new List<Aula>();
            aprobados = new List<Alumno>();
            desaprobados = new List<Alumno>();
            colaDocentes = new Queue<Docente>();
            colaAlumnos = new Queue<Alumno>();
            colaAulas = new Queue<Aula>();
            stopwatch = new Stopwatch();
            random = new Random();
            threadC = new Thread(EnClase);
            

            EvaluarProximo += proximo;
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {


            string ruta = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Docentes\Docentes.xml");
            listaDocentes = Serializador<List<Docente>>.DeserializarXml(ruta);
            listBox1.DataSource = listaDocentes;

            listaDocentes = Serializador<List<Docente>>.DeserializarXml(ruta);


            foreach (Docente aux in listaDocentes)
            {
                colaDocentes.Enqueue(aux);
            }


            foreach (Docente aux in listaDocentes)
            {
                DocentesDB.Insert(aux.Nombre, aux.Apellido, aux.Edad, aux.Dni, aux.Sexo, aux.Direccion, aux.Email);
            }
            btnDocentes.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.InicializarFechaHora();
            this.Recreo();

            stopwatch.Start();
            timer1.Enabled = true;
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            cargoalumnos = 1;
            listaAlumnos = DocentesDB.SelectAll();
            listBoxAlumnos.DataSource = listaAlumnos;
            foreach (Alumno alumno in listaAlumnos)
            {
                colaAlumnos.Enqueue(alumno);
            }
            btnAlumnos.Enabled = false;
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            Alumno auxAlum = (Alumno)listBoxAlumnos.SelectedItem;


            Docente auxdocente = (Docente)listBox1.SelectedItem;


            Aula auxAula = (Aula)listBoxAula.SelectedItem;
            frmSecundario = new FrmSecundario(auxAlum, auxdocente, auxAula);
            frmSecundario.Show();
            listaAlumnosEvaluados.Add(auxAlum);
            listBoxEvaluados.DataSource = null;
            listBoxEvaluados.Refresh();
            listBoxEvaluados.DataSource = listaAlumnosEvaluados;

        }

        private void btnAula_Click(object sender, EventArgs e)
        {
            listaAulas = DocentesDB.SelectAllAula();
            listBoxAula.DataSource = listaAulas;
            btnAula.Enabled = false;
        }

        private void InicializarFechaHora()
        {
            Thread thread = new Thread(ActualizarFechaHora);
            thread.Start();
        }

        private void Recreo()
        {
            
            
            threadC.Start();
        }

        private void EnClase()
        {

            while (true)
            {
                if (this.lblRecreoo.InvokeRequired)
                {
                    this.lblRecreoo.BeginInvoke((MethodInvoker)delegate ()
                    {

                        this.lblRecreoo.Text = "En Clase";
                    }
                    );
                }


                Thread.Sleep(20000);

                if (this.lblRecreoo.InvokeRequired)
                {
                    this.lblRecreoo.BeginInvoke((MethodInvoker)delegate ()
                    {

                        this.lblRecreoo.Text = "Recreo";
                    }
                    );
                }
                Thread.Sleep(5000);
            }
        }
      

        private void ActualizarFechaHora()
        {
            while (true)
            {
                if (this.lblFechaHora.InvokeRequired)
                {
                    this.lblFechaHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblFechaHora.Text = DateTime.Now.ToString();
                    });
                }
                else
                {
                    this.lblFechaHora.Text = DateTime.Now.ToString();
                }

                Thread.Sleep(1000);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)stopwatch.ElapsedMilliseconds);
            lblCronometro.Text = ts.ToString();
        }

        void Evaluar(Alumno alumno, TextBox txt)
        {
            this.mostrarProximo();
            int randDocente = (int)random.Next(0, 9);
            int randAula = (int)random.Next(0, 5);
            bool existeRuta;
            DirectoryInfo di;
            Evaluacion evaluacion = new Evaluacion();
            int nota1 = (int)(random.Next(0, 10));
            int nota2 = (int)(random.Next(0, 10));
            int notaFinal = (int)(random.Next(0, 10));
            string observaciones;
            mostrarEnForm(alumno.ToString(), txt);
            Thread.Sleep(TIEMPOEVALUACION);
            if (notaFinal >= 4)
            {
                observaciones = "APROBADO";
                DateTime fecha = new DateTime();
                fecha = DateTime.Now;
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\APROBADOS", String.Format(@"{0}_{1} .xml", alumno.ToString(), fecha.ToString("ddMMyyyy")));
                existeRuta = Directory.Exists(ruta);

                if (existeRuta == true)
                {
                    Serializador<Alumno>.SerializarAXml(alumno, ruta);
                }
                else
                {
                    di = Directory.CreateDirectory(rutaAprobados);

                    Serializador<Alumno>.SerializarAXml(alumno, ruta);
                    new JardinException("Se Creo la ruta APROBADOS");

                }


                evaluacion.Evaluar(alumno.IdAlumno, listaDocentes[randDocente].Id, listaAulas[randAula].IdAula, nota1, nota2, notaFinal, observaciones);
                aprobados.Add(alumno);
                refrescarlista();
                mostrarEnForm("", txt);
                EvaluarProximo(txt);
            }
            else
            {
                observaciones = "DESAPROBADO";
                DateTime fecha = new DateTime();
                fecha = DateTime.Now;
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\DESAPROBADOS", String.Format(@"{0}_{1} .xml", alumno.ToString(), fecha.ToString("ddMMyyyy")));
                existeRuta = Directory.Exists(ruta);

                if (existeRuta == true)
                {
                    Serializador<Alumno>.SerializarAXml(alumno, ruta);
                }
                else
                {
                    di = Directory.CreateDirectory(rutaDesaprobados);
                    Serializador<Alumno>.SerializarAXml(alumno, ruta);
                    new JardinException("Se Creo la ruta DESAPROBADOS");

                }

                evaluacion.Evaluar(alumno.IdAlumno, listaDocentes[randDocente].Id, listaAulas[randAula].IdAula, nota1, nota2, notaFinal, observaciones);
                desaprobados.Add(alumno);
                refrescarlista();
                mostrarEnForm("", txt);
                EvaluarProximo(txt);


            }


        }

        private void proximo(object textBox)
        {
            if (colaAlumnos.Count > 0)
            {

                Evaluar(colaAlumnos.Dequeue(), (TextBox)textBox);

            }
            else
            {
                MessageBox.Show("Termino Evaluacion");
            }



        }
        void mostrarEnForm(string mensaje, TextBox txt)
        {
            if (txt.InvokeRequired)
            {
                txt.BeginInvoke((MethodInvoker)delegate
                {
                    txt.Text = mensaje;
                });
            }
            else
                txt.Text = mensaje;

        }

        private void btnEvaluarAutomatico_Click(object sender, EventArgs e)
        {


            if (cargoalumnos == 1)
            {
                thread = new Thread(new ParameterizedThreadStart(proximo));

                if (!thread.IsAlive)
                {
                    thread = new Thread(new ParameterizedThreadStart(proximo));
                    thread.Start(textBox1);
                }
            }
            else
            {
                MessageBox.Show("Debe cargar alumnos");
            }






        }

        private void refrescarlista()
        {
            if (listBoxAprobados.InvokeRequired)
            {
                listBoxAprobados.BeginInvoke((MethodInvoker)delegate
                {
                    listBoxAprobados.DataSource = null;
                    listBoxAprobados.DataSource = aprobados;
                });
            }
            else
            {
                listBoxAprobados.DataSource = null;
                listBoxAprobados.DataSource = aprobados;
            }

            if (listBoxDesaprobados.InvokeRequired)
            {
                listBoxDesaprobados.BeginInvoke((MethodInvoker)delegate
                {
                    listBoxDesaprobados.DataSource = null;
                    listBoxDesaprobados.DataSource = desaprobados;
                });
            }
            else
            {
                listBoxDesaprobados.DataSource = null;
                listBoxDesaprobados.DataSource = desaprobados;
            }
        }
        private void mostrarProximo()
        {
            if (colaAlumnos.Count > 0)
            {
                Alumno aux = colaAlumnos.Peek();
                if (txtProximo.InvokeRequired)
                {
                    txtProximo.BeginInvoke((MethodInvoker)delegate
                    {
                        txtProximo.Text = null;
                        txtProximo.Refresh();
                        txtProximo.Text = aux.ToString();
                    });
                }
                else
                {
                    txtProximo.Text = null;
                    txtProximo.Refresh();
                    txtProximo.Text = aux.ToString();
                }
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
        }
    }
}
