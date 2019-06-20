namespace Producto
{
    partial class AddFamilyForm
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
            this.gbGeneralInformation = new System.Windows.Forms.GroupBox();
            this.txtFamilyCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.lblFamilyCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbGeneralInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGeneralInformation
            // 
            this.gbGeneralInformation.Controls.Add(this.txtFamilyCode);
            this.gbGeneralInformation.Controls.Add(this.txtName);
            this.gbGeneralInformation.Controls.Add(this.txtDescription);
            this.gbGeneralInformation.Controls.Add(this.cbActive);
            this.gbGeneralInformation.Controls.Add(this.lblFamilyCode);
            this.gbGeneralInformation.Controls.Add(this.lblState);
            this.gbGeneralInformation.Controls.Add(this.lblDescription);
            this.gbGeneralInformation.Controls.Add(this.lblName);
            this.gbGeneralInformation.Location = new System.Drawing.Point(19, 17);
            this.gbGeneralInformation.Margin = new System.Windows.Forms.Padding(2);
            this.gbGeneralInformation.Name = "gbGeneralInformation";
            this.gbGeneralInformation.Padding = new System.Windows.Forms.Padding(2);
            this.gbGeneralInformation.Size = new System.Drawing.Size(249, 185);
            this.gbGeneralInformation.TabIndex = 0;
            this.gbGeneralInformation.TabStop = false;
            this.gbGeneralInformation.Text = "Datos generales";
            // 
            // txtFamilyCode
            // 
            this.txtFamilyCode.Location = new System.Drawing.Point(116, 26);
            this.txtFamilyCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtFamilyCode.Name = "txtFamilyCode";
            this.txtFamilyCode.Size = new System.Drawing.Size(108, 20);
            this.txtFamilyCode.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(108, 20);
            this.txtName.TabIndex = 23;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(116, 92);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(108, 53);
            this.txtDescription.TabIndex = 22;
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Enabled = false;
            this.cbActive.Location = new System.Drawing.Point(116, 160);
            this.cbActive.Margin = new System.Windows.Forms.Padding(2);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(56, 17);
            this.cbActive.TabIndex = 17;
            this.cbActive.Text = "Activo";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // lblFamilyCode
            // 
            this.lblFamilyCode.AutoSize = true;
            this.lblFamilyCode.Location = new System.Drawing.Point(19, 28);
            this.lblFamilyCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFamilyCode.Name = "lblFamilyCode";
            this.lblFamilyCode.Size = new System.Drawing.Size(43, 13);
            this.lblFamilyCode.TabIndex = 21;
            this.lblFamilyCode.Text = "Código:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(19, 161);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(43, 13);
            this.lblState.TabIndex = 20;
            this.lblState.Text = "Estado:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(19, 94);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Descripción:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 59);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Nombre:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(205, 213);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddFamilyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 248);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbGeneralInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddFamilyForm";
            this.Text = "Agregar Familia";
            this.gbGeneralInformation.ResumeLayout(false);
            this.gbGeneralInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGeneralInformation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblFamilyCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtFamilyCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
    }
}