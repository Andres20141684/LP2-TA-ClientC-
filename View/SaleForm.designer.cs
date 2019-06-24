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
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetails)).BeginInit();
            this.gbGeneralInf.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(751, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.ventasToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.devolucionToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.archivoToolStripMenuItem.Text = "Ventas";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // devolucionToolStripMenuItem
            // 
            this.devolucionToolStripMenuItem.Name = "devolucionToolStripMenuItem";
            this.devolucionToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.devolucionToolStripMenuItem.Text = "Devolucion";
            this.devolucionToolStripMenuItem.Click += new System.EventHandler(this.DevolucionToolStripMenuItem_Click_1);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(23, 28);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(66, 16);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Usuario:";
            // 
            // userLabelContent
            // 
            this.userLabelContent.AutoSize = true;
            this.userLabelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabelContent.Location = new System.Drawing.Point(199, 28);
            this.userLabelContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabelContent.Name = "userLabelContent";
            this.userLabelContent.Size = new System.Drawing.Size(105, 16);
            this.userLabelContent.TabIndex = 2;
            this.userLabelContent.Text = "ID_VENDEDOR";
            // 
            // boletaRadioButton
            // 
            this.boletaRadioButton.AutoSize = true;
            this.boletaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boletaRadioButton.Location = new System.Drawing.Point(203, 55);
            this.boletaRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boletaRadioButton.Name = "boletaRadioButton";
            this.boletaRadioButton.Size = new System.Drawing.Size(65, 20);
            this.boletaRadioButton.TabIndex = 3;
            this.boletaRadioButton.TabStop = true;
            this.boletaRadioButton.Text = "Boleta";
            this.boletaRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(396, 55);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Factura";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtDniRuc
            // 
            this.txtDniRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniRuc.Location = new System.Drawing.Point(201, 85);
            this.txtDniRuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDniRuc.Name = "txtDniRuc";
            this.txtDniRuc.Size = new System.Drawing.Size(171, 22);
            this.txtDniRuc.TabIndex = 6;
            this.txtDniRuc.Text = "Ingrese DNI o RUC";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(396, 89);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(299, 22);
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
            this.cbMetodoPago.Location = new System.Drawing.Point(203, 118);
            this.cbMetodoPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(168, 24);
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
            this.dgvSaleDetails.Location = new System.Drawing.Point(23, 59);
            this.dgvSaleDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSaleDetails.Name = "dgvSaleDetails";
            this.dgvSaleDetails.RowHeadersWidth = 49;
            this.dgvSaleDetails.Size = new System.Drawing.Size(661, 202);
            this.dgvSaleDetails.TabIndex = 10;
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
            this.AddProductSale.Location = new System.Drawing.Point(535, 31);
            this.AddProductSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddProductSale.Name = "AddProductSale";
            this.AddProductSale.Size = new System.Drawing.Size(149, 23);
            this.AddProductSale.TabIndex = 11;
            this.AddProductSale.Text = "Agregar producto";
            this.AddProductSale.UseVisualStyleBackColor = false;
            this.AddProductSale.Click += new System.EventHandler(this.AddProductSale_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(553, 274);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 12;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(643, 540);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(87, 25);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Guardar ";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSerialCode
            // 
            this.txtSerialCode.Location = new System.Drawing.Point(388, 28);
            this.txtSerialCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSerialCode.Name = "txtSerialCode";
            this.txtSerialCode.Size = new System.Drawing.Size(132, 22);
            this.txtSerialCode.TabIndex = 15;
            // 
            // gbGeneralInf
            // 
            this.gbGeneralInf.BackColor = System.Drawing.Color.White;
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
            this.gbGeneralInf.Location = new System.Drawing.Point(20, 47);
            this.gbGeneralInf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGeneralInf.Name = "gbGeneralInf";
            this.gbGeneralInf.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGeneralInf.Size = new System.Drawing.Size(709, 149);
            this.gbGeneralInf.TabIndex = 31;
            this.gbGeneralInf.TabStop = false;
            this.gbGeneralInf.Text = "Datos generales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Comprobante de Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
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
            this.groupBox1.Location = new System.Drawing.Point(20, 213);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(709, 310);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total:";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(751, 582);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbGeneralInf);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SaleForm";
            this.Text = "Gestionar ventas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetails)).EndInit();
            this.gbGeneralInf.ResumeLayout(false);
            this.gbGeneralInf.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem devolucionToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSerialCode;
        private System.Windows.Forms.GroupBox gbGeneralInf;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}