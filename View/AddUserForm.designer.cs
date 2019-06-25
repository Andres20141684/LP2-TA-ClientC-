namespace User
{
    partial class AddUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.dtpUserExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.lblState = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.empGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureSearch = new System.Windows.Forms.PictureBox();
            this.cboEmpUserType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.userGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.empGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de expiración:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(135, 19);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(361, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.Location = new System.Drawing.Point(135, 45);
            this.txtUserPassword.MaxLength = 50;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(361, 20);
            this.txtUserPassword.TabIndex = 5;
            // 
            // dtpUserExpirationDate
            // 
            this.dtpUserExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUserExpirationDate.Location = new System.Drawing.Point(135, 100);
            this.dtpUserExpirationDate.MaxDate = new System.DateTime(2200, 1, 1, 0, 0, 0, 0);
            this.dtpUserExpirationDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpUserExpirationDate.Name = "dtpUserExpirationDate";
            this.dtpUserExpirationDate.Size = new System.Drawing.Size(361, 20);
            this.dtpUserExpirationDate.TabIndex = 7;
            this.dtpUserExpirationDate.Value = new System.DateTime(2019, 6, 24, 23, 59, 59, 0);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BackColor = System.Drawing.Color.White;
            this.btnSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUser.Location = new System.Drawing.Point(460, 294);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(63, 23);
            this.btnSaveUser.TabIndex = 9;
            this.btnSaveUser.Text = "Guardar";
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // userGroupBox
            // 
            this.userGroupBox.BackColor = System.Drawing.Color.White;
            this.userGroupBox.Controls.Add(this.txtPasswordConfirm);
            this.userGroupBox.Controls.Add(this.label5);
            this.userGroupBox.Controls.Add(this.cbActive);
            this.userGroupBox.Controls.Add(this.lblState);
            this.userGroupBox.Controls.Add(this.dtpUserExpirationDate);
            this.userGroupBox.Controls.Add(this.txtUserName);
            this.userGroupBox.Controls.Add(this.txtUserPassword);
            this.userGroupBox.Controls.Add(this.label1);
            this.userGroupBox.Controls.Add(this.label2);
            this.userGroupBox.Controls.Add(this.label3);
            this.userGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGroupBox.Location = new System.Drawing.Point(12, 122);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Size = new System.Drawing.Size(511, 166);
            this.userGroupBox.TabIndex = 10;
            this.userGroupBox.TabStop = false;
            this.userGroupBox.Text = "Datos generales";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirm.Location = new System.Drawing.Point(135, 71);
            this.txtPasswordConfirm.MaxLength = 50;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '*';
            this.txtPasswordConfirm.Size = new System.Drawing.Size(361, 20);
            this.txtPasswordConfirm.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Confirmar contraseña";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Enabled = false;
            this.cbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActive.Location = new System.Drawing.Point(135, 137);
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
            this.lblState.Location = new System.Drawing.Point(15, 138);
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
            this.pictureBox1.Location = new System.Drawing.Point(429, 294);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // empGroupBox
            // 
            this.empGroupBox.BackColor = System.Drawing.Color.White;
            this.empGroupBox.Controls.Add(this.pictureSearch);
            this.empGroupBox.Controls.Add(this.cboEmpUserType);
            this.empGroupBox.Controls.Add(this.label6);
            this.empGroupBox.Controls.Add(this.txtEmpName);
            this.empGroupBox.Controls.Add(this.label4);
            this.empGroupBox.Controls.Add(this.txtEmpDNI);
            this.empGroupBox.Controls.Add(this.label7);
            this.empGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empGroupBox.Location = new System.Drawing.Point(12, 12);
            this.empGroupBox.Name = "empGroupBox";
            this.empGroupBox.Size = new System.Drawing.Size(511, 104);
            this.empGroupBox.TabIndex = 108;
            this.empGroupBox.TabStop = false;
            this.empGroupBox.Text = "Empleado";
            // 
            // pictureSearch
            // 
            this.pictureSearch.BackgroundImage = global::View.Properties.Resources.icono_buscar;
            this.pictureSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureSearch.InitialImage = global::View.Properties.Resources.guardar;
            this.pictureSearch.Location = new System.Drawing.Point(458, 16);
            this.pictureSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pictureSearch.Name = "pictureSearch";
            this.pictureSearch.Size = new System.Drawing.Size(27, 23);
            this.pictureSearch.TabIndex = 108;
            this.pictureSearch.TabStop = false;
            this.pictureSearch.Click += new System.EventHandler(this.PictureSearch_Click);
            // 
            // cboEmpUserType
            // 
            this.cboEmpUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpUserType.Enabled = false;
            this.cboEmpUserType.FormattingEnabled = true;
            this.cboEmpUserType.Location = new System.Drawing.Point(135, 70);
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
            this.txtEmpName.Location = new System.Drawing.Point(135, 45);
            this.txtEmpName.MaxLength = 100;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(361, 20);
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
            this.txtEmpDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpDNI.Location = new System.Drawing.Point(135, 19);
            this.txtEmpDNI.MaxLength = 8;
            this.txtEmpDNI.Name = "txtEmpDNI";
            this.txtEmpDNI.Size = new System.Drawing.Size(309, 20);
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
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(540, 324);
            this.Controls.Add(this.empGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.userGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddUserForm";
            this.Text = "Agregar Usuario";
            this.userGroupBox.ResumeLayout(false);
            this.userGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.empGroupBox.ResumeLayout(false);
            this.empGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.DateTimePicker dtpUserExpirationDate;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.GroupBox userGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox empGroupBox;
        private System.Windows.Forms.ComboBox cboEmpUserType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureSearch;
    }
}