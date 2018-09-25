namespace Practico_2_adasme
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtExaminar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.palabras = new System.Windows.Forms.Label();
            this.caracte = new System.Windows.Forms.Label();
            this.enblanco = new System.Windows.Forms.Label();
            this.lineas = new System.Windows.Forms.Label();
            this.vocales = new System.Windows.Forms.Label();
            this.consonan = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboQuitar = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo: ";
            // 
            // txtExaminar
            // 
            this.txtExaminar.Enabled = false;
            this.txtExaminar.Location = new System.Drawing.Point(79, 13);
            this.txtExaminar.Name = "txtExaminar";
            this.txtExaminar.Size = new System.Drawing.Size(210, 20);
            this.txtExaminar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Examinar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(27, 70);
            this.txtArea.Multiline = true;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(343, 102);
            this.txtArea.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Palabras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caracteres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E. en Blanco:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lineas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vocales:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Consonantes:";
            // 
            // palabras
            // 
            this.palabras.AutoSize = true;
            this.palabras.Location = new System.Drawing.Point(244, 182);
            this.palabras.Name = "palabras";
            this.palabras.Size = new System.Drawing.Size(13, 13);
            this.palabras.TabIndex = 10;
            this.palabras.Text = "0";
            // 
            // caracte
            // 
            this.caracte.AutoSize = true;
            this.caracte.Location = new System.Drawing.Point(244, 195);
            this.caracte.Name = "caracte";
            this.caracte.Size = new System.Drawing.Size(13, 13);
            this.caracte.TabIndex = 11;
            this.caracte.Text = "0";
            // 
            // enblanco
            // 
            this.enblanco.AutoSize = true;
            this.enblanco.Location = new System.Drawing.Point(244, 208);
            this.enblanco.Name = "enblanco";
            this.enblanco.Size = new System.Drawing.Size(13, 13);
            this.enblanco.TabIndex = 12;
            this.enblanco.Text = "0";
            // 
            // lineas
            // 
            this.lineas.AutoSize = true;
            this.lineas.Location = new System.Drawing.Point(244, 221);
            this.lineas.Name = "lineas";
            this.lineas.Size = new System.Drawing.Size(13, 13);
            this.lineas.TabIndex = 13;
            this.lineas.Text = "0";
            // 
            // vocales
            // 
            this.vocales.AutoSize = true;
            this.vocales.Location = new System.Drawing.Point(244, 234);
            this.vocales.Name = "vocales";
            this.vocales.Size = new System.Drawing.Size(13, 13);
            this.vocales.TabIndex = 14;
            this.vocales.Text = "0";
            // 
            // consonan
            // 
            this.consonan.AutoSize = true;
            this.consonan.Location = new System.Drawing.Point(244, 247);
            this.consonan.Name = "consonan";
            this.consonan.Size = new System.Drawing.Size(13, 13);
            this.consonan.TabIndex = 15;
            this.consonan.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(373, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "_____________________________________________________________";
            // 
            // cboQuitar
            // 
            this.cboQuitar.FormattingEnabled = true;
            this.cboQuitar.Items.AddRange(new object[] {
            "Vocales",
            "Consonantes",
            "Blancos"});
            this.cboQuitar.Location = new System.Drawing.Point(27, 322);
            this.cboQuitar.Name = "cboQuitar";
            this.cboQuitar.Size = new System.Drawing.Size(121, 21);
            this.cboQuitar.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(71, 306);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Quitar:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(161, 322);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(96, 23);
            this.btnProcesar.TabIndex = 19;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(275, 322);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar como";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(295, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Aceptar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 381);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cboQuitar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.consonan);
            this.Controls.Add(this.vocales);
            this.Controls.Add(this.lineas);
            this.Controls.Add(this.enblanco);
            this.Controls.Add(this.caracte);
            this.Controls.Add(this.palabras);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtExaminar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExaminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label palabras;
        private System.Windows.Forms.Label caracte;
        private System.Windows.Forms.Label enblanco;
        private System.Windows.Forms.Label lineas;
        private System.Windows.Forms.Label vocales;
        private System.Windows.Forms.Label consonan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboQuitar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button4;
    }
}

