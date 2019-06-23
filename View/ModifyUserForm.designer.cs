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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifySaveUser
            // 
            this.btnModifySaveUser.BackColor = System.Drawing.Color.White;
            this.btnModifySaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifySaveUser.Location = new System.Drawing.Point(690, 589);
            this.btnModifySaveUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifySaveUser.Name = "btnModifySaveUser";
            this.btnModifySaveUser.Size = new System.Drawing.Size(94, 35);
            this.btnModifySaveUser.TabIndex = 19;
            this.btnModifySaveUser.Text = "Guardar";
            this.btnModifySaveUser.UseVisualStyleBackColor = false;
            this.btnModifySaveUser.Click += new System.EventHandler(this.btnModifySaveUser_Click);
            // 
            // dtpModifyUserExpirationDate
            // 
            this.dtpModifyUserExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpModifyUserExpirationDate.Location = new System.Drawing.Point(210, 303);
            this.dtpModifyUserExpirationDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpModifyUserExpirationDate.Name = "dtpModifyUserExpirationDate";
            this.dtpModifyUserExpirationDate.Size = new System.Drawing.Size(533, 26);
            this.dtpModifyUserExpirationDate.TabIndex = 16;
            // 
            // txtModifyUserPassword
            // 
            this.txtModifyUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifyUserPassword.Location = new System.Drawing.Point(228, 53);
            this.txtModifyUserPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModifyUserPassword.Name = "txtModifyUserPassword";
            this.txtModifyUserPassword.Size = new System.Drawing.Size(533, 26);
            this.txtModifyUserPassword.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha de expiración";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dtpModifyUserExpirationDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(760, 558);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::View.Properties.Resources.guardar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = global::View.Properties.Resources.guardar;
            this.pictureBox1.Location = new System.Drawing.Point(643, 589);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // ModifyUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(810, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnModifySaveUser);
            this.Controls.Add(this.txtModifyUserPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ModifyUserForm";
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.ModifyUserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifySaveUser;
        private System.Windows.Forms.DateTimePicker dtpModifyUserExpirationDate;
        private System.Windows.Forms.TextBox txtModifyUserPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}