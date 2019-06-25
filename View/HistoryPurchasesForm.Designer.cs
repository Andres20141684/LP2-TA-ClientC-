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
            this.txtSerialCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPurchases = new System.Windows.Forms.DataGridView();
            this.dgvColumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumFistLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumSecondLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSerialCode
            // 
            this.txtSerialCode.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtSerialCode.Location = new System.Drawing.Point(146, 28);
            this.txtSerialCode.MaxLength = 11;
            this.txtSerialCode.Name = "txtSerialCode";
            this.txtSerialCode.Size = new System.Drawing.Size(234, 20);
            this.txtSerialCode.TabIndex = 18;
            this.txtSerialCode.TextChanged += new System.EventHandler(this.txtRUC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código serial:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvPurchases
            // 
            this.dgvPurchases.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumId,
            this.dgvColumName,
            this.dgvColumFistLastName,
            this.dgvColumSecondLastName});
            this.dgvPurchases.Location = new System.Drawing.Point(12, 81);
            this.dgvPurchases.Name = "dgvPurchases";
            this.dgvPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchases.Size = new System.Drawing.Size(629, 258);
            this.dgvPurchases.TabIndex = 16;
            this.dgvPurchases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchases_CellContentClick);
            // 
            // dgvColumId
            // 
            this.dgvColumId.Frozen = true;
            this.dgvColumId.HeaderText = "Código serial";
            this.dgvColumId.Name = "dgvColumId";
            this.dgvColumId.ReadOnly = true;
            this.dgvColumId.Width = 80;
            // 
            // dgvColumName
            // 
            this.dgvColumName.Frozen = true;
            this.dgvColumName.HeaderText = "Total de compra";
            this.dgvColumName.Name = "dgvColumName";
            this.dgvColumName.ReadOnly = true;
            this.dgvColumName.Width = 170;
            // 
            // dgvColumFistLastName
            // 
            this.dgvColumFistLastName.Frozen = true;
            this.dgvColumFistLastName.HeaderText = "Proveedor";
            this.dgvColumFistLastName.Name = "dgvColumFistLastName";
            this.dgvColumFistLastName.ReadOnly = true;
            this.dgvColumFistLastName.Width = 180;
            // 
            // dgvColumSecondLastName
            // 
            this.dgvColumSecondLastName.Frozen = true;
            this.dgvColumSecondLastName.HeaderText = "Fecha de creación";
            this.dgvColumSecondLastName.Name = "dgvColumSecondLastName";
            this.dgvColumSecondLastName.ReadOnly = true;
            this.dgvColumSecondLastName.Width = 150;
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
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // HistoryPurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 356);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.txtSerialCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPurchases);
            this.Name = "HistoryPurchasesForm";
            this.Text = "Historial de compras";
            this.Load += new System.EventHandler(this.HistoryPurchasesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.TextBox txtSerialCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPurchases;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumFistLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumSecondLastName;
    }
}