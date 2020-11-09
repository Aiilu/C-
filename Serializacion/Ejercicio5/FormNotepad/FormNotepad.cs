using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using IO;

namespace FormNotepad
{
    public partial class FormNotepad : Form
    {
        private string path = null;

        public FormNotepad()
        {
            InitializeComponent();
        }

        private void stripAbrir_OnClick(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            abrir.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de datos (*.dat)|*.dat";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                if(Path.GetExtension(this.path) == ".txt")
                {
                    this.path = abrir.FileName;

                    PuntoTxt texto = new PuntoTxt();

                    this.richTextBox1.Text = texto.Leer(this.path);
                }
                else
                {
                    this.path = abrir.FileName;

                    PuntoDat texto = new PuntoDat();

                    this.richTextBox1.Text = texto.Leer(this.path).ToString();
                }
            }
        }

        private void StripGuardaComo_OnClick(object sender, EventArgs e)
        {
            this.GuardarComo();
        }

        private void stripGuadar_OnClick(object sender, EventArgs e)
        {
            if(this.path != null)
            {
                if(Path.GetExtension(this.path) == ".txt")
                {
                    PuntoTxt texto = new PuntoTxt();

                    texto.Guardar(this.path, this.richTextBox1.Text);
                }
                else
                {
                    PuntoDat texto = new PuntoDat();
                    //PuntoDat text = (PuntoDat)(this.richTextBox1.Text);
                    texto.Guardar(this.path, texto);
                }
            }
            else
            {
                this.GuardarComo();
            }
        }

        private void GuardarComo()
        {
            SaveFileDialog guardar = new SaveFileDialog();

            guardar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            guardar.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de datos (*.dat)|*.dat";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(this.path) == ".txt")
                {
                    this.path = guardar.FileName;

                    PuntoTxt texto = new PuntoTxt();

                    texto.GuardarComo(this.path, this.richTextBox1.Text);
                }
                else
                {
                    this.path = guardar.FileName;

                    PuntoDat texto = new PuntoDat();

                    texto.GuardarComo(this.path, texto);
                }
            }
        }

        private void TextChan(object sender, EventArgs e)
        {
            this.toolStripStatusLabel2.Text = (this.richTextBox1.Text.Length).ToString() + " Caracteres";
        }
    }
}
