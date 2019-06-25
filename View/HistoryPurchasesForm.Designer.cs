namespace View
{
    partial class HistoryPurchasesForm
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
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.dgvColumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumFistLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumSecondLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.BackgroundImage = global::View.Properties.Resources.icono_buscar;
            this.btnSearchEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchEmployee.Location = new System.Drawing.Point(392, 26);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(32, 26);
            this.btnSearchEmployee.TabIndex = 19;
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // txtRUC
            // 
            this.txtRUC.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtRUC.Location = new System.Drawing.Point(146, 28);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(234, 20);
            this.txtRUC.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "RUC:";
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumId,
            this.dgvColumName,
            this.dgvColumFistLastName,
            this.dgvColumSecondLastName,
            this.dgvColumPhone,
            this.dgvColumEmail,
            this.Column1});
            this.dgvSupplier.Location = new System.Drawing.Point(12, 81);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.Size = new System.Drawing.Size(629, 258);
            this.dgvSupplier.TabIndex = 16;
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
            // HistoryPurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 356);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSupplier);
            this.Name = "HistoryPurchasesForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumFistLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumSecondLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}