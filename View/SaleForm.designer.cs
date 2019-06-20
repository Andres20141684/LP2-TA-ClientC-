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
            this.ClientLabel = new System.Windows.Forms.Label();
            this.txtDniRuc = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.dgvSaleDetails = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProductSale = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ventasToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.devolucionToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.archivoToolStripMenuItem.Text = "Ventas";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // devolucionToolStripMenuItem
            // 
            this.devolucionToolStripMenuItem.Name = "devolucionToolStripMenuItem";
            this.devolucionToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.devolucionToolStripMenuItem.Text = "Devolucion";
            this.devolucionToolStripMenuItem.Click += new System.EventHandler(this.DevolucionToolStripMenuItem_Click_1);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(32, 43);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(56, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Vendedor:";
            // 
            // userLabelContent
            // 
            this.userLabelContent.AutoSize = true;
            this.userLabelContent.Location = new System.Drawing.Point(95, 43);
            this.userLabelContent.Name = "userLabelContent";
            this.userLabelContent.Size = new System.Drawing.Size(85, 13);
            this.userLabelContent.TabIndex = 2;
            this.userLabelContent.Text = "ID_VENDEDOR";
            // 
            // boletaRadioButton
            // 
            this.boletaRadioButton.AutoSize = true;
            this.boletaRadioButton.Location = new System.Drawing.Point(35, 73);
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
            this.radioButton1.Location = new System.Drawing.Point(35, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Factura";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(35, 130);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(42, 13);
            this.ClientLabel.TabIndex = 5;
            this.ClientLabel.Text = "Cliente:";
            // 
            // txtDniRuc
            // 
            this.txtDniRuc.Location = new System.Drawing.Point(98, 130);
            this.txtDniRuc.Name = "txtDniRuc";
            this.txtDniRuc.Size = new System.Drawing.Size(159, 20);
            this.txtDniRuc.TabIndex = 6;
            this.txtDniRuc.Text = "Ingrese DNI o RUC";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(264, 129);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(273, 20);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Método de pago:";
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "Efectivo"});
            this.cbMetodoPago.Location = new System.Drawing.Point(98, 163);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(121, 21);
            this.cbMetodoPago.TabIndex = 9;
            this.cbMetodoPago.Text = "Visa";
            // 
            // dgvSaleDetails
            // 
            this.dgvSaleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.productPrice,
            this.quantity,
            this.subTotal});
            this.dgvSaleDetails.Location = new System.Drawing.Point(35, 190);
            this.dgvSaleDetails.Name = "dgvSaleDetails";
            this.dgvSaleDetails.Size = new System.Drawing.Size(502, 189);
            this.dgvSaleDetails.TabIndex = 10;
            // 
            // productId
            // 
            this.productId.Frozen = true;
            this.productId.HeaderText = "Cód.";
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            this.productId.Width = 30;
            // 
            // productName
            // 
            this.productName.Frozen = true;
            this.productName.HeaderText = "Nombre";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 300;
            // 
            // productPrice
            // 
            this.productPrice.Frozen = true;
            this.productPrice.HeaderText = "P.U.";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Width = 50;
            // 
            // quantity
            // 
            this.quantity.Frozen = true;
            this.quantity.HeaderText = "Cantidad";
            this.quantity.Name = "quantity";
            this.quantity.Width = 30;
            // 
            // subTotal
            // 
            this.subTotal.Frozen = true;
            this.subTotal.HeaderText = "Subtotal";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Width = 50;
            // 
            // AddProductSale
            // 
            this.AddProductSale.Location = new System.Drawing.Point(425, 163);
            this.AddProductSale.Name = "AddProductSale";
            this.AddProductSale.Size = new System.Drawing.Size(112, 23);
            this.AddProductSale.TabIndex = 11;
            this.AddProductSale.Text = "Agregar producto";
            this.AddProductSale.UseVisualStyleBackColor = true;
            this.AddProductSale.Click += new System.EventHandler(this.AddProductSale_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(320, 397);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(446, 394);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 23);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Guardar venta";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.AddProductSale);
            this.Controls.Add(this.dgvSaleDetails);
            this.Controls.Add(this.cbMetodoPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtDniRuc);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.boletaRadioButton);
            this.Controls.Add(this.userLabelContent);
            this.Controls.Add(this.userLabel);
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
        public System.Windows.Forms.Label ClientLabel;
        public System.Windows.Forms.TextBox txtDniRuc;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.DataGridView dgvSaleDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.Button AddProductSale;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ToolStripMenuItem devolucionToolStripMenuItem;
    }
}