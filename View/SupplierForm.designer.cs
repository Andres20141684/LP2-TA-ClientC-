﻿namespace WindowsFormsApp1
{
    partial class SupplierForm
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
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.dgvColumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumFistLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumSecondLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifyEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(273, 27);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnSearchEmployee.TabIndex = 13;
            this.btnSearchEmployee.Text = "Buscar";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.BtnSearchEmployee_Click);
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(86, 29);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(140, 20);
            this.txtRUC.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "RUC:";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(751, 109);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteEmployee.TabIndex = 10;
            this.btnDeleteEmployee.Text = "Eliminar";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumId,
            this.dgvColumName,
            this.dgvColumFistLastName,
            this.dgvColumSecondLastName,
            this.dgvColumPhone,
            this.dgvColumEmail,
            this.Column1});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 162);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(903, 300);
            this.dgvEmployee.TabIndex = 9;
            // 
            // dgvColumId
            // 
            this.dgvColumId.Frozen = true;
            this.dgvColumId.HeaderText = "RUC";
            this.dgvColumId.Name = "dgvColumId";
            this.dgvColumId.ReadOnly = true;
            this.dgvColumId.Width = 80;
            // 
            // dgvColumName
            // 
            this.dgvColumName.Frozen = true;
            this.dgvColumName.HeaderText = "Nombre";
            this.dgvColumName.Name = "dgvColumName";
            this.dgvColumName.ReadOnly = true;
            this.dgvColumName.Width = 170;
            // 
            // dgvColumFistLastName
            // 
            this.dgvColumFistLastName.Frozen = true;
            this.dgvColumFistLastName.HeaderText = "Dirección";
            this.dgvColumFistLastName.Name = "dgvColumFistLastName";
            this.dgvColumFistLastName.ReadOnly = true;
            this.dgvColumFistLastName.Width = 180;
            // 
            // dgvColumSecondLastName
            // 
            this.dgvColumSecondLastName.Frozen = true;
            this.dgvColumSecondLastName.HeaderText = "Cuenta bancaria";
            this.dgvColumSecondLastName.Name = "dgvColumSecondLastName";
            this.dgvColumSecondLastName.ReadOnly = true;
            this.dgvColumSecondLastName.Width = 150;
            // 
            // dgvColumPhone
            // 
            this.dgvColumPhone.Frozen = true;
            this.dgvColumPhone.HeaderText = "Teléfono";
            this.dgvColumPhone.Name = "dgvColumPhone";
            this.dgvColumPhone.ReadOnly = true;
            this.dgvColumPhone.Width = 80;
            // 
            // dgvColumEmail
            // 
            this.dgvColumEmail.Frozen = true;
            this.dgvColumEmail.HeaderText = "Email";
            this.dgvColumEmail.Name = "dgvColumEmail";
            this.dgvColumEmail.ReadOnly = true;
            this.dgvColumEmail.Width = 150;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Estado";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.Location = new System.Drawing.Point(427, 109);
            this.btnModifyEmployee.Name = "btnModifyEmployee";
            this.btnModifyEmployee.Size = new System.Drawing.Size(140, 23);
            this.btnModifyEmployee.TabIndex = 8;
            this.btnModifyEmployee.Text = "Modificar Proveedor";
            this.btnModifyEmployee.UseVisualStyleBackColor = true;
            this.btnModifyEmployee.Click += new System.EventHandler(this.BtnModifyEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(127, 109);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(140, 23);
            this.btnAddEmployee.TabIndex = 7;
            this.btnAddEmployee.Text = "Agregar Proveedor";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 484);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnModifyEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SupplierForm";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnModifyEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumFistLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumSecondLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}