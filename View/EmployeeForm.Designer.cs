namespace entregable
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnModifyEmployee = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.dgvColumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumFistLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumSecondLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(511, 109);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(77, 20);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Agregar Empleado";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnModifyEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyEmployee.Location = new System.Drawing.Point(587, 109);
            this.btnModifyEmployee.Name = "btnModifyEmployee";
            this.btnModifyEmployee.Size = new System.Drawing.Size(79, 20);
            this.btnModifyEmployee.TabIndex = 1;
            this.btnModifyEmployee.Text = "Modificar Empleado";
            this.btnModifyEmployee.UseVisualStyleBackColor = false;
            this.btnModifyEmployee.Click += new System.EventHandler(this.btnModifyEmployee_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumId,
            this.dgvColumName,
            this.dgvColumFistLastName,
            this.dgvColumSecondLastName,
            this.dgvColumPhone,
            this.dgvColumEmail,
            this.dgvColumRole});
            this.dgvEmployee.Location = new System.Drawing.Point(37, 131);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(629, 263);
            this.dgvEmployee.TabIndex = 2;
            // 
            // dgvColumId
            // 
            this.dgvColumId.Frozen = true;
            this.dgvColumId.HeaderText = "DNI";
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
            this.dgvColumName.Width = 150;
            // 
            // dgvColumFistLastName
            // 
            this.dgvColumFistLastName.Frozen = true;
            this.dgvColumFistLastName.HeaderText = "Ap. Paterno";
            this.dgvColumFistLastName.Name = "dgvColumFistLastName";
            this.dgvColumFistLastName.ReadOnly = true;
            this.dgvColumFistLastName.Width = 150;
            // 
            // dgvColumSecondLastName
            // 
            this.dgvColumSecondLastName.Frozen = true;
            this.dgvColumSecondLastName.HeaderText = "Ap. Materno";
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
            this.dgvColumEmail.HeaderText = "Correo";
            this.dgvColumEmail.Name = "dgvColumEmail";
            this.dgvColumEmail.ReadOnly = true;
            this.dgvColumEmail.Width = 150;
            // 
            // dgvColumRole
            // 
            this.dgvColumRole.Frozen = true;
            this.dgvColumRole.HeaderText = "Rol";
            this.dgvColumRole.Name = "dgvColumRole";
            this.dgvColumRole.ReadOnly = true;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(740, 123);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(140, 23);
            this.btnDeleteEmployee.TabIndex = 3;
            this.btnDeleteEmployee.Text = "Eliminar";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(145, 38);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(234, 20);
            this.txtDNI.TabIndex = 5;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.BackgroundImage = global::View.Properties.Resources.icono_buscar;
            this.btnSearchEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchEmployee.Location = new System.Drawing.Point(392, 35);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(37, 23);
            this.btnSearchEmployee.TabIndex = 6;
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 415);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnModifyEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnModifyEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumFistLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumSecondLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumRole;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnSearchEmployee;
    }
}

