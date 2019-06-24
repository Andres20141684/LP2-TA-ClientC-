namespace View
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiondeinformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.familiaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proovedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTesto = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.transaccionesToolStripMenuItem,
            this.gestiondeinformacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 104, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(156, 355);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.DarkTurquoise;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 15, 4, 0);
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(143, 34);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.salirToolStripMenuItem.Text = "Cerrar sesión";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ventasToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 15, 4, 0);
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(143, 34);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            this.transaccionesToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.VentasToolStripMenuItem_Click);
            // 
            // gestiondeinformacionToolStripMenuItem
            // 
            this.gestiondeinformacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem1,
            this.familiaDeProductosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.proovedoresToolStripMenuItem,
            this.localesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.gestiondeinformacionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gestiondeinformacionToolStripMenuItem.Name = "gestiondeinformacionToolStripMenuItem";
            this.gestiondeinformacionToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 15, 4, 0);
            this.gestiondeinformacionToolStripMenuItem.Size = new System.Drawing.Size(143, 34);
            this.gestiondeinformacionToolStripMenuItem.Text = "Gestión de Información";
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.productosToolStripMenuItem1.Text = "Productos";
            this.productosToolStripMenuItem1.Click += new System.EventHandler(this.ProductosToolStripMenuItem1_Click);
            // 
            // familiaDeProductosToolStripMenuItem
            // 
            this.familiaDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.familiaDeProductosToolStripMenuItem.Name = "familiaDeProductosToolStripMenuItem";
            this.familiaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.familiaDeProductosToolStripMenuItem.Text = "Familia de Productos";
            this.familiaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.FamiliaDeProductosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // proovedoresToolStripMenuItem
            // 
            this.proovedoresToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.proovedoresToolStripMenuItem.Name = "proovedoresToolStripMenuItem";
            this.proovedoresToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.proovedoresToolStripMenuItem.Text = "Proveedores";
            this.proovedoresToolStripMenuItem.Click += new System.EventHandler(this.ProovedoresToolStripMenuItem_Click);
            // 
            // localesToolStripMenuItem
            // 
            this.localesToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.localesToolStripMenuItem.Name = "localesToolStripMenuItem";
            this.localesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.localesToolStripMenuItem.Text = "Locales";
            this.localesToolStripMenuItem.Click += new System.EventHandler(this.LocalesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.ReportesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lblNameUser);
            this.panel1.Controls.Add(this.pictureUser);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.username);
            this.panel1.Location = new System.Drawing.Point(147, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 355);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblNameUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameUser.Location = new System.Drawing.Point(529, 0);
            this.lblNameUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Padding = new System.Windows.Forms.Padding(4);
            this.lblNameUser.Size = new System.Drawing.Size(108, 23);
            this.lblNameUser.TabIndex = 9;
            this.lblNameUser.Text = "Nombre de Usuario";
            this.lblNameUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureUser
            // 
            this.pictureUser.Image = global::View.Properties.Resources.icono;
            this.pictureUser.Location = new System.Drawing.Point(496, 0);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(2);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(35, 22);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 10;
            this.pictureUser.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::View.Properties.Resources.icono;
            this.pictureBox2.Location = new System.Drawing.Point(743, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.PaleTurquoise;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.username.Location = new System.Drawing.Point(794, 0);
            this.username.Name = "username";
            this.username.Padding = new System.Windows.Forms.Padding(6);
            this.username.Size = new System.Drawing.Size(112, 27);
            this.username.TabIndex = 0;
            this.username.Text = "Nombre de Usuario";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.mate_logo_smaller;
            this.pictureBox1.Location = new System.Drawing.Point(30, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbTesto
            // 
            this.lbTesto.AutoSize = true;
            this.lbTesto.Location = new System.Drawing.Point(53, 319);
            this.lbTesto.Name = "lbTesto";
            this.lbTesto.Size = new System.Drawing.Size(35, 13);
            this.lbTesto.TabIndex = 11;
            this.lbTesto.Text = "label1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::View.Properties.Resources.whitebackground;
            this.ClientSize = new System.Drawing.Size(784, 355);
            this.Controls.Add(this.lbTesto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Sistema de Bodega MATE";
            this.Load += new System.EventHandler(this.MainWindow_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiondeinformacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proovedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familiaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Label lbTesto;
    }
}