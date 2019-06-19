namespace Producto
{
    partial class AddProductForm
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
            this.lblCodeSKU = new System.Windows.Forms.Label();
            this.txtSKUCode = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescriptionCare = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblIGV = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.gbGeneralInformation = new System.Windows.Forms.GroupBox();
            this.cboFamily = new System.Windows.Forms.ComboBox();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.txtCareDescription = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.gbTransactionInformation = new System.Windows.Forms.GroupBox();
            this.cboDiscount = new System.Windows.Forms.ComboBox();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.gbGeneralInformation.SuspendLayout();
            this.gbTransactionInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodeSKU
            // 
            this.lblCodeSKU.AutoSize = true;
            this.lblCodeSKU.Location = new System.Drawing.Point(19, 27);
            this.lblCodeSKU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodeSKU.Name = "lblCodeSKU";
            this.lblCodeSKU.Size = new System.Drawing.Size(65, 13);
            this.lblCodeSKU.TabIndex = 0;
            this.lblCodeSKU.Text = "Código SKU";
            // 
            // txtSKUCode
            // 
            this.txtSKUCode.Location = new System.Drawing.Point(151, 24);
            this.txtSKUCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtSKUCode.Name = "txtSKUCode";
            this.txtSKUCode.Size = new System.Drawing.Size(108, 20);
            this.txtSKUCode.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(460, 384);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(18, 75);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Descripción";
            // 
            // lblDescriptionCare
            // 
            this.lblDescriptionCare.AutoSize = true;
            this.lblDescriptionCare.Location = new System.Drawing.Point(19, 164);
            this.lblDescriptionCare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescriptionCare.Name = "lblDescriptionCare";
            this.lblDescriptionCare.Size = new System.Drawing.Size(121, 13);
            this.lblDescriptionCare.TabIndex = 4;
            this.lblDescriptionCare.Text = "Descripción del cuidado";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(281, 23);
            this.lblPurchasePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(90, 13);
            this.lblPurchasePrice.TabIndex = 5;
            this.lblPurchasePrice.Text = "Precio de compra";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(19, 21);
            this.lblSalePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(82, 13);
            this.lblSalePrice.TabIndex = 6;
            this.lblSalePrice.Text = "Precio de venta";
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.Location = new System.Drawing.Point(281, 48);
            this.lblIGV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(25, 13);
            this.lblIGV.TabIndex = 7;
            this.lblIGV.Text = "IGV";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(19, 76);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(21, 232);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(40, 13);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "Estado";
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Location = new System.Drawing.Point(297, 54);
            this.lblFamilia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(39, 13);
            this.lblFamilia.TabIndex = 12;
            this.lblFamilia.Text = "Familia";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(297, 28);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(37, 13);
            this.lblBrand.TabIndex = 13;
            this.lblBrand.Text = "Marca";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(18, 50);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(59, 13);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "Descuento";
            // 
            // gbGeneralInformation
            // 
            this.gbGeneralInformation.Controls.Add(this.cboFamily);
            this.gbGeneralInformation.Controls.Add(this.cboBrand);
            this.gbGeneralInformation.Controls.Add(this.txtCareDescription);
            this.gbGeneralInformation.Controls.Add(this.txtDescription);
            this.gbGeneralInformation.Controls.Add(this.txtName);
            this.gbGeneralInformation.Controls.Add(this.lblName);
            this.gbGeneralInformation.Controls.Add(this.cbActive);
            this.gbGeneralInformation.Controls.Add(this.txtSKUCode);
            this.gbGeneralInformation.Controls.Add(this.lblCodeSKU);
            this.gbGeneralInformation.Controls.Add(this.lblState);
            this.gbGeneralInformation.Controls.Add(this.lblBrand);
            this.gbGeneralInformation.Controls.Add(this.lblDescription);
            this.gbGeneralInformation.Controls.Add(this.lblFamilia);
            this.gbGeneralInformation.Controls.Add(this.lblDescriptionCare);
            this.gbGeneralInformation.Location = new System.Drawing.Point(16, 15);
            this.gbGeneralInformation.Margin = new System.Windows.Forms.Padding(2);
            this.gbGeneralInformation.Name = "gbGeneralInformation";
            this.gbGeneralInformation.Padding = new System.Windows.Forms.Padding(2);
            this.gbGeneralInformation.Size = new System.Drawing.Size(507, 255);
            this.gbGeneralInformation.TabIndex = 15;
            this.gbGeneralInformation.TabStop = false;
            this.gbGeneralInformation.Text = "Datos generales";
            this.gbGeneralInformation.Enter += new System.EventHandler(this.gbGeneralInformation_Enter);
            // 
            // cboFamily
            // 
            this.cboFamily.FormattingEnabled = true;
            this.cboFamily.Location = new System.Drawing.Point(340, 51);
            this.cboFamily.Margin = new System.Windows.Forms.Padding(2);
            this.cboFamily.Name = "cboFamily";
            this.cboFamily.Size = new System.Drawing.Size(153, 21);
            this.cboFamily.TabIndex = 23;
            this.cboFamily.Text = "--Seleccione--";
            // 
            // cboBrand
            // 
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(340, 25);
            this.cboBrand.Margin = new System.Windows.Forms.Padding(2);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(153, 21);
            this.cboBrand.TabIndex = 22;
            this.cboBrand.Text = "--Seleccione--";
            // 
            // txtCareDescription
            // 
            this.txtCareDescription.Location = new System.Drawing.Point(151, 162);
            this.txtCareDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtCareDescription.Multiline = true;
            this.txtCareDescription.Name = "txtCareDescription";
            this.txtCareDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCareDescription.Size = new System.Drawing.Size(342, 55);
            this.txtCareDescription.TabIndex = 20;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(151, 77);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(342, 71);
            this.txtDescription.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(108, 20);
            this.txtName.TabIndex = 18;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 51);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Nombre";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Enabled = false;
            this.cbActive.Location = new System.Drawing.Point(151, 232);
            this.cbActive.Margin = new System.Windows.Forms.Padding(2);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(56, 17);
            this.cbActive.TabIndex = 16;
            this.cbActive.Text = "Activo";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // gbTransactionInformation
            // 
            this.gbTransactionInformation.Controls.Add(this.cboDiscount);
            this.gbTransactionInformation.Controls.Add(this.txtIGV);
            this.gbTransactionInformation.Controls.Add(this.txtStock);
            this.gbTransactionInformation.Controls.Add(this.txtPurchasePrice);
            this.gbTransactionInformation.Controls.Add(this.txtSalePrice);
            this.gbTransactionInformation.Controls.Add(this.lblPurchasePrice);
            this.gbTransactionInformation.Controls.Add(this.lblSalePrice);
            this.gbTransactionInformation.Controls.Add(this.lblDiscount);
            this.gbTransactionInformation.Controls.Add(this.lblIGV);
            this.gbTransactionInformation.Controls.Add(this.lblStock);
            this.gbTransactionInformation.Location = new System.Drawing.Point(16, 274);
            this.gbTransactionInformation.Margin = new System.Windows.Forms.Padding(2);
            this.gbTransactionInformation.Name = "gbTransactionInformation";
            this.gbTransactionInformation.Padding = new System.Windows.Forms.Padding(2);
            this.gbTransactionInformation.Size = new System.Drawing.Size(507, 102);
            this.gbTransactionInformation.TabIndex = 16;
            this.gbTransactionInformation.TabStop = false;
            this.gbTransactionInformation.Text = "Datos de Transacciones";
            // 
            // cboDiscount
            // 
            this.cboDiscount.FormattingEnabled = true;
            this.cboDiscount.Location = new System.Drawing.Point(151, 47);
            this.cboDiscount.Name = "cboDiscount";
            this.cboDiscount.Size = new System.Drawing.Size(108, 21);
            this.cboDiscount.TabIndex = 29;
            this.cboDiscount.Text = "--Seleccione--";
            // 
            // txtIGV
            // 
            this.txtIGV.Location = new System.Drawing.Point(385, 46);
            this.txtIGV.Margin = new System.Windows.Forms.Padding(2);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(108, 20);
            this.txtIGV.TabIndex = 27;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(151, 73);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(108, 20);
            this.txtStock.TabIndex = 26;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(385, 19);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(108, 20);
            this.txtPurchasePrice.TabIndex = 25;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(151, 21);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(108, 20);
            this.txtSalePrice.TabIndex = 24;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 421);
            this.Controls.Add(this.gbTransactionInformation);
            this.Controls.Add(this.gbGeneralInformation);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddProductForm";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.gbGeneralInformation.ResumeLayout(false);
            this.gbGeneralInformation.PerformLayout();
            this.gbTransactionInformation.ResumeLayout(false);
            this.gbTransactionInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodeSKU;
        private System.Windows.Forms.TextBox txtSKUCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDescriptionCare;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.GroupBox gbGeneralInformation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.GroupBox gbTransactionInformation;
        private System.Windows.Forms.TextBox txtCareDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboFamily;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.ComboBox cboDiscount;
    }
}