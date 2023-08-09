namespace PracticaConVentanas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnIrFormulario = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUltimoPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatuslbNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIrFormulario
            // 
            this.btnIrFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrFormulario.BackColor = System.Drawing.Color.LightYellow;
            this.btnIrFormulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIrFormulario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIrFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIrFormulario.Location = new System.Drawing.Point(383, 284);
            this.btnIrFormulario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIrFormulario.Name = "btnIrFormulario";
            this.btnIrFormulario.Size = new System.Drawing.Size(148, 57);
            this.btnIrFormulario.TabIndex = 0;
            this.btnIrFormulario.Text = "Ir al formulario";
            this.btnIrFormulario.UseVisualStyleBackColor = false;
            this.btnIrFormulario.Click += new System.EventHandler(this.btnIrFormulario_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.configuracionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuCerrar});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem1.Text = "&Archivo";
            // 
            // tsMenuCerrar
            // 
            this.tsMenuCerrar.Name = "tsMenuCerrar";
            this.tsMenuCerrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.tsMenuCerrar.Size = new System.Drawing.Size(224, 26);
            this.tsMenuCerrar.Text = "Cerrar";
            this.tsMenuCerrar.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilPersonaToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.aboutToolStripMenuItem.Text = "&Opciones";
            // 
            // perfilPersonaToolStripMenuItem
            // 
            this.perfilPersonaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoFormularioToolStripMenuItem,
            this.verUltimoPerfilToolStripMenuItem});
            this.perfilPersonaToolStripMenuItem.Name = "perfilPersonaToolStripMenuItem";
            this.perfilPersonaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.perfilPersonaToolStripMenuItem.Text = "Perfil Persona";
            // 
            // nuevoFormularioToolStripMenuItem
            // 
            this.nuevoFormularioToolStripMenuItem.Name = "nuevoFormularioToolStripMenuItem";
            this.nuevoFormularioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.nuevoFormularioToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.nuevoFormularioToolStripMenuItem.Text = "Nuevo formulario";
            this.nuevoFormularioToolStripMenuItem.Click += new System.EventHandler(this.btnIrFormulario_Click);
            // 
            // verUltimoPerfilToolStripMenuItem
            // 
            this.verUltimoPerfilToolStripMenuItem.Name = "verUltimoPerfilToolStripMenuItem";
            this.verUltimoPerfilToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.verUltimoPerfilToolStripMenuItem.Text = "Ver ultimo perfil";
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.configuracionesToolStripMenuItem.Text = "&Configuraciones";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(578, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Cerrar todo";
            this.toolStripButton1.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton2.Text = "Periodiquito";
            this.toolStripButton2.Click += new System.EventHandler(this.btnIrFormulario_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatuslbNombre});
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(578, 26);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatuslbNombre
            // 
            this.tsStatuslbNombre.Name = "tsStatuslbNombre";
            this.tsStatuslbNombre.Size = new System.Drawing.Size(141, 20);
            this.tsStatuslbNombre.Text = "Nombre del usuario";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(578, 401);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnIrFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIrFormulario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuCerrar;
        private System.Windows.Forms.ToolStripMenuItem perfilPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUltimoPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatuslbNombre;
    }
}