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
                this.path = abrir.FileName;

                if (Path.GetExtension(this.path) == ".txt")
                {
                    PuntoTxt texto1 = new PuntoTxt();

                    this.richTextBox1.Text = texto1.Leer(this.path);
                }
                else
                {
                    PuntoDat texto = new PuntoDat();

                    this.richTextBox1.Text = texto.Leer(this.path).Contenido;
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
                    PuntoTxt texto1 = new PuntoTxt();

                    texto1.Guardar(this.path, this.richTextBox1.Text);
                }
                else
                {
                    PuntoDat texto = new PuntoDat();
                    texto.Contenido = this.richTextBox1.Text;
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
                this.path = guardar.FileName;

                if (Path.GetExtension(this.path) == ".txt")
                {
                    PuntoTxt texto1 = new PuntoTxt();

                    texto1.GuardarComo(this.path, this.richTextBox1.Text);
                }
                else
                {
                    PuntoDat texto = new PuntoDat();
                    texto.Contenido = this.richTextBox1.Text;
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
