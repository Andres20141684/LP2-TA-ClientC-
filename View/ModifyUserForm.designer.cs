namespace User
{
    partial class ModifyUserForm
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
            this.btnModifySaveUser = new System.Windows.Forms.Button();
            this.dtpModifyUserExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.txtModifyUserPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModifyConfirmPassword = new System.Windows.Forms.TextBox();
            this.modifyConfirmLabel = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.lblState = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.empGroupBox = new System.Windows.Forms.GroupBox();
            this.cboEmpUserType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.empGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifySaveUser
            // 
            this.btnModifySaveUser.BackColor = System.Drawing.Color.White;
            this.btnModifySaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifySaveUser.Location = new System.Drawing.Point(460, 383);
            this.btnModifySaveUser.Name = "btnModifySaveUser";
            this.btnModifySaveUser.Size = new System.Drawing.Size(63, 23);
            this.btnModifySaveUser.TabIndex = 19;
            this.btnModifySaveUser.Text = "Guardar";
            this.btnModifySaveUser.UseVisualStyleBackColor = false;
            this.btnModifySaveUser.Click += new System.EventHandler(this.btnModifySaveUser_Click);
            // 
            // dtpModifyUserExpirationDate
            // 
            this.dtpModifyUserExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpModifyUserExpirationDate.Location = new System.Drawing.Point(158, 102);
            this.dtpModifyUserExpirationDate.Name = "dtpModifyUserExpirationDate";
            this.dtpModifyUserExpirationDate.Size = new System.Drawing.Size(339, 20);
            this.dtpModifyUserExpirationDate.TabIndex = 7;
            // 
            // txtModifyUserPassword
            // 
            this.txtModifyUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifyUserPassword.Location = new System.Drawing.Point(158, 50);
            this.txtModifyUserPassword.MaxLength = 32;
            this.txtModifyUserPassword.Name = "txtModifyUserPassword";
            this.txtModifyUserPassword.PasswordChar = '*';
            this.txtModifyUserPassword.Size = new System.Drawing.Size(339, 20);
            this.txtModifyUserPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha de expiración";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtModifyConfirmPassword);
            this.groupBox1.Controls.Add(this.modifyConfirmLabel);
            this.groupBox1.Controls.Add(this.cbActive);
            this.groupBox1.Controls.Add(this.txtModifyUserPassword);
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.dtpModifyUserExpirationDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 209);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(158, 24);
            this.txtUserName.MaxLength = 32;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(339, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Usuario:";
            // 
            // txtModifyConfirmPassword
            // 
            this.txtModifyConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifyConfirmPassword.Location = new System.Drawing.Point(158, 76);
            this.txtModifyConfirmPassword.MaxLength = 32;
            this.txtModifyConfirmPassword.Name = "txtModifyConfirmPassword";
            this.txtModifyConfirmPassword.PasswordChar = '*';
            this.txtModifyConfirmPassword.Size = new System.Drawing.Size(339, 20);
            this.txtModifyConfirmPassword.TabIndex = 6;
            // 
            // modifyConfirmLabel
            // 
            this.modifyConfirmLabel.AutoSize = true;
            this.modifyConfirmLabel.BackColor = System.Drawing.Color.White;
            this.modifyConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyConfirmLabel.Location = new System.Drawing.Point(20, 79);
            this.modifyConfirmLabel.Name = "modifyConfirmLabel";
            this.modifyConfirmLabel.Size = new System.Drawing.Size(132, 13);
            this.modifyConfirmLabel.TabIndex = 27;
            this.modifyConfirmLabel.Text = "Confirmar Contraseña:";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Checked = true;
            this.cbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActive.Location = new System.Drawing.Point(158, 127);
            this.cbActive.Margin = new System.Windows.Forms.Padding(2);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(56, 17);
            this.cbActive.TabIndex = 18;
            this.cbActive.Text = "Activo";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(20, 133);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(46, 13);
            this.lblState.TabIndex = 17;
            this.lblState.Text = "Estado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::View.Properties.Resources.guardar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = global::View.Properties.Resources.guardar;
            this.pictureBox1.Location = new System.Drawing.Point(429, 383);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // empGroupBox
            // 
            this.empGroupBox.BackColor = System.Drawing.Color.White;
            this.empGroupBox.Controls.Add(this.cboEmpUserType);
            this.empGroupBox.Controls.Add(this.label6);
            this.empGroupBox.Controls.Add(this.txtEmpName);
            this.empGroupBox.Controls.Add(this.label4);
            this.empGroupBox.Controls.Add(this.txtEmpDNI);
            this.empGroupBox.Controls.Add(this.label7);
            this.empGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empGroupBox.Location = new System.Drawing.Point(16, 23);
            this.empGroupBox.Name = "empGroupBox";
            this.empGroupBox.Size = new System.Drawing.Size(507, 104);
            this.empGroupBox.TabIndex = 109;
            this.empGroupBox.TabStop = false;
            this.empGroupBox.Text = "Empleado";
            // 
            // cboEmpUserType
            // 
            this.cboEmpUserType.Enabled = false;
            this.cboEmpUserType.FormattingEnabled = true;
            this.cboEmpUserType.Items.AddRange(new object[] {
            "Vendedor",
            "Supervisor",
            "Gerente"});
            this.cboEmpUserType.Location = new System.Drawing.Point(157, 70);
            this.cboEmpUserType.Name = "cboEmpUserType";
            this.cboEmpUserType.Size = new System.Drawing.Size(121, 21);
            this.cboEmpUserType.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Permisos";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(157, 45);
            this.txtEmpName.MaxLength = 100;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(339, 20);
            this.txtEmpName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nombre";
            // 
            // txtEmpDNI
            // 
            this.txtEmpDNI.Enabled = false;
            this.txtEmpDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpDNI.Location = new System.Drawing.Point(157, 19);
            this.txtEmpDNI.MaxLength = 8;
            this.txtEmpDNI.Name = "txtEmpDNI";
            this.txtEmpDNI.Size = new System.Drawing.Size(339, 20);
            this.txtEmpDNI.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "DNI:";
            // 
            // ModifyUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(540, 421);
            this.Controls.Add(this.empGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnModifySaveUser);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModifyUserForm";
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.ModifyUserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.empGroupBox.ResumeLayout(false);
            this.empGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifySaveUser;
        private System.Windows.Forms.DateTimePicker dtpModifyUserExpirationDate;
        private System.Windows.Forms.TextBox txtModifyUserPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtModifyConfirmPassword;
        private System.Windows.Forms.Label modifyConfirmLabel;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox empGroupBox;
        private System.Windows.Forms.ComboBox cboEmpUserType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpDNI;
        private System.Windows.Forms.Label label7;
    }
}