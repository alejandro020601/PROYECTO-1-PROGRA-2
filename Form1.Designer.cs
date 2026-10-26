namespace PROYECTO_PROGRA_2_VERSION_FINAL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTituloVentanaMenuInicio = new System.Windows.Forms.Label();
            this.butJugar = new System.Windows.Forms.Button();
            this.butTablaMarcadores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloVentanaMenuInicio
            // 
            this.lblTituloVentanaMenuInicio.AutoSize = true;
            this.lblTituloVentanaMenuInicio.BackColor = System.Drawing.SystemColors.Control;
            this.lblTituloVentanaMenuInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTituloVentanaMenuInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentanaMenuInicio.Location = new System.Drawing.Point(306, 58);
            this.lblTituloVentanaMenuInicio.Name = "lblTituloVentanaMenuInicio";
            this.lblTituloVentanaMenuInicio.Size = new System.Drawing.Size(208, 34);
            this.lblTituloVentanaMenuInicio.TabIndex = 0;
            this.lblTituloVentanaMenuInicio.Text = "NUMERANDO";
            this.lblTituloVentanaMenuInicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // butJugar
            // 
            this.butJugar.BackColor = System.Drawing.SystemColors.Control;
            this.butJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butJugar.Location = new System.Drawing.Point(325, 182);
            this.butJugar.Name = "butJugar";
            this.butJugar.Size = new System.Drawing.Size(167, 47);
            this.butJugar.TabIndex = 1;
            this.butJugar.Text = "JUGAR";
            this.butJugar.UseVisualStyleBackColor = false;
            this.butJugar.Click += new System.EventHandler(this.butJugar_Click);
            // 
            // butTablaMarcadores
            // 
            this.butTablaMarcadores.BackColor = System.Drawing.SystemColors.Control;
            this.butTablaMarcadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTablaMarcadores.Location = new System.Drawing.Point(98, 326);
            this.butTablaMarcadores.Name = "butTablaMarcadores";
            this.butTablaMarcadores.Size = new System.Drawing.Size(620, 49);
            this.butTablaMarcadores.TabIndex = 2;
            this.butTablaMarcadores.Text = "TABLA DE MARCADORES";
            this.butTablaMarcadores.UseVisualStyleBackColor = false;
            this.butTablaMarcadores.Click += new System.EventHandler(this.butTablaMarcadores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butTablaMarcadores);
            this.Controls.Add(this.butJugar);
            this.Controls.Add(this.lblTituloVentanaMenuInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloVentanaMenuInicio;
        private System.Windows.Forms.Button butJugar;
        private System.Windows.Forms.Button butTablaMarcadores;
    }
}

