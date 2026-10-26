namespace PROYECTO_PROGRA_2_VERSION_FINAL
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblTituloVentanaTablaMarcadores = new System.Windows.Forms.Label();
            this.dgvMarcadores = new System.Windows.Forms.DataGridView();
            this.Jugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butVolverMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloVentanaTablaMarcadores
            // 
            this.lblTituloVentanaTablaMarcadores.AutoSize = true;
            this.lblTituloVentanaTablaMarcadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentanaTablaMarcadores.Location = new System.Drawing.Point(220, 52);
            this.lblTituloVentanaTablaMarcadores.Name = "lblTituloVentanaTablaMarcadores";
            this.lblTituloVentanaTablaMarcadores.Size = new System.Drawing.Size(377, 32);
            this.lblTituloVentanaTablaMarcadores.TabIndex = 0;
            this.lblTituloVentanaTablaMarcadores.Text = "TABLA DE MARCADORES";
            // 
            // dgvMarcadores
            // 
            this.dgvMarcadores.AllowUserToAddRows = false;
            this.dgvMarcadores.AllowUserToDeleteRows = false;
            this.dgvMarcadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarcadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jugador,
            this.Puntos});
            this.dgvMarcadores.Location = new System.Drawing.Point(289, 142);
            this.dgvMarcadores.Name = "dgvMarcadores";
            this.dgvMarcadores.ReadOnly = true;
            this.dgvMarcadores.RowHeadersWidth = 51;
            this.dgvMarcadores.RowTemplate.Height = 24;
            this.dgvMarcadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcadores.Size = new System.Drawing.Size(240, 150);
            this.dgvMarcadores.TabIndex = 1;
            // 
            // Jugador
            // 
            this.Jugador.HeaderText = "Nickname del jugador";
            this.Jugador.MinimumWidth = 6;
            this.Jugador.Name = "Jugador";
            this.Jugador.ReadOnly = true;
            // 
            // Puntos
            // 
            this.Puntos.HeaderText = "Puntuacion";
            this.Puntos.MinimumWidth = 6;
            this.Puntos.Name = "Puntos";
            this.Puntos.ReadOnly = true;
            // 
            // butVolverMenu
            // 
            this.butVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVolverMenu.Location = new System.Drawing.Point(201, 347);
            this.butVolverMenu.Name = "butVolverMenu";
            this.butVolverMenu.Size = new System.Drawing.Size(423, 45);
            this.butVolverMenu.TabIndex = 2;
            this.butVolverMenu.Text = "Volver al menu de inicio";
            this.butVolverMenu.UseVisualStyleBackColor = true;
            this.butVolverMenu.Click += new System.EventHandler(this.butVolverMenu_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butVolverMenu);
            this.Controls.Add(this.dgvMarcadores);
            this.Controls.Add(this.lblTituloVentanaTablaMarcadores);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloVentanaTablaMarcadores;
        private System.Windows.Forms.DataGridView dgvMarcadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.Button butVolverMenu;
    }
}