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
using System.Collections;

namespace Practico_2_adasme
{
    public partial class Form1 : Form
    {
        String ruta;
        int cont = 0;
        int cont_palabras = 0;
        int cont_letras = 0;
        int cont_volaes = 0;
        int cont_consona = 0;
        int cont_blancos = 0;
        public Form1()
        {
            InitializeComponent();
            button4.Enabled = false;
            btnGuardar.Enabled = false;
            btnProcesar.Enabled = false;
            cboQuitar.Enabled = false;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog v = new OpenFileDialog();
            v.Filter = "TXT(*.TXT)|*.txt";


            if (v.ShowDialog() == DialogResult.OK )
            {
                ruta = v.FileName;
                txtExaminar.Text = ruta;
                button1.Enabled = false;
                button4.Enabled = true;
            }
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            string[] veri;

            veri = ruta.Split('.');

            if (veri[1].Equals("txt"))
            {
                button1.Enabled = true;
                button4.Enabled = false;
                txtExaminar.Text = "";
                btnGuardar.Enabled = true;
                btnProcesar.Enabled = true;
                cboQuitar.Enabled = true;
                StreamReader objReader = new StreamReader(ruta);
                txtArea.Text = System.IO.File.ReadAllText(ruta);
                string sLine = "";
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();

                    if (!String.IsNullOrEmpty(sLine))
                    {
                        cont = cont + 1;
                        String[] palabras = sLine.Split(' ');
                        char [] espacios = sLine.ToCharArray();
                        foreach (var item in espacios)
                        {
                            if (item == ' ')
                            {
                                cont_blancos = cont_blancos + 1;
                            }
                        }

                        for (int i = 0; i < palabras.Length; i++)
                        {
                            cont_palabras = cont_palabras + 1;
                            cont_letras = cont_letras + palabras[i].Length;
                            foreach (char item in palabras[i])
                            {
                                if (item.Equals('a') || item.Equals('e') || item.Equals('i') || item.Equals('o') || item.Equals('u')
                                    || item.Equals('A') || item.Equals('E') || item.Equals('I') || item.Equals('O') || item.Equals('U'))
                                {
                                    cont_volaes = cont_volaes + 1;
                                }
                                else
                                {
                                    cont_consona = cont_consona + 1;
                                }
                            }

                        }
                    }
                }
                objReader.Close();

                palabras.Text = Convert.ToString(cont_palabras);
                caracte.Text = Convert.ToString(cont_letras);
                vocales.Text = Convert.ToString(cont_volaes);
                lineas.Text = Convert.ToString(cont);
                consonan.Text = Convert.ToString(cont_consona);
                enblanco.Text = Convert.ToString(cont_blancos);




            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            String valor = Convert.ToString(cboQuitar.SelectedItem);
            String archivo = txtArea.Text;
            char[] palabras = archivo.ToCharArray();
            if (valor.Equals("Consonantes"))
            {
                foreach (var item in palabras)
                {
                    if (item.Equals('a') || item.Equals('e') || item.Equals('i') || item.Equals('o') || item.Equals('u')
                        || item.Equals('A') || item.Equals('E') || item.Equals('I') || item.Equals('O') || item.Equals('U'))
                    {
                        
                    }
                    else
                    {
                        string quitar = Convert.ToString(item);
                        String nuevo = txtArea.Text.Replace(quitar, "");
                        txtArea.Text = nuevo;
                    }
                }
            }
            if (valor.Equals("Vocales"))
            {
                foreach (var item in palabras)
                {
                    if (item.Equals('a') || item.Equals('e') || item.Equals('i') || item.Equals('o') || item.Equals('u')
                        || item.Equals('A') || item.Equals('E') || item.Equals('I') || item.Equals('O') || item.Equals('U'))
                    {
                        string quitar = Convert.ToString(item);
                        String nuevo = txtArea.Text.Replace(quitar, "");
                        txtArea.Text = nuevo;
                    }
                }
            }
            if (valor.Equals("Blancos"))
            {
                String nuevo = txtArea.Text.Replace(" ", "");
                txtArea.Text = nuevo;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog v = new SaveFileDialog();
            v.Filter = "TXT(*.TXT)|*.txt";


            if (v.ShowDialog() == DialogResult.OK)
            {
                String rutaSobre = v.FileName;
                if (!File.Exists(rutaSobre))
                {
                    using (StreamWriter sw = File.CreateText(rutaSobre))
                    {
                        sw.Write(txtArea.Text);
                    }
                }

            }
            
        }
    }
}
