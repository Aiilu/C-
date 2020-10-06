namespace FrmCantina
{
    partial class MiCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiCantina));
            this.rbCerveza = new System.Windows.Forms.RadioButton();
            this.rbAgua = new System.Windows.Forms.RadioButton();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.nupContenido = new System.Windows.Forms.NumericUpDown();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.cbTipoBotella = new System.Windows.Forms.ComboBox();
            this.lblTipoBotella = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.barra = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCerveza
            // 
            this.rbCerveza.AutoSize = true;
            this.rbCerveza.Location = new System.Drawing.Point(26, 385);
            this.rbCerveza.Name = "rbCerveza";
            this.rbCerveza.Size = new System.Drawing.Size(64, 17);
            this.rbCerveza.TabIndex = 1;
            this.rbCerveza.TabStop = true;
            this.rbCerveza.Text = "Cerveza";
            this.rbCerveza.UseVisualStyleBackColor = true;
            // 
            // rbAgua
            // 
            this.rbAgua.AutoSize = true;
            this.rbAgua.Location = new System.Drawing.Point(26, 422);
            this.rbAgua.Name = "rbAgua";
            this.rbAgua.Size = new System.Drawing.Size(50, 17);
            this.rbAgua.TabIndex = 2;
            this.rbAgua.TabStop = true;
            this.rbAgua.Text = "Agua";
            this.rbAgua.UseVisualStyleBackColor = true;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(147, 395);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(132, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(190, 379);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(147, 442);
            this.nudCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(62, 20);
            this.nudCapacidad.TabIndex = 5;
            this.nudCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nupContenido
            // 
            this.nupContenido.Location = new System.Drawing.Point(224, 442);
            this.nupContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupContenido.Name = "nupContenido";
            this.nupContenido.Size = new System.Drawing.Size(55, 20);
            this.nupContenido.TabIndex = 6;
            this.nupContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(144, 422);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 7;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(221, 422);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 8;
            this.lblContenido.Text = "Contenido";
            // 
            // cbTipoBotella
            // 
            this.cbTipoBotella.FormattingEnabled = true;
            this.cbTipoBotella.Location = new System.Drawing.Point(332, 395);
            this.cbTipoBotella.Name = "cbTipoBotella";
            this.cbTipoBotella.Size = new System.Drawing.Size(121, 21);
            this.cbTipoBotella.TabIndex = 9;
            // 
            // lblTipoBotella
            // 
            this.lblTipoBotella.AutoSize = true;
            this.lblTipoBotella.Location = new System.Drawing.Point(356, 379);
            this.lblTipoBotella.Name = "lblTipoBotella";
            this.lblTipoBotella.Size = new System.Drawing.Size(78, 13);
            this.lblTipoBotella.TabIndex = 10;
            this.lblTipoBotella.Text = "Tipo de Botella";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(332, 431);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 34);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // barra
            // 
            this.barra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra.BackgroundImage")));
            this.barra.Location = new System.Drawing.Point(3, 2);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(548, 359);
            this.barra.TabIndex = 12;
            // 
            // MiCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 474);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTipoBotella);
            this.Controls.Add(this.cbTipoBotella);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.nupContenido);
            this.Controls.Add(this.nudCapacidad);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.rbAgua);
            this.Controls.Add(this.rbCerveza);
            this.Name = "MiCantina";
            this.Text = "Alumno Ailen Torrez";
            this.Load += new System.EventHandler(this.MiCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCerveza;
        private System.Windows.Forms.RadioButton rbAgua;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.NumericUpDown nupContenido;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.ComboBox cbTipoBotella;
        private System.Windows.Forms.Label lblTipoBotella;
        private System.Windows.Forms.Button btnAgregar;
        private ControlCantina.Barra barra;
    }
}

