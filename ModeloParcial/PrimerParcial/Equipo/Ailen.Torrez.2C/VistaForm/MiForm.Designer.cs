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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lblDni = new System.Windows.Forms.Label();
            this.nupDni = new System.Windows.Forms.NumericUpDown();
            this.lblExperiencia = new System.Windows.Forms.Label();
            this.nupExperiencia = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupExperiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Leave += new System.EventHandler(this.btnNombre_OnLeave);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(55, 82);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(105, 79);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(131, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Leave += new System.EventHandler(this.btnApellido_OnLeave);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(55, 110);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(105, 108);
            this.nudEdad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(131, 20);
            this.nudEdad.TabIndex = 5;
            this.nudEdad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(61, 144);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 6;
            this.lblDni.Text = "DNI";
            // 
            // nupDni
            // 
            this.nupDni.Location = new System.Drawing.Point(105, 144);
            this.nupDni.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupDni.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupDni.Name = "nupDni";
            this.nupDni.Size = new System.Drawing.Size(131, 20);
            this.nupDni.TabIndex = 7;
            this.nupDni.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblExperiencia
            // 
            this.lblExperiencia.AutoSize = true;
            this.lblExperiencia.Location = new System.Drawing.Point(37, 180);
            this.lblExperiencia.Name = "lblExperiencia";
            this.lblExperiencia.Size = new System.Drawing.Size(62, 13);
            this.lblExperiencia.TabIndex = 8;
            this.lblExperiencia.Text = "Experiencia";
            // 
            // nupExperiencia
            // 
            this.nupExperiencia.Location = new System.Drawing.Point(106, 180);
            this.nupExperiencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupExperiencia.Name = "nupExperiencia";
            this.nupExperiencia.Size = new System.Drawing.Size(130, 20);
            this.nupExperiencia.TabIndex = 9;
            this.nupExperiencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(58, 249);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 35);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_OnClick);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(161, 249);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 35);
            this.btnValidar.TabIndex = 11;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_OnClick);
            // 
            // MiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 334);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.nupExperiencia);
            this.Controls.Add(this.lblExperiencia);
            this.Controls.Add(this.nupDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "MiForm";
            this.Text = "FormDT";
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupExperiencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.NumericUpDown nupDni;
        private System.Windows.Forms.Label lblExperiencia;
        private System.Windows.Forms.NumericUpDown nupExperiencia;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnValidar;
    }
}

