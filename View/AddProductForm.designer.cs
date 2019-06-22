﻿namespace Producto
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbGeneralInformation.SuspendLayout();
            this.gbTransactionInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeSKU
            // 
            this.lblCodeSKU.AutoSize = true;
            this.lblCodeSKU.Location = new System.Drawing.Point(28, 42);
            this.lblCodeSKU.Name = "lblCodeSKU";
            this.lblCodeSKU.Size = new System.Drawing.Size(106, 20);
            this.lblCodeSKU.TabIndex = 0;
            this.lblCodeSKU.Text = "Código SKU";
            // 
            // txtSKUCode
            // 
            this.txtSKUCode.BackColor = System.Drawing.Color.White;
            this.txtSKUCode.Location = new System.Drawing.Point(226, 37);
            this.txtSKUCode.Name = "txtSKUCode";
            this.txtSKUCode.Size = new System.Drawing.Size(160, 26);
            this.txtSKUCode.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(644, 591);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(27, 115);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(103, 20);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Descripción";
            // 
            // lblDescriptionCare
            // 
            this.lblDescriptionCare.AutoSize = true;
            this.lblDescriptionCare.Location = new System.Drawing.Point(28, 252);
            this.lblDescriptionCare.Name = "lblDescriptionCare";
            this.lblDescriptionCare.Size = new System.Drawing.Size(200, 20);
            this.lblDescriptionCare.TabIndex = 4;
            this.lblDescriptionCare.Text = "Descripción del cuidado";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(422, 35);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(148, 20);
            this.lblPurchasePrice.TabIndex = 5;
            this.lblPurchasePrice.Text = "Precio de compra";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(28, 32);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(133, 20);
            this.lblSalePrice.TabIndex = 6;
            this.lblSalePrice.Text = "Precio de venta";
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.Location = new System.Drawing.Point(422, 74);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(41, 20);
            this.lblIGV.TabIndex = 7;
            this.lblIGV.Text = "IGV";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(28, 117);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(55, 20);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(32, 357);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(66, 20);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "Estado";
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Location = new System.Drawing.Point(446, 83);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(66, 20);
            this.lblFamilia.TabIndex = 12;
            this.lblFamilia.Text = "Familia";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(446, 43);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(58, 20);
            this.lblBrand.TabIndex = 13;
            this.lblBrand.Text = "Marca";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(27, 77);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(96, 20);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "Descuento";
            // 
            // gbGeneralInformation
            // 
            this.gbGeneralInformation.BackColor = System.Drawing.Color.White;
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
            this.gbGeneralInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGeneralInformation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbGeneralInformation.Location = new System.Drawing.Point(24, 23);
            this.gbGeneralInformation.Name = "gbGeneralInformation";
            this.gbGeneralInformation.Size = new System.Drawing.Size(760, 392);
            this.gbGeneralInformation.TabIndex = 15;
            this.gbGeneralInformation.TabStop = false;
            this.gbGeneralInformation.Text = "Datos generales";
            this.gbGeneralInformation.Enter += new System.EventHandler(this.gbGeneralInformation_Enter);
            // 
            // cboFamily
            // 
            this.cboFamily.FormattingEnabled = true;
            this.cboFamily.Location = new System.Drawing.Point(510, 78);
            this.cboFamily.Name = "cboFamily";
            this.cboFamily.Size = new System.Drawing.Size(228, 28);
            this.cboFamily.TabIndex = 23;
            this.cboFamily.Text = "--Seleccione--";
            // 
            // cboBrand
            // 
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(510, 38);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(228, 28);
            this.cboBrand.TabIndex = 22;
            this.cboBrand.Text = "--Seleccione--";
            // 
            // txtCareDescription
            // 
            this.txtCareDescription.Location = new System.Drawing.Point(226, 249);
            this.txtCareDescription.Multiline = true;
            this.txtCareDescription.Name = "txtCareDescription";
            this.txtCareDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCareDescription.Size = new System.Drawing.Size(511, 82);
            this.txtCareDescription.TabIndex = 20;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(226, 118);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(511, 107);
            this.txtDescription.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(226, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 26);
            this.txtName.TabIndex = 18;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 20);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Nombre";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Enabled = false;
            this.cbActive.Location = new System.Drawing.Point(226, 357);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(84, 24);
            this.cbActive.TabIndex = 16;
            this.cbActive.Text = "Activo";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // gbTransactionInformation
            // 
            this.gbTransactionInformation.BackColor = System.Drawing.Color.White;
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
            this.gbTransactionInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTransactionInformation.Location = new System.Drawing.Point(24, 427);
            this.gbTransactionInformation.Name = "gbTransactionInformation";
            this.gbTransactionInformation.Size = new System.Drawing.Size(760, 157);
            this.gbTransactionInformation.TabIndex = 16;
            this.gbTransactionInformation.TabStop = false;
            this.gbTransactionInformation.Text = "Datos de Transacciones";
            // 
            // cboDiscount
            // 
            this.cboDiscount.FormattingEnabled = true;
            this.cboDiscount.Location = new System.Drawing.Point(226, 72);
            this.cboDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDiscount.Name = "cboDiscount";
            this.cboDiscount.Size = new System.Drawing.Size(160, 28);
            this.cboDiscount.TabIndex = 29;
            this.cboDiscount.Text = "--Seleccione--";
            // 
            // txtIGV
            // 
            this.txtIGV.Location = new System.Drawing.Point(578, 71);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(160, 26);
            this.txtIGV.TabIndex = 27;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(226, 112);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(160, 26);
            this.txtStock.TabIndex = 26;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(578, 29);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(160, 26);
            this.txtPurchasePrice.TabIndex = 25;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(226, 32);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(160, 26);
            this.txtSalePrice.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::View.Properties.Resources.guardar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = global::View.Properties.Resources.guardar;
            this.pictureBox1.Location = new System.Drawing.Point(744, 591);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(810, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbTransactionInformation);
            this.Controls.Add(this.gbGeneralInformation);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddProductForm";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.gbGeneralInformation.ResumeLayout(false);
            this.gbGeneralInformation.PerformLayout();
            this.gbTransactionInformation.ResumeLayout(false);
            this.gbTransactionInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}