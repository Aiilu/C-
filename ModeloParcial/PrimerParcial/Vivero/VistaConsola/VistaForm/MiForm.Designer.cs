namespace VistaForm
{
    partial class MiForm
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
            this.btnDatos = new System.Windows.Forms.Button();
            this.rtbSalidaTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(513, 12);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(95, 48);
            this.btnDatos.TabIndex = 0;
            this.btnDatos.Text = "Ver Datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_OnClick);
            // 
            // rtbSalidaTexto
            // 
            this.rtbSalidaTexto.Location = new System.Drawing.Point(12, 66);
            this.rtbSalidaTexto.Name = "rtbSalidaTexto";
            this.rtbSalidaTexto.Size = new System.Drawing.Size(595, 297);
            this.rtbSalidaTexto.TabIndex = 1;
            this.rtbSalidaTexto.Text = "";
            // 
            // MiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(620, 375);
            this.Controls.Add(this.rtbSalidaTexto);
            this.Controls.Add(this.btnDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jardin";
            this.Load += new System.EventHandler(this.MiForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.RichTextBox rtbSalidaTexto;
    }
}

