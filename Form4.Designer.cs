namespace PROYECTO_PROGRA_2_VERSION_FINAL
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lblTituloVentanaNickname1P = new System.Windows.Forms.Label();
            this.txtNickname1P = new System.Windows.Forms.TextBox();
            this.butConfirmarVentanaNickname1P = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloVentanaNickname1P
            // 
            this.lblTituloVentanaNickname1P.AutoSize = true;
            this.lblTituloVentanaNickname1P.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentanaNickname1P.Location = new System.Drawing.Point(229, 51);
            this.lblTituloVentanaNickname1P.Name = "lblTituloVentanaNickname1P";
            this.lblTituloVentanaNickname1P.Size = new System.Drawing.Size(359, 32);
            this.lblTituloVentanaNickname1P.TabIndex = 0;
            this.lblTituloVentanaNickname1P.Text = "INGRESE SU NICKNAME";
            this.lblTituloVentanaNickname1P.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNickname1P
            // 
            this.txtNickname1P.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickname1P.Location = new System.Drawing.Point(359, 147);
            this.txtNickname1P.Name = "txtNickname1P";
            this.txtNickname1P.Size = new System.Drawing.Size(100, 22);
            this.txtNickname1P.TabIndex = 1;
            this.txtNickname1P.TextChanged += new System.EventHandler(this.txtNickname1P_TextChanged);
            // 
            // butConfirmarVentanaNickname1P
            // 
            this.butConfirmarVentanaNickname1P.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConfirmarVentanaNickname1P.Location = new System.Drawing.Point(298, 302);
            this.butConfirmarVentanaNickname1P.Name = "butConfirmarVentanaNickname1P";
            this.butConfirmarVentanaNickname1P.Size = new System.Drawing.Size(222, 56);
            this.butConfirmarVentanaNickname1P.TabIndex = 2;
            this.butConfirmarVentanaNickname1P.Text = "CONFIRMAR";
            this.butConfirmarVentanaNickname1P.UseVisualStyleBackColor = true;
            this.butConfirmarVentanaNickname1P.Click += new System.EventHandler(this.butConfirmarVentanaNickname1P_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butConfirmarVentanaNickname1P);
            this.Controls.Add(this.txtNickname1P);
            this.Controls.Add(this.lblTituloVentanaNickname1P);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloVentanaNickname1P;
        private System.Windows.Forms.TextBox txtNickname1P;
        private System.Windows.Forms.Button butConfirmarVentanaNickname1P;
    }
}