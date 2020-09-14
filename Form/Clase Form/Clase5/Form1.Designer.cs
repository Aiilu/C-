namespace Clase5
{
    partial class MorsitaF
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
            this.BotonNombre = new System.Windows.Forms.Button();
            this.Escribirtxt = new System.Windows.Forms.TextBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonNombre
            // 
            this.BotonNombre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BotonNombre.Location = new System.Drawing.Point(27, 76);
            this.BotonNombre.Name = "BotonNombre";
            this.BotonNombre.Size = new System.Drawing.Size(143, 36);
            this.BotonNombre.TabIndex = 0;
            this.BotonNombre.Text = "Apretame";
            this.BotonNombre.UseVisualStyleBackColor = true;
            this.BotonNombre.Click += new System.EventHandler(this.Click_Nombre);
            // 
            // Escribirtxt
            // 
            this.Escribirtxt.Location = new System.Drawing.Point(27, 40);
            this.Escribirtxt.Name = "Escribirtxt";
            this.Escribirtxt.Size = new System.Drawing.Size(143, 20);
            this.Escribirtxt.TabIndex = 1;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(27, 13);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(47, 13);
            this.NombreLabel.TabIndex = 2;
            this.NombreLabel.Text = "Nombre:";
            // 
            // MorsitaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 162);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.Escribirtxt);
            this.Controls.Add(this.BotonNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MorsitaF";
            this.ShowIcon = false;
            this.Text = "Hola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonNombre;
        private System.Windows.Forms.TextBox Escribirtxt;
        private System.Windows.Forms.Label NombreLabel;
    }
}

