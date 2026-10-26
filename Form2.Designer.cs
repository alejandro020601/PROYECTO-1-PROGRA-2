namespace PROYECTO_PROGRA_2_VERSION_FINAL
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblTituloVentanaModoJuego = new System.Windows.Forms.Label();
            this.but1Jugador = new System.Windows.Forms.Button();
            this.but2Jugadores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloVentanaModoJuego
            // 
            this.lblTituloVentanaModoJuego.AutoSize = true;
            this.lblTituloVentanaModoJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentanaModoJuego.Location = new System.Drawing.Point(205, 47);
            this.lblTituloVentanaModoJuego.Name = "lblTituloVentanaModoJuego";
            this.lblTituloVentanaModoJuego.Size = new System.Drawing.Size(407, 32);
            this.lblTituloVentanaModoJuego.TabIndex = 0;
            this.lblTituloVentanaModoJuego.Text = "Seleccione el modo de juego";
            this.lblTituloVentanaModoJuego.Click += new System.EventHandler(this.label1_Click);
            // 
            // but1Jugador
            // 
            this.but1Jugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1Jugador.Location = new System.Drawing.Point(313, 163);
            this.but1Jugador.Name = "but1Jugador";
            this.but1Jugador.Size = new System.Drawing.Size(191, 40);
            this.but1Jugador.TabIndex = 1;
            this.but1Jugador.Text = "1 JUGADOR";
            this.but1Jugador.UseVisualStyleBackColor = true;
            this.but1Jugador.Click += new System.EventHandler(this.but1Jugador_Click);
            // 
            // but2Jugadores
            // 
            this.but2Jugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2Jugadores.Location = new System.Drawing.Point(293, 265);
            this.but2Jugadores.Name = "but2Jugadores";
            this.but2Jugadores.Size = new System.Drawing.Size(231, 38);
            this.but2Jugadores.TabIndex = 2;
            this.but2Jugadores.Text = "2 JUGADORES";
            this.but2Jugadores.UseVisualStyleBackColor = true;
            this.but2Jugadores.Click += new System.EventHandler(this.but2Jugadores_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but2Jugadores);
            this.Controls.Add(this.but1Jugador);
            this.Controls.Add(this.lblTituloVentanaModoJuego);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloVentanaModoJuego;
        private System.Windows.Forms.Button but1Jugador;
        private System.Windows.Forms.Button but2Jugadores;
    }
}