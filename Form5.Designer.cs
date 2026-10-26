namespace PROYECTO_PROGRA_2_VERSION_FINAL
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.butConfirmarVentanaNickname2P = new System.Windows.Forms.Button();
            this.txtNickname1P = new System.Windows.Forms.TextBox();
            this.lblTituloVentanaNickname2P = new System.Windows.Forms.Label();
            this.txtNickname2P = new System.Windows.Forms.TextBox();
            this.lblIdentificador1P = new System.Windows.Forms.Label();
            this.lblIdentificador2P = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butConfirmarVentanaNickname2P
            // 
            this.butConfirmarVentanaNickname2P.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConfirmarVentanaNickname2P.Location = new System.Drawing.Point(307, 365);
            this.butConfirmarVentanaNickname2P.Name = "butConfirmarVentanaNickname2P";
            this.butConfirmarVentanaNickname2P.Size = new System.Drawing.Size(234, 42);
            this.butConfirmarVentanaNickname2P.TabIndex = 5;
            this.butConfirmarVentanaNickname2P.Text = "CONFIRMAR";
            this.butConfirmarVentanaNickname2P.UseVisualStyleBackColor = true;
            this.butConfirmarVentanaNickname2P.Click += new System.EventHandler(this.butConfirmarVentanaNickname1P_Click);
            // 
            // txtNickname1P
            // 
            this.txtNickname1P.Location = new System.Drawing.Point(519, 184);
            this.txtNickname1P.Name = "txtNickname1P";
            this.txtNickname1P.Size = new System.Drawing.Size(100, 22);
            this.txtNickname1P.TabIndex = 4;
            this.txtNickname1P.TextChanged += new System.EventHandler(this.txtNickname1P_TextChanged);
            // 
            // lblTituloVentanaNickname2P
            // 
            this.lblTituloVentanaNickname2P.AutoSize = true;
            this.lblTituloVentanaNickname2P.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentanaNickname2P.Location = new System.Drawing.Point(199, 60);
            this.lblTituloVentanaNickname2P.Name = "lblTituloVentanaNickname2P";
            this.lblTituloVentanaNickname2P.Size = new System.Drawing.Size(420, 32);
            this.lblTituloVentanaNickname2P.TabIndex = 3;
            this.lblTituloVentanaNickname2P.Text = "INGRESEN SUS NICKNAMES";
            this.lblTituloVentanaNickname2P.Click += new System.EventHandler(this.lblTituloVentanaNickname1P_Click);
            // 
            // txtNickname2P
            // 
            this.txtNickname2P.Location = new System.Drawing.Point(519, 276);
            this.txtNickname2P.Name = "txtNickname2P";
            this.txtNickname2P.Size = new System.Drawing.Size(100, 22);
            this.txtNickname2P.TabIndex = 6;
            // 
            // lblIdentificador1P
            // 
            this.lblIdentificador1P.AutoSize = true;
            this.lblIdentificador1P.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificador1P.Location = new System.Drawing.Point(199, 174);
            this.lblIdentificador1P.Name = "lblIdentificador1P";
            this.lblIdentificador1P.Size = new System.Drawing.Size(158, 32);
            this.lblIdentificador1P.TabIndex = 7;
            this.lblIdentificador1P.Text = "Jugador 1:";
            // 
            // lblIdentificador2P
            // 
            this.lblIdentificador2P.AutoSize = true;
            this.lblIdentificador2P.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificador2P.Location = new System.Drawing.Point(199, 266);
            this.lblIdentificador2P.Name = "lblIdentificador2P";
            this.lblIdentificador2P.Size = new System.Drawing.Size(158, 32);
            this.lblIdentificador2P.TabIndex = 8;
            this.lblIdentificador2P.Text = "Jugador 2:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdentificador2P);
            this.Controls.Add(this.lblIdentificador1P);
            this.Controls.Add(this.txtNickname2P);
            this.Controls.Add(this.butConfirmarVentanaNickname2P);
            this.Controls.Add(this.txtNickname1P);
            this.Controls.Add(this.lblTituloVentanaNickname2P);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butConfirmarVentanaNickname2P;
        private System.Windows.Forms.TextBox txtNickname1P;
        private System.Windows.Forms.Label lblTituloVentanaNickname2P;
        private System.Windows.Forms.TextBox txtNickname2P;
        private System.Windows.Forms.Label lblIdentificador1P;
        private System.Windows.Forms.Label lblIdentificador2P;
    }
}