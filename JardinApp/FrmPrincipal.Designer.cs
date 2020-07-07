namespace JardinApp
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.listBoxAlumnos = new System.Windows.Forms.ListBox();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.listBoxAula = new System.Windows.Forms.ListBox();
            this.btnAula = new System.Windows.Forms.Button();
            this.listBoxEvaluados = new System.Windows.Forms.ListBox();
            this.lblRecreo = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTiempoTranscurrido = new System.Windows.Forms.Label();
            this.listBoxAprobados = new System.Windows.Forms.ListBox();
            this.listBoxDesaprobados = new System.Windows.Forms.ListBox();
            this.btnEvaluarAutomatico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProximo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRecreoo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDocentes
            // 
            this.btnDocentes.Location = new System.Drawing.Point(8, 273);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(132, 43);
            this.btnDocentes.TabIndex = 0;
            this.btnDocentes.Text = "Cargar Docentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 225);
            this.listBox1.TabIndex = 1;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(510, 273);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(115, 43);
            this.btnEvaluar.TabIndex = 2;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // listBoxAlumnos
            // 
            this.listBoxAlumnos.FormattingEnabled = true;
            this.listBoxAlumnos.Location = new System.Drawing.Point(179, 24);
            this.listBoxAlumnos.Name = "listBoxAlumnos";
            this.listBoxAlumnos.Size = new System.Drawing.Size(132, 225);
            this.listBoxAlumnos.TabIndex = 3;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Location = new System.Drawing.Point(179, 273);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(132, 43);
            this.btnAlumnos.TabIndex = 4;
            this.btnAlumnos.Text = "Cargar Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // listBoxAula
            // 
            this.listBoxAula.FormattingEnabled = true;
            this.listBoxAula.Location = new System.Drawing.Point(340, 24);
            this.listBoxAula.Name = "listBoxAula";
            this.listBoxAula.Size = new System.Drawing.Size(132, 225);
            this.listBoxAula.TabIndex = 5;
            // 
            // btnAula
            // 
            this.btnAula.Location = new System.Drawing.Point(340, 273);
            this.btnAula.Name = "btnAula";
            this.btnAula.Size = new System.Drawing.Size(132, 43);
            this.btnAula.TabIndex = 6;
            this.btnAula.Text = "Cargar Aulas";
            this.btnAula.UseVisualStyleBackColor = true;
            this.btnAula.Click += new System.EventHandler(this.btnAula_Click);
            // 
            // listBoxEvaluados
            // 
            this.listBoxEvaluados.FormattingEnabled = true;
            this.listBoxEvaluados.Location = new System.Drawing.Point(510, 50);
            this.listBoxEvaluados.Name = "listBoxEvaluados";
            this.listBoxEvaluados.Size = new System.Drawing.Size(164, 199);
            this.listBoxEvaluados.TabIndex = 7;
            // 
            // lblRecreo
            // 
            this.lblRecreo.AutoSize = true;
            this.lblRecreo.Location = new System.Drawing.Point(507, 24);
            this.lblRecreo.Name = "lblRecreo";
            this.lblRecreo.Size = new System.Drawing.Size(60, 13);
            this.lblRecreo.TabIndex = 8;
            this.lblRecreo.Text = "Evaluados:";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(12, 8);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(35, 13);
            this.lblFechaHora.TabIndex = 9;
            this.lblFechaHora.Text = "label1";
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.Location = new System.Drawing.Point(337, 9);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(35, 13);
            this.lblCronometro.TabIndex = 10;
            this.lblCronometro.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTiempoTranscurrido
            // 
            this.lblTiempoTranscurrido.AutoSize = true;
            this.lblTiempoTranscurrido.Location = new System.Drawing.Point(176, 8);
            this.lblTiempoTranscurrido.Name = "lblTiempoTranscurrido";
            this.lblTiempoTranscurrido.Size = new System.Drawing.Size(107, 13);
            this.lblTiempoTranscurrido.TabIndex = 11;
            this.lblTiempoTranscurrido.Text = "Tiempo Transcurrido:";
            // 
            // listBoxAprobados
            // 
            this.listBoxAprobados.FormattingEnabled = true;
            this.listBoxAprobados.Location = new System.Drawing.Point(715, 42);
            this.listBoxAprobados.Name = "listBoxAprobados";
            this.listBoxAprobados.Size = new System.Drawing.Size(132, 225);
            this.listBoxAprobados.TabIndex = 12;
            // 
            // listBoxDesaprobados
            // 
            this.listBoxDesaprobados.FormattingEnabled = true;
            this.listBoxDesaprobados.Location = new System.Drawing.Point(886, 42);
            this.listBoxDesaprobados.Name = "listBoxDesaprobados";
            this.listBoxDesaprobados.Size = new System.Drawing.Size(132, 225);
            this.listBoxDesaprobados.TabIndex = 13;
            // 
            // btnEvaluarAutomatico
            // 
            this.btnEvaluarAutomatico.Location = new System.Drawing.Point(715, 273);
            this.btnEvaluarAutomatico.Name = "btnEvaluarAutomatico";
            this.btnEvaluarAutomatico.Size = new System.Drawing.Size(115, 43);
            this.btnEvaluarAutomatico.TabIndex = 14;
            this.btnEvaluarAutomatico.Text = "Evaluar con Eventos";
            this.btnEvaluarAutomatico.UseVisualStyleBackColor = true;
            this.btnEvaluarAutomatico.Click += new System.EventHandler(this.btnEvaluarAutomatico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(712, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Proximo:";
            // 
            // txtProximo
            // 
            this.txtProximo.Location = new System.Drawing.Point(765, 5);
            this.txtProximo.Name = "txtProximo";
            this.txtProximo.Size = new System.Drawing.Size(122, 20);
            this.txtProximo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(840, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Evaluando:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(843, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(712, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Aprobados:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(883, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Desaprobados:";
            // 
            // lblRecreoo
            // 
            this.lblRecreoo.AutoSize = true;
            this.lblRecreoo.Location = new System.Drawing.Point(648, 275);
            this.lblRecreoo.Name = "lblRecreoo";
            this.lblRecreoo.Size = new System.Drawing.Size(0, 13);
            this.lblRecreoo.TabIndex = 21;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 318);
            this.Controls.Add(this.lblRecreoo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProximo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEvaluarAutomatico);
            this.Controls.Add(this.listBoxDesaprobados);
            this.Controls.Add(this.listBoxAprobados);
            this.Controls.Add(this.lblTiempoTranscurrido);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblRecreo);
            this.Controls.Add(this.listBoxEvaluados);
            this.Controls.Add(this.btnAula);
            this.Controls.Add(this.listBoxAula);
            this.Controls.Add(this.btnAlumnos);
            this.Controls.Add(this.listBoxAlumnos);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDocentes);
            this.Name = "FrmPrincipal";
            this.Text = "JardinUtn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.ListBox listBoxAlumnos;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.ListBox listBoxAula;
        private System.Windows.Forms.Button btnAula;
        private System.Windows.Forms.ListBox listBoxEvaluados;
        private System.Windows.Forms.Label lblRecreo;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTiempoTranscurrido;
        private System.Windows.Forms.ListBox listBoxAprobados;
        private System.Windows.Forms.ListBox listBoxDesaprobados;
        private System.Windows.Forms.Button btnEvaluarAutomatico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProximo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecreoo;
    }
}

