namespace View
{
    partial class AuthenticationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationForm));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbIconPassword = new System.Windows.Forms.PictureBox();
            this.pbIconMate = new System.Windows.Forms.PictureBox();
            this.pbIconUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconMate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(125, 184);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(381, 26);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "gerente";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(125, 249);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(381, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "gerente";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOK.FlatAppearance.BorderSize = 3;
            this.btnOK.Location = new System.Drawing.Point(220, 303);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(177, 35);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Ingresar";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.Location = new System.Drawing.Point(220, 348);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbIconPassword
            // 
            this.pbIconPassword.BackgroundImage = global::View.Properties.Resources.password;
            this.pbIconPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIconPassword.Location = new System.Drawing.Point(63, 239);
            this.pbIconPassword.Name = "pbIconPassword";
            this.pbIconPassword.Size = new System.Drawing.Size(44, 36);
            this.pbIconPassword.TabIndex = 5;
            this.pbIconPassword.TabStop = false;
            // 
            // pbIconMate
            // 
            this.pbIconMate.BackColor = System.Drawing.Color.White;
            this.pbIconMate.BackgroundImage = global::View.Properties.Resources.mate_logo_smaller1;
            this.pbIconMate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIconMate.Location = new System.Drawing.Point(225, 12);
            this.pbIconMate.Name = "pbIconMate";
            this.pbIconMate.Size = new System.Drawing.Size(172, 140);
            this.pbIconMate.TabIndex = 7;
            this.pbIconMate.TabStop = false;
            // 
            // pbIconUser
            // 
            this.pbIconUser.BackgroundImage = global::View.Properties.Resources.user;
            this.pbIconUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIconUser.Location = new System.Drawing.Point(63, 174);
            this.pbIconUser.Name = "pbIconUser";
            this.pbIconUser.Size = new System.Drawing.Size(44, 36);
            this.pbIconUser.TabIndex = 4;
            this.pbIconUser.TabStop = false;
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(611, 405);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pbIconPassword);
            this.Controls.Add(this.pbIconMate);
            this.Controls.Add(this.pbIconUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AuthenticationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pbIconPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconMate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbIconMate;
        private System.Windows.Forms.PictureBox pbIconPassword;
        private System.Windows.Forms.PictureBox pbIconUser;
    }
}