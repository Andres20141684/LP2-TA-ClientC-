namespace View
{
    partial class RefundForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRefundDetail = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gbGeneralInf = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerialCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userLabelContent = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.boletaRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButtonFactura = new System.Windows.Forms.RadioButton();
            this.txtDniRuc = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundDetail)).BeginInit();
            this.gbGeneralInf.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvRefundDetail);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(546, 316);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total:";
            // 
            // dgvRefundDetail
            // 
            this.dgvRefundDetail.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dgvRefundDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefundDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.productPrice,
            this.quantity,
            this.pu,
            this.subtotal,
            this.reason});
            this.dgvRefundDetail.GridColor = System.Drawing.Color.Black;
            this.dgvRefundDetail.Location = new System.Drawing.Point(20, 18);
            this.dgvRefundDetail.Name = "dgvRefundDetail";
            this.dgvRefundDetail.RowHeadersWidth = 49;
            this.dgvRefundDetail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvRefundDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRefundDetail.Size = new System.Drawing.Size(516, 245);
            this.dgvRefundDetail.TabIndex = 10;
            this.dgvRefundDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefundDetail_CellValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(436, 281);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // gbGeneralInf
            // 
            this.gbGeneralInf.BackColor = System.Drawing.Color.White;
            this.gbGeneralInf.Controls.Add(this.label1);
            this.gbGeneralInf.Controls.Add(this.txtSerialCode);
            this.gbGeneralInf.Controls.Add(this.label6);
            this.gbGeneralInf.Controls.Add(this.userLabelContent);
            this.gbGeneralInf.Controls.Add(this.userLabel);
            this.gbGeneralInf.Controls.Add(this.boletaRadioButton);
            this.gbGeneralInf.Controls.Add(this.radioButtonFactura);
            this.gbGeneralInf.Controls.Add(this.txtDniRuc);
            this.gbGeneralInf.Controls.Add(this.txtDescripcion);
            this.gbGeneralInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGeneralInf.Location = new System.Drawing.Point(15, 26);
            this.gbGeneralInf.Margin = new System.Windows.Forms.Padding(2);
            this.gbGeneralInf.Name = "gbGeneralInf";
            this.gbGeneralInf.Padding = new System.Windows.Forms.Padding(2);
            this.gbGeneralInf.Size = new System.Drawing.Size(546, 107);
            this.gbGeneralInf.TabIndex = 34;
            this.gbGeneralInf.TabStop = false;
            this.gbGeneralInf.Text = "Datos generales";
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
            // txtSerialCode
            // 
            this.txtSerialCode.Enabled = false;
            this.txtSerialCode.Location = new System.Drawing.Point(329, 23);
            this.txtSerialCode.Name = "txtSerialCode";
            this.txtSerialCode.Size = new System.Drawing.Size(100, 20);
            this.txtSerialCode.TabIndex = 15;
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
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(17, 23);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(54, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Usuario:";
            // 
            // boletaRadioButton
            // 
            this.boletaRadioButton.AutoSize = true;
            this.boletaRadioButton.Enabled = false;
            this.boletaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boletaRadioButton.Location = new System.Drawing.Point(152, 45);
            this.boletaRadioButton.Name = "boletaRadioButton";
            this.boletaRadioButton.Size = new System.Drawing.Size(55, 17);
            this.boletaRadioButton.TabIndex = 3;
            this.boletaRadioButton.TabStop = true;
            this.boletaRadioButton.Text = "Boleta";
            this.boletaRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButtonFactura
            // 
            this.radioButtonFactura.AutoSize = true;
            this.radioButtonFactura.Enabled = false;
            this.radioButtonFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFactura.Location = new System.Drawing.Point(218, 44);
            this.radioButtonFactura.Name = "radioButtonFactura";
            this.radioButtonFactura.Size = new System.Drawing.Size(61, 17);
            this.radioButtonFactura.TabIndex = 4;
            this.radioButtonFactura.TabStop = true;
            this.radioButtonFactura.Text = "Factura";
            this.radioButtonFactura.UseVisualStyleBackColor = true;
            // 
            // txtDniRuc
            // 
            this.txtDniRuc.Enabled = false;
            this.txtDniRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniRuc.Location = new System.Drawing.Point(151, 69);
            this.txtDniRuc.MaxLength = 11;
            this.txtDniRuc.Name = "txtDniRuc";
            this.txtDniRuc.Size = new System.Drawing.Size(129, 20);
            this.txtDniRuc.TabIndex = 6;
            this.txtDniRuc.Text = "Ingrese DNI o RUC";
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
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(584, 370);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(65, 20);
            this.SaveButton.TabIndex = 33;
            this.SaveButton.Text = "Guardar ";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // productId
            // 
            this.productId.HeaderText = "Cód.";
            this.productId.MinimumWidth = 6;
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            this.productId.Width = 70;
            // 
            // productName
            // 
            this.productName.HeaderText = "Nombre";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 250;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Cantidad";
            this.productPrice.MinimumWidth = 6;
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Width = 60;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Devueltos";
            this.quantity.MinimumWidth = 10;
            this.quantity.Name = "quantity";
            this.quantity.Width = 60;
            // 
            // pu
            // 
            this.pu.HeaderText = "p.u.";
            this.pu.MinimumWidth = 6;
            this.pu.Name = "pu";
            this.pu.ReadOnly = true;
            this.pu.Width = 50;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 70;
            // 
            // reason
            // 
            this.reason.HeaderText = "Razon";
            this.reason.Name = "reason";
            this.reason.Width = 150;
            // 
            // RefundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(563, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbGeneralInf);
            this.Controls.Add(this.SaveButton);
            this.Name = "RefundForm";
            this.Text = "RefundForm";
            this.Load += new System.EventHandler(this.RefundForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundDetail)).EndInit();
            this.gbGeneralInf.ResumeLayout(false);
            this.gbGeneralInf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRefundDetail;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox gbGeneralInf;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerialCode;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label userLabelContent;
        public System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.RadioButton boletaRadioButton;
        private System.Windows.Forms.RadioButton radioButtonFactura;
        public System.Windows.Forms.TextBox txtDniRuc;
        private System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn pu;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason;
    }
}