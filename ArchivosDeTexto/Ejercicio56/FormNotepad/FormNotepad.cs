using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

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
            abrir.Filter = "txt files (*.txt)|*.txt";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                this.path = abrir.FileName;

                ArchText texto = new ArchText();

                this.richTextBox1.Text = texto.Leer(this.path);
            }
        }

        private void Cambiar_OnTextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel2.Text = (this.richTextBox1.Text.Count<char>()).ToString() + "Caracteres";
        }

        private void StripGuardaComo_OnClick(object sender, EventArgs e)
        {
            this.GuardarComo();
        }

        private void stripGuadar_OnClick(object sender, EventArgs e)
        {
            ArchText texto = new ArchText();

            if(this.path != null)
            {
                texto.Guardar(this.path, this.richTextBox1.Text);
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
            guardar.Filter = "txt files (*.txt)|*.txt";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                this.path = guardar.FileName;

                ArchText texto = new ArchText();

                texto.Guardar(this.path, this.richTextBox1.Text);
            }
        }
    }
}
