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
            this.dgvUserColumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntModifyUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvUserColumId,
            this.dgvColumUserName,
            this.dgvColumCreationDate});
            this.dgvUser.Location = new System.Drawing.Point(54, 212);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(944, 397);
            this.dgvUser.TabIndex = 7;
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
            // bntModifyUser
            // 
            this.bntModifyUser.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bntModifyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntModifyUser.Location = new System.Drawing.Point(882, 178);
            this.bntModifyUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntModifyUser.Name = "bntModifyUser";
            this.bntModifyUser.Size = new System.Drawing.Size(115, 31);
            this.bntModifyUser.TabIndex = 5;
            this.bntModifyUser.Text = "Modificar";
            this.bntModifyUser.UseVisualStyleBackColor = false;
            this.bntModifyUser.Click += new System.EventHandler(this.bntModifyUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(767, 178);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(115, 31);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Agregar ";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtProduct
            // 
            this.txtProduct.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtProduct.Location = new System.Drawing.Point(217, 58);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(349, 26);
            this.txtProduct.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::View.Properties.Resources.icono_buscar;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(586, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 40);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código de Usuario:";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 639);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.bntModifyUser);
            this.Controls.Add(this.btnAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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

