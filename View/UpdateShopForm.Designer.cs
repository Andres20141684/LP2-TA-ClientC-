namespace View
{
    partial class UpdateShopForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.txtPremiseID = new System.Windows.Forms.TextBox();
            this.lblCodeSKU = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbGeneralInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGeneralInformation
            // 
            this.gbGeneralInformation.Controls.Add(this.label1);
            this.gbGeneralInformation.Controls.Add(this.txtDescription);
            this.gbGeneralInformation.Controls.Add(this.txtName);
            this.gbGeneralInformation.Controls.Add(this.lblName);
            this.gbGeneralInformation.Controls.Add(this.cbActive);
            this.gbGeneralInformation.Controls.Add(this.txtPremiseID);
            this.gbGeneralInformation.Controls.Add(this.lblCodeSKU);
            this.gbGeneralInformation.Controls.Add(this.lblState);
            this.gbGeneralInformation.Controls.Add(this.lblDescription);
            this.gbGeneralInformation.Location = new System.Drawing.Point(57, 44);
            this.gbGeneralInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGeneralInformation.Name = "gbGeneralInformation";
            this.gbGeneralInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGeneralInformation.Size = new System.Drawing.Size(676, 314);
            this.gbGeneralInformation.TabIndex = 19;
            this.gbGeneralInformation.TabStop = false;
            this.gbGeneralInformation.Text = "Datos generales";
            this.gbGeneralInformation.Enter += new System.EventHandler(this.gbGeneralInformation_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha de Creación";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(201, 95);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(451, 81);
            this.txtDescription.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(201, 60);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 22);
            this.txtName.TabIndex = 18;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 17);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Nombre";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(201, 218);
            this.cbActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(65, 21);
            this.cbActive.TabIndex = 16;
            this.cbActive.Text = "Activo";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // txtPremiseID
            // 
            this.txtPremiseID.Location = new System.Drawing.Point(201, 30);
            this.txtPremiseID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPremiseID.Name = "txtPremiseID";
            this.txtPremiseID.Size = new System.Drawing.Size(197, 22);
            this.txtPremiseID.TabIndex = 1;
            // 
            // lblCodeSKU
            // 
            this.lblCodeSKU.AutoSize = true;
            this.lblCodeSKU.Location = new System.Drawing.Point(25, 33);
            this.lblCodeSKU.Name = "lblCodeSKU";
            this.lblCodeSKU.Size = new System.Drawing.Size(72, 17);
            this.lblCodeSKU.TabIndex = 0;
            this.lblCodeSKU.Text = "PremiseID";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(31, 218);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(52, 17);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "Estado";
            this.lblState.Click += new System.EventHandler(this.lblState_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(24, 92);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 17);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Dirección";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(625, 362);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 28);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // UpdateShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 399);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbGeneralInformation);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateShopForm";
            this.Text = "Modificar Local";
            this.Load += new System.EventHandler(this.UpdateShopForm_Load);
            this.gbGeneralInformation.ResumeLayout(false);
            this.gbGeneralInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGeneralInformation;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.TextBox txtPremiseID;
        private System.Windows.Forms.Label lblCodeSKU;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}