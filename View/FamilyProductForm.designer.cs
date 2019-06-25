namespace Producto
{
    partial class FamilyProductForm
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
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddFamily = new System.Windows.Forms.Button();
            this.btnUpdateFamily = new System.Windows.Forms.Button();
            this.dgvFamilies = new System.Windows.Forms.DataGridView();
            this.clmFamilyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilies)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFamily
            // 
            this.txtFamily.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtFamily.Location = new System.Drawing.Point(145, 38);
            this.txtFamily.Margin = new System.Windows.Forms.Padding(2);
            this.txtFamily.MaxLength = 5;
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(234, 20);
            this.txtFamily.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::View.Properties.Resources.icono_buscar;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(391, 36);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 26);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddFamily
            // 
            this.btnAddFamily.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFamily.Location = new System.Drawing.Point(511, 116);
            this.btnAddFamily.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFamily.Name = "btnAddFamily";
            this.btnAddFamily.Size = new System.Drawing.Size(77, 20);
            this.btnAddFamily.TabIndex = 5;
            this.btnAddFamily.Text = "Agregar ";
            this.btnAddFamily.UseVisualStyleBackColor = false;
            this.btnAddFamily.Click += new System.EventHandler(this.btnAddFamily_Click);
            // 
            // btnUpdateFamily
            // 
            this.btnUpdateFamily.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnUpdateFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFamily.Location = new System.Drawing.Point(588, 116);
            this.btnUpdateFamily.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateFamily.Name = "btnUpdateFamily";
            this.btnUpdateFamily.Size = new System.Drawing.Size(77, 20);
            this.btnUpdateFamily.TabIndex = 6;
            this.btnUpdateFamily.Text = "Modificar ";
            this.btnUpdateFamily.UseVisualStyleBackColor = false;
            this.btnUpdateFamily.Click += new System.EventHandler(this.btnUpdateFamily_Click);
            // 
            // dgvFamilies
            // 
            this.dgvFamilies.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dgvFamilies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFamilyCode,
            this.clmNameFamily,
            this.clmDescription});
            this.dgvFamilies.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvFamilies.Location = new System.Drawing.Point(36, 138);
            this.dgvFamilies.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFamilies.Name = "dgvFamilies";
            this.dgvFamilies.RowTemplate.Height = 28;
            this.dgvFamilies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFamilies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFamilies.Size = new System.Drawing.Size(629, 258);
            this.dgvFamilies.TabIndex = 8;
            this.dgvFamilies.DoubleClick += new System.EventHandler(this.doubleClickDgvFamilies);
            // 
            // clmFamilyCode
            // 
            this.clmFamilyCode.HeaderText = "Código";
            this.clmFamilyCode.Name = "clmFamilyCode";
            this.clmFamilyCode.Width = 200;
            // 
            // clmNameFamily
            // 
            this.clmNameFamily.HeaderText = "Nombre";
            this.clmNameFamily.Name = "clmNameFamily";
            this.clmNameFamily.Width = 200;
            // 
            // clmDescription
            // 
            this.clmDescription.HeaderText = "Descripción";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.Width = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código de Familia:";
            // 
            // FamilyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFamilies);
            this.Controls.Add(this.btnUpdateFamily);
            this.Controls.Add(this.btnAddFamily);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFamily);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "FamilyProductForm";
            this.Text = "Familias de producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddFamily;
        private System.Windows.Forms.Button btnUpdateFamily;
        private System.Windows.Forms.DataGridView dgvFamilies;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamilyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.Label label1;
    }
}