namespace View
{
    partial class HistorySaleForm
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
            this.dgvPurchases = new System.Windows.Forms.DataGridView();
            this.dgvColumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumFistLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumSecondLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.BackgroundImage = global::View.Properties.Resources.icono_buscar;
            this.btnSearchEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchEmployee.Location = new System.Drawing.Point(400, 22);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(32, 26);
            this.btnSearchEmployee.TabIndex = 23;
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // txtRUC
            // 
            this.txtRUC.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtRUC.Location = new System.Drawing.Point(154, 24);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(234, 20);
            this.txtRUC.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Código serial:";
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
            this.dgvPurchases.Location = new System.Drawing.Point(20, 77);
            this.dgvPurchases.Name = "dgvPurchases";
            this.dgvPurchases.Size = new System.Drawing.Size(629, 258);
            this.dgvPurchases.TabIndex = 20;
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
            this.dgvColumName.HeaderText = "Total de venta";
            this.dgvColumName.Name = "dgvColumName";
            this.dgvColumName.ReadOnly = true;
            this.dgvColumName.Width = 170;
            // 
            // dgvColumFistLastName
            // 
            this.dgvColumFistLastName.Frozen = true;
            this.dgvColumFistLastName.HeaderText = "Cliente";
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
            // HistorySaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 356);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPurchases);
            this.Name = "HistorySaleForm";
            this.Text = "Historial de ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPurchases;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumFistLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumSecondLastName;
    }
}