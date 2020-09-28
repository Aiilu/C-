namespace MiForm
{
    partial class FrmLlamador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNroDestino = new System.Windows.Forms.TextBox();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnAsterico = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.groupboxPanel = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDestino.Location = new System.Drawing.Point(25, 12);
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.ReadOnly = true;
            this.txtNroDestino.Size = new System.Drawing.Size(414, 31);
            this.txtNroDestino.TabIndex = 0;
            this.txtNroDestino.Text = "Nro Destino";
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroOrigen.Location = new System.Drawing.Point(233, 198);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.Size = new System.Drawing.Size(206, 26);
            this.txtNroOrigen.TabIndex = 1;
            this.txtNroOrigen.Text = "Nro Origen";
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(233, 75);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(206, 50);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(233, 131);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(206, 50);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(233, 243);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(206, 50);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_OnClick);
            // 
            // cmbFranja
            // 
            this.cmbFranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Items.AddRange(new object[] {
            "Franja 1",
            "Franja 2",
            "Franja 3"});
            this.cmbFranja.Location = new System.Drawing.Point(25, 314);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(414, 32);
            this.cmbFranja.TabIndex = 5;
            this.cmbFranja.Text = "Franja";
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(25, 75);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(54, 50);
            this.btnUno.TabIndex = 6;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            // 
            // btnDos
            // 
            this.btnDos.Location = new System.Drawing.Point(85, 75);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(54, 50);
            this.btnDos.TabIndex = 7;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(145, 75);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(54, 50);
            this.btnTres.TabIndex = 8;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            // 
            // btnCuatro
            // 
            this.btnCuatro.Location = new System.Drawing.Point(25, 131);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(54, 50);
            this.btnCuatro.TabIndex = 9;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(85, 131);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(54, 50);
            this.btnCinco.TabIndex = 10;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(145, 131);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(54, 50);
            this.btnSeis.TabIndex = 11;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            // 
            // btnSiete
            // 
            this.btnSiete.Location = new System.Drawing.Point(25, 187);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(54, 50);
            this.btnSiete.TabIndex = 12;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            // 
            // btnOcho
            // 
            this.btnOcho.Location = new System.Drawing.Point(85, 187);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(54, 50);
            this.btnOcho.TabIndex = 13;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            // 
            // btnNueve
            // 
            this.btnNueve.Location = new System.Drawing.Point(145, 187);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(54, 50);
            this.btnNueve.TabIndex = 14;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            // 
            // btnAsterico
            // 
            this.btnAsterico.Location = new System.Drawing.Point(25, 243);
            this.btnAsterico.Name = "btnAsterico";
            this.btnAsterico.Size = new System.Drawing.Size(54, 50);
            this.btnAsterico.TabIndex = 15;
            this.btnAsterico.Text = "*";
            this.btnAsterico.UseVisualStyleBackColor = true;
            // 
            // btnCero
            // 
            this.btnCero.Location = new System.Drawing.Point(85, 243);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(54, 50);
            this.btnCero.TabIndex = 16;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(145, 243);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(54, 50);
            this.btnNumeral.TabIndex = 17;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            // 
            // groupboxPanel
            // 
            this.groupboxPanel.Location = new System.Drawing.Point(12, 59);
            this.groupboxPanel.Name = "groupboxPanel";
            this.groupboxPanel.Size = new System.Drawing.Size(200, 243);
            this.groupboxPanel.TabIndex = 18;
            this.groupboxPanel.TabStop = false;
            this.groupboxPanel.Text = "Panel";
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 358);
            this.Controls.Add(this.btnNumeral);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnAsterico);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.txtNroDestino);
            this.Controls.Add(this.groupboxPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLlamador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroDestino;
        private System.Windows.Forms.TextBox txtNroOrigen;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbFranja;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnAsterico;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.GroupBox groupboxPanel;
    }
}