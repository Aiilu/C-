using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador
{
    public partial class FormContador : Form
    {
        public FormContador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string[] palabras = this.rchBoxTxt.Text.Split(' ');

            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            for(int i=0; i<palabras.Length; i++)
            { 
                if(!diccionario.ContainsKey(palabras[i]))
                {
                    diccionario.Add(palabras[i], 1);
                }
                else
                {
                    diccionario[palabras[i]] ++;
                }
            }

            List<KeyValuePair<string, int>> dicOrdenado = diccionario.ToList();
            dicOrdenado.Sort(ordenarPalabras);

            MessageBox.Show($"Palabra: {dicOrdenado[0].Key}, Veces: {dicOrdenado[0].Value}\n" +
                            $"Palabra: {dicOrdenado[1].Key}, Veces: {dicOrdenado[1].Value}\n" +
                            $"Palabra: {dicOrdenado[2].Key}, Veces: {dicOrdenado[2].Value}\n");
        }

        private static int ordenarPalabras(KeyValuePair<string, int> actual, KeyValuePair<string, int> siguiente) //pasar el tipo de variable que vas a ordenar
        {
            if(actual.Value > siguiente.Value)
            {
                return -1; //No ordena
            }
            else if(actual.Value < siguiente.Value)
            {
                return 1; //Ordena
            }

            return 0;
        }
    }
}
