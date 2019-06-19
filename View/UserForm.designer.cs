namespace User
{
    partial class UserForm
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
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.bntModifyUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUserColumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvUserColumId,
            this.dgvColumUserName,
            this.dgvColumCreationDate});
            this.dgvUser.Location = new System.Drawing.Point(52, 132);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(353, 253);
            this.dgvUser.TabIndex = 7;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(329, 83);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(76, 23);
            this.btnDeleteUser.TabIndex = 6;
            this.btnDeleteUser.Text = "Eliminar";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // bntModifyUser
            // 
            this.bntModifyUser.Location = new System.Drawing.Point(189, 83);
            this.bntModifyUser.Name = "bntModifyUser";
            this.bntModifyUser.Size = new System.Drawing.Size(102, 23);
            this.bntModifyUser.TabIndex = 5;
            this.bntModifyUser.Text = "Modificar Usuario";
            this.bntModifyUser.UseVisualStyleBackColor = true;
            this.bntModifyUser.Click += new System.EventHandler(this.bntModifyUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(52, 83);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 23);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Agregar Usuario";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(124, 31);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(234, 20);
            this.txtProduct.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(388, 28);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 24);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código de Usuario:";
            // 
            // dgvUserColumId
            // 
            this.dgvUserColumId.Frozen = true;
            this.dgvUserColumId.HeaderText = "Cód.";
            this.dgvUserColumId.Name = "dgvUserColumId";
            this.dgvUserColumId.ReadOnly = true;
            this.dgvUserColumId.Width = 60;
            // 
            // dgvColumUserName
            // 
            this.dgvColumUserName.Frozen = true;
            this.dgvColumUserName.HeaderText = "Usuario";
            this.dgvColumUserName.Name = "dgvColumUserName";
            this.dgvColumUserName.ReadOnly = true;
            this.dgvColumUserName.Width = 150;
            // 
            // dgvColumCreationDate
            // 
            this.dgvColumCreationDate.Frozen = true;
            this.dgvColumCreationDate.HeaderText = "Fecha de Expiración";
            this.dgvColumCreationDate.Name = "dgvColumCreationDate";
            this.dgvColumCreationDate.ReadOnly = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.bntModifyUser);
            this.Controls.Add(this.btnAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button bntModifyUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserColumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumCreationDate;
    }
}

