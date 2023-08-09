namespace PracticaConVentanas
{
    partial class frmClasePersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClasePersona));
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpAnioNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbChocolate = new System.Windows.Forms.CheckBox();
            this.rbNacional = new System.Windows.Forms.RadioButton();
            this.rbExtrangero = new System.Windows.Forms.RadioButton();
            this.rbTurista = new System.Windows.Forms.RadioButton();
            this.gbEstatus = new System.Windows.Forms.GroupBox();
            this.cbDocumento = new System.Windows.Forms.ComboBox();
            this.txtTipoDeDocumento = new System.Windows.Forms.Label();
            this.nudAniosEnElPais = new System.Windows.Forms.NumericUpDown();
            this.txtTiempo = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lbNumeroDocumento = new System.Windows.Forms.Label();
            this.btnCargarInfo = new System.Windows.Forms.Button();
            this.btnMostrarPersona = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatuslbNombre1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbEstatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAniosEnElPais)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(162, 47);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(70, 20);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(254, 44);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.Location = new System.Drawing.Point(76, 91);
            this.lbFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(159, 20);
            this.lbFechaNacimiento.TabIndex = 2;
            this.lbFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpAnioNacimiento
            // 
            this.dtpAnioNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpAnioNacimiento.Location = new System.Drawing.Point(254, 86);
            this.dtpAnioNacimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpAnioNacimiento.Name = "dtpAnioNacimiento";
            this.dtpAnioNacimiento.Size = new System.Drawing.Size(116, 27);
            this.dtpAnioNacimiento.TabIndex = 1;
            // 
            // cbChocolate
            // 
            this.cbChocolate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbChocolate.AutoSize = true;
            this.cbChocolate.Location = new System.Drawing.Point(200, 150);
            this.cbChocolate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbChocolate.Name = "cbChocolate";
            this.cbChocolate.Size = new System.Drawing.Size(193, 24);
            this.cbChocolate.TabIndex = 2;
            this.cbChocolate.Text = "Te gusta el chocolate?";
            this.cbChocolate.UseVisualStyleBackColor = true;
            // 
            // rbNacional
            // 
            this.rbNacional.AutoSize = true;
            this.rbNacional.Checked = true;
            this.rbNacional.Location = new System.Drawing.Point(23, 46);
            this.rbNacional.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbNacional.Name = "rbNacional";
            this.rbNacional.Size = new System.Drawing.Size(93, 24);
            this.rbNacional.TabIndex = 5;
            this.rbNacional.TabStop = true;
            this.rbNacional.Text = "Nacional";
            this.rbNacional.UseVisualStyleBackColor = true;
            // 
            // rbExtrangero
            // 
            this.rbExtrangero.AutoSize = true;
            this.rbExtrangero.Location = new System.Drawing.Point(173, 46);
            this.rbExtrangero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbExtrangero.Name = "rbExtrangero";
            this.rbExtrangero.Size = new System.Drawing.Size(110, 24);
            this.rbExtrangero.TabIndex = 6;
            this.rbExtrangero.Text = "Extrangero";
            this.rbExtrangero.UseVisualStyleBackColor = true;
            // 
            // rbTurista
            // 
            this.rbTurista.AutoSize = true;
            this.rbTurista.Location = new System.Drawing.Point(344, 46);
            this.rbTurista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbTurista.Name = "rbTurista";
            this.rbTurista.Size = new System.Drawing.Size(79, 24);
            this.rbTurista.TabIndex = 7;
            this.rbTurista.Text = "Turista";
            this.rbTurista.UseVisualStyleBackColor = true;
            // 
            // gbEstatus
            // 
            this.gbEstatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbEstatus.Controls.Add(this.rbNacional);
            this.gbEstatus.Controls.Add(this.rbTurista);
            this.gbEstatus.Controls.Add(this.rbExtrangero);
            this.gbEstatus.Location = new System.Drawing.Point(10, 190);
            this.gbEstatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbEstatus.Name = "gbEstatus";
            this.gbEstatus.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbEstatus.Size = new System.Drawing.Size(517, 105);
            this.gbEstatus.TabIndex = 3;
            this.gbEstatus.TabStop = false;
            this.gbEstatus.Text = "Estatus";
            // 
            // cbDocumento
            // 
            this.cbDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDocumento.FormattingEnabled = true;
            this.cbDocumento.Items.AddRange(new object[] {
            "Cedula",
            "Pasaporte",
            "RUC"});
            this.cbDocumento.Location = new System.Drawing.Point(254, 329);
            this.cbDocumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDocumento.Name = "cbDocumento";
            this.cbDocumento.Size = new System.Drawing.Size(94, 28);
            this.cbDocumento.TabIndex = 4;
            // 
            // txtTipoDeDocumento
            // 
            this.txtTipoDeDocumento.AutoSize = true;
            this.txtTipoDeDocumento.Location = new System.Drawing.Point(85, 331);
            this.txtTipoDeDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTipoDeDocumento.Name = "txtTipoDeDocumento";
            this.txtTipoDeDocumento.Size = new System.Drawing.Size(154, 20);
            this.txtTipoDeDocumento.TabIndex = 10;
            this.txtTipoDeDocumento.Text = "Tipo de documento";
            // 
            // nudAniosEnElPais
            // 
            this.nudAniosEnElPais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAniosEnElPais.Location = new System.Drawing.Point(254, 419);
            this.nudAniosEnElPais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudAniosEnElPais.Name = "nudAniosEnElPais";
            this.nudAniosEnElPais.Size = new System.Drawing.Size(57, 27);
            this.nudAniosEnElPais.TabIndex = 6;
            // 
            // txtTiempo
            // 
            this.txtTiempo.AutoSize = true;
            this.txtTiempo.Location = new System.Drawing.Point(100, 424);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(137, 20);
            this.txtTiempo.TabIndex = 12;
            this.txtTiempo.Text = "Tiempo en el pais";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(254, 376);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(94, 27);
            this.txtNumeroDocumento.TabIndex = 5;
            // 
            // lbNumeroDocumento
            // 
            this.lbNumeroDocumento.AutoSize = true;
            this.lbNumeroDocumento.Location = new System.Drawing.Point(56, 379);
            this.lbNumeroDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumeroDocumento.Name = "lbNumeroDocumento";
            this.lbNumeroDocumento.Size = new System.Drawing.Size(181, 20);
            this.lbNumeroDocumento.TabIndex = 13;
            this.lbNumeroDocumento.Text = "Numero de documento";
            // 
            // btnCargarInfo
            // 
            this.btnCargarInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCargarInfo.BackColor = System.Drawing.Color.LightYellow;
            this.btnCargarInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCargarInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCargarInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCargarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarInfo.Location = new System.Drawing.Point(33, 491);
            this.btnCargarInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCargarInfo.MinimumSize = new System.Drawing.Size(202, 38);
            this.btnCargarInfo.Name = "btnCargarInfo";
            this.btnCargarInfo.Size = new System.Drawing.Size(202, 38);
            this.btnCargarInfo.TabIndex = 7;
            this.btnCargarInfo.Text = "Cargar informacion";
            this.btnCargarInfo.UseVisualStyleBackColor = false;
            this.btnCargarInfo.Click += new System.EventHandler(this.btnCargarInfo_Click);
            // 
            // btnMostrarPersona
            // 
            this.btnMostrarPersona.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMostrarPersona.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMostrarPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMostrarPersona.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMostrarPersona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnMostrarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarPersona.Location = new System.Drawing.Point(354, 485);
            this.btnMostrarPersona.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMostrarPersona.Name = "btnMostrarPersona";
            this.btnMostrarPersona.Size = new System.Drawing.Size(136, 51);
            this.btnMostrarPersona.TabIndex = 8;
            this.btnMostrarPersona.Text = "Mostrar Persona";
            this.btnMostrarPersona.UseVisualStyleBackColor = false;
            this.btnMostrarPersona.Click += new System.EventHandler(this.btnMostrarPersona_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatuslbNombre1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 621);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(545, 26);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatuslbNombre1
            // 
            this.tsStatuslbNombre1.Name = "tsStatuslbNombre1";
            this.tsStatuslbNombre1.Size = new System.Drawing.Size(137, 20);
            this.tsStatuslbNombre1.Text = "Nombre de usuario";
            // 
            // frmClasePersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(545, 647);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnMostrarPersona);
            this.Controls.Add(this.btnCargarInfo);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.lbNumeroDocumento);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.nudAniosEnElPais);
            this.Controls.Add(this.txtTipoDeDocumento);
            this.Controls.Add(this.cbDocumento);
            this.Controls.Add(this.gbEstatus);
            this.Controls.Add(this.cbChocolate);
            this.Controls.Add(this.dtpAnioNacimiento);
            this.Controls.Add(this.lbFechaNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(836, 763);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(563, 694);
            this.Name = "frmClasePersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clase Persons";
            this.Load += new System.EventHandler(this.FrmFormulario_Load);
            this.gbEstatus.ResumeLayout(false);
            this.gbEstatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAniosEnElPais)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpAnioNacimiento;
        private System.Windows.Forms.CheckBox cbChocolate;
        private System.Windows.Forms.RadioButton rbNacional;
        private System.Windows.Forms.RadioButton rbExtrangero;
        private System.Windows.Forms.RadioButton rbTurista;
        private System.Windows.Forms.GroupBox gbEstatus;
        private System.Windows.Forms.ComboBox cbDocumento;
        private System.Windows.Forms.Label txtTipoDeDocumento;
        private System.Windows.Forms.NumericUpDown nudAniosEnElPais;
        private System.Windows.Forms.Label txtTiempo;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label lbNumeroDocumento;
        private System.Windows.Forms.Button btnCargarInfo;
        private System.Windows.Forms.Button btnMostrarPersona;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatuslbNombre1;
    }
}

