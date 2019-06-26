namespace WindowsFormsApp1
{
    partial class SaleForm
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
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLabel = new System.Windows.Forms.Label();
            this.userLabelContent = new System.Windows.Forms.Label();
            this.boletaRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtDniRuc = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.dgvSaleDetails = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProductSale = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.txtSerialCode = new System.Windows.Forms.TextBox();
            this.gbGeneralInf = new System.Windows.Forms.GroupBox();
            this.pictureSearch = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetails)).BeginInit();
            this.gbGeneralInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ventasToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.archivoToolStripMenuItem.Text = "Ventas";
            // 
            // modificarToolStripMenuItem
            // 
            /*this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);*/
            // 
            // devolucionToolStripMenuItem
            // 
            /*this.devolucionToolStripMenuItem.Name = "devolucionToolStripMenuItem";
            this.devolucionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devolucionToolStripMenuItem.Text = "Devolucion";
            this.devolucionToolStripMenuItem.Click += new System.EventHandler(this.DevolucionToolStripMenuItem_Click_1);*/
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(17, 23);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(54, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Usuario:";
            // 
            // userLabelContent
            // 
            this.userLabelContent.AutoSize = true;
            this.userLabelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabelContent.Location = new System.Drawing.Point(149, 23);
            this.userLabelContent.Name = "userLabelContent";
            this.userLabelContent.Size = new System.Drawing.Size(85, 13);
            this.userLabelContent.TabIndex = 2;
            this.userLabelContent.Text = "ID_VENDEDOR";
            // 
            // boletaRadioButton
            // 
            this.boletaRadioButton.AutoSize = true;
            this.boletaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boletaRadioButton.Location = new System.Drawing.Point(152, 45);
            this.boletaRadioButton.Name = "boletaRadioButton";
            this.boletaRadioButton.Size = new System.Drawing.Size(55, 17);
            this.boletaRadioButton.TabIndex = 3;
            this.boletaRadioButton.TabStop = true;
            this.boletaRadioButton.Text = "Boleta";
            this.boletaRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(218, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Factura";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtDniRuc
            // 
            this.txtDniRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniRuc.Location = new System.Drawing.Point(151, 69);
            this.txtDniRuc.MaxLength = 11;
            this.txtDniRuc.Name = "txtDniRuc";
            this.txtDniRuc.Size = new System.Drawing.Size(129, 20);
            this.txtDniRuc.TabIndex = 6;
            this.txtDniRuc.Enter += new System.EventHandler(this.txtDniRuc_Enter);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(329, 69);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(193, 20);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Text = "Descripción";
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "Efectivo"});
            this.cbMetodoPago.Location = new System.Drawing.Point(152, 96);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(127, 21);
            this.cbMetodoPago.TabIndex = 9;
            this.cbMetodoPago.Text = "Visa";
            // 
            // dgvSaleDetails
            // 
            this.dgvSaleDetails.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dgvSaleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.productPrice,
            this.quantity,
            this.subTotal});
            this.dgvSaleDetails.GridColor = System.Drawing.Color.Black;
            this.dgvSaleDetails.Location = new System.Drawing.Point(17, 48);
            this.dgvSaleDetails.Name = "dgvSaleDetails";
            this.dgvSaleDetails.RowHeadersWidth = 49;
            this.dgvSaleDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleDetails.Size = new System.Drawing.Size(496, 164);
            this.dgvSaleDetails.TabIndex = 10;
            this.dgvSaleDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleDetails_CellContentClick);
            this.dgvSaleDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleDetails_CellValueChanged);
            // 
            // productId
            // 
            this.productId.Frozen = true;
            this.productId.HeaderText = "Cód.";
            this.productId.MinimumWidth = 6;
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            this.productId.Width = 30;
            // 
            // productName
            // 
            this.productName.Frozen = true;
            this.productName.HeaderText = "Nombre";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 300;
            // 
            // productPrice
            // 
            this.productPrice.Frozen = true;
            this.productPrice.HeaderText = "P.U.";
            this.productPrice.MinimumWidth = 6;
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Width = 50;
            // 
            // quantity
            // 
            this.quantity.Frozen = true;
            this.quantity.HeaderText = "Cantidad";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 30;
            // 
            // subTotal
            // 
            this.subTotal.Frozen = true;
            this.subTotal.HeaderText = "Subtotal";
            this.subTotal.MinimumWidth = 6;
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Width = 50;
            // 
            // AddProductSale
            // 
            this.AddProductSale.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AddProductSale.Location = new System.Drawing.Point(401, 25);
            this.AddProductSale.Name = "AddProductSale";
            this.AddProductSale.Size = new System.Drawing.Size(112, 19);
            this.AddProductSale.TabIndex = 11;
            this.AddProductSale.Text = "Agregar producto";
            this.AddProductSale.UseVisualStyleBackColor = false;
            this.AddProductSale.Click += new System.EventHandler(this.AddProductSale_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(415, 223);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(482, 439);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(65, 20);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Guardar ";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSerialCode
            // 
            this.txtSerialCode.Enabled = false;
            this.txtSerialCode.Location = new System.Drawing.Point(329, 23);
            this.txtSerialCode.Name = "txtSerialCode";
            this.txtSerialCode.Size = new System.Drawing.Size(100, 20);
            this.txtSerialCode.TabIndex = 15;
            // 
            // gbGeneralInf
            // 
            this.gbGeneralInf.BackColor = System.Drawing.Color.White;
            this.gbGeneralInf.Controls.Add(this.pictureSearch);
            this.gbGeneralInf.Controls.Add(this.label1);
            this.gbGeneralInf.Controls.Add(this.txtSerialCode);
            this.gbGeneralInf.Controls.Add(this.label6);
            this.gbGeneralInf.Controls.Add(this.label7);
            this.gbGeneralInf.Controls.Add(this.userLabelContent);
            this.gbGeneralInf.Controls.Add(this.userLabel);
            this.gbGeneralInf.Controls.Add(this.cbMetodoPago);
            this.gbGeneralInf.Controls.Add(this.boletaRadioButton);
            this.gbGeneralInf.Controls.Add(this.radioButton1);
            this.gbGeneralInf.Controls.Add(this.txtDniRuc);
            this.gbGeneralInf.Controls.Add(this.txtDescripcion);
            this.gbGeneralInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGeneralInf.Location = new System.Drawing.Point(15, 38);
            this.gbGeneralInf.Margin = new System.Windows.Forms.Padding(2);
            this.gbGeneralInf.Name = "gbGeneralInf";
            this.gbGeneralInf.Padding = new System.Windows.Forms.Padding(2);
            this.gbGeneralInf.Size = new System.Drawing.Size(532, 121);
            this.gbGeneralInf.TabIndex = 31;
            this.gbGeneralInf.TabStop = false;
            this.gbGeneralInf.Text = "Datos generales";
            // 
            // pictureSearch
            // 
            this.pictureSearch.BackgroundImage = global::View.Properties.Resources.icono_buscar;
            this.pictureSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSearch.InitialImage = global::View.Properties.Resources.guardar;
            this.pictureSearch.Location = new System.Drawing.Point(285, 69);
            this.pictureSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pictureSearch.Name = "pictureSearch";
            this.pictureSearch.Size = new System.Drawing.Size(20, 20);
            this.pictureSearch.TabIndex = 109;
            this.pictureSearch.TabStop = false;
            this.pictureSearch.Click += new System.EventHandler(this.pictureSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Comprobante de Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Método de pago";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddProductSale);
            this.groupBox1.Controls.Add(this.dgvSaleDetails);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 173);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(532, 252);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total:";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(563, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbGeneralInf);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SaleForm";
            this.Text = "Gestionar ventas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetails)).EndInit();
            this.gbGeneralInf.ResumeLayout(false);
            this.gbGeneralInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        public System.Windows.Forms.Label userLabel;
        public System.Windows.Forms.Label userLabelContent;
        private System.Windows.Forms.RadioButton boletaRadioButton;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.TextBox txtDniRuc;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.DataGridView dgvSaleDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.Button AddProductSale;
        private System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox txtSerialCode;
        private System.Windows.Forms.GroupBox gbGeneralInf;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureSearch;
    }
}