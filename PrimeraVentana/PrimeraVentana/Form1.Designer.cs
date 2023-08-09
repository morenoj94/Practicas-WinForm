namespace PrimeraVentana
{
    partial class VentanaPrincipal
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
            this.LbIntrucciones = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.LbFelicitacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbIntrucciones
            // 
            this.LbIntrucciones.AutoSize = true;
            this.LbIntrucciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIntrucciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LbIntrucciones.Location = new System.Drawing.Point(88, 47);
            this.LbIntrucciones.Name = "LbIntrucciones";
            this.LbIntrucciones.Size = new System.Drawing.Size(0, 27);
            this.LbIntrucciones.TabIndex = 0;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.Location = new System.Drawing.Point(231, 133);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(190, 22);
            this.txtNumero.TabIndex = 1;
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVerificar.BackColor = System.Drawing.Color.Cyan;
            this.BtnVerificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerificar.Location = new System.Drawing.Point(249, 199);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(152, 94);
            this.BtnVerificar.TabIndex = 2;
            this.BtnVerificar.Text = "Lets try";
            this.BtnVerificar.UseVisualStyleBackColor = false;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // LbFelicitacion
            // 
            this.LbFelicitacion.AutoSize = true;
            this.LbFelicitacion.Font = new System.Drawing.Font("Linux Biolinum G", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFelicitacion.Location = new System.Drawing.Point(362, 271);
            this.LbFelicitacion.Name = "LbFelicitacion";
            this.LbFelicitacion.Size = new System.Drawing.Size(0, 32);
            this.LbFelicitacion.TabIndex = 3;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(631, 358);
            this.Controls.Add(this.LbFelicitacion);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.LbIntrucciones);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "VentanaPrincipal";
            this.Text = "Juego de Azar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbIntrucciones;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.Label LbFelicitacion;
    }
}

