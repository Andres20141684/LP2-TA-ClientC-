namespace entregable
{
    partial class ModifyEmployeeForm
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
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEmployeeEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEmployeeStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.lblState = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEmployeeBorn = new System.Windows.Forms.DateTimePicker();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeSecondLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmployeeFirstLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.BackColor = System.Drawing.Color.White;
            this.btnSaveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEmployee.Location = new System.Drawing.Point(690, 589);
            this.btnSaveEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(94, 35);
            this.btnSaveEmployee.TabIndex = 22;
            this.btnSaveEmployee.Text = "Guardar";
            this.btnSaveEmployee.UseVisualStyleBackColor = false;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dtpEmployeeEndDate);
            this.groupBox1.Controls.Add(this.dtpEmployeeStartDate);
            this.groupBox1.Controls.Add(this.cbActive);
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbRole);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbArea);
            this.groupBox1.Controls.Add(this.txtEmployeeName);
            this.groupBox1.Controls.Add(this.txtEmployeeDNI);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpEmployeeBorn);
            this.groupBox1.Controls.Add(this.txtEmployeeEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmployeePhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmployeeSecondLastName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmployeeFirstLastName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(760, 556);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // dtpEmployeeEndDate
            // 
            this.dtpEmployeeEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmployeeEndDate.Location = new System.Drawing.Point(277, 363);
            this.dtpEmployeeEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEmployeeEndDate.Name = "dtpEmployeeEndDate";
            this.dtpEmployeeEndDate.Size = new System.Drawing.Size(464, 26);
            this.dtpEmployeeEndDate.TabIndex = 28;
            // 
            // dtpEmployeeStartDate
            // 
            this.dtpEmployeeStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmployeeStartDate.Location = new System.Drawing.Point(277, 313);
            this.dtpEmployeeStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEmployeeStartDate.Name = "dtpEmployeeStartDate";
            this.dtpEmployeeStartDate.Size = new System.Drawing.Size(464, 26);
            this.dtpEmployeeStartDate.TabIndex = 27;
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActive.Location = new System.Drawing.Point(277, 519);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(78, 24);
            this.cbActive.TabIndex = 23;
            this.cbActive.Text = "Activo";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(30, 523);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(66, 20);
            this.lblState.TabIndex = 24;
            this.lblState.Text = "Estado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 369);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Fecha de fin de contrato";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 322);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Fecha de inicio de contrato";
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(277, 460);
            this.cbRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(464, 28);
            this.cbRole.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 422);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Área";
            // 
            // cbArea
            // 
            this.cbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(277, 414);
            this.cbArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(464, 28);
            this.cbArea.TabIndex = 20;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(277, 65);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(464, 26);
            this.txtEmployeeName.TabIndex = 10;
            // 
            // txtEmployeeDNI
            // 
            this.txtEmployeeDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeDNI.Location = new System.Drawing.Point(277, 23);
            this.txtEmployeeDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmployeeDNI.Name = "txtEmployeeDNI";
            this.txtEmployeeDNI.Size = new System.Drawing.Size(464, 26);
            this.txtEmployeeDNI.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno";
            // 
            // dtpEmployeeBorn
            // 
            this.dtpEmployeeBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmployeeBorn.Location = new System.Drawing.Point(277, 267);
            this.dtpEmployeeBorn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEmployeeBorn.Name = "dtpEmployeeBorn";
            this.dtpEmployeeBorn.Size = new System.Drawing.Size(464, 26);
            this.dtpEmployeeBorn.TabIndex = 16;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeEmail.Location = new System.Drawing.Point(277, 227);
            this.txtEmployeeEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(464, 26);
            this.txtEmployeeEmail.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePhone.Location = new System.Drawing.Point(277, 189);
            this.txtEmployeePhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(464, 26);
            this.txtEmployeePhone.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo";
            // 
            // txtEmployeeSecondLastName
            // 
            this.txtEmployeeSecondLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSecondLastName.Location = new System.Drawing.Point(277, 149);
            this.txtEmployeeSecondLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmployeeSecondLastName.Name = "txtEmployeeSecondLastName";
            this.txtEmployeeSecondLastName.Size = new System.Drawing.Size(464, 26);
            this.txtEmployeeSecondLastName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 468);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cargo";
            // 
            // txtEmployeeFirstLastName
            // 
            this.txtEmployeeFirstLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeFirstLastName.Location = new System.Drawing.Point(277, 104);
            this.txtEmployeeFirstLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmployeeFirstLastName.Name = "txtEmployeeFirstLastName";
            this.txtEmployeeFirstLastName.Size = new System.Drawing.Size(464, 26);
            this.txtEmployeeFirstLastName.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 280);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha de nacimiento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::View.Properties.Resources.guardar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = global::View.Properties.Resources.guardar;
            this.pictureBox1.Location = new System.Drawing.Point(643, 589);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // ModifyEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(810, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ModifyEmployeeForm";
            this.Text = "Modificar Empleado";
            this.Load += new System.EventHandler(this.ModifyEmployeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpEmployeeEndDate;
        private System.Windows.Forms.DateTimePicker dtpEmployeeStartDate;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEmployeeBorn;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeSecondLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmployeeFirstLastName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}