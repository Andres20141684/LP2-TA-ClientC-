namespace ShopsForm
{
    partial class ShopForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddLocal = new System.Windows.Forms.Button();
            this.btnModLocal = new System.Windows.Forms.Button();
            this.btnDelLocal = new System.Windows.Forms.Button();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.dgvColCodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código del Local:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnAddLocal
            // 
            this.btnAddLocal.Location = new System.Drawing.Point(46, 115);
            this.btnAddLocal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLocal.Name = "btnAddLocal";
            this.btnAddLocal.Size = new System.Drawing.Size(91, 26);
            this.btnAddLocal.TabIndex = 2;
            this.btnAddLocal.Text = "Agregar Local";
            this.btnAddLocal.UseVisualStyleBackColor = true;
            this.btnAddLocal.Click += new System.EventHandler(this.btnAddLocal_Click);
            // 
            // btnModLocal
            // 
            this.btnModLocal.Location = new System.Drawing.Point(235, 115);
            this.btnModLocal.Margin = new System.Windows.Forms.Padding(2);
            this.btnModLocal.Name = "btnModLocal";
            this.btnModLocal.Size = new System.Drawing.Size(98, 25);
            this.btnModLocal.TabIndex = 3;
            this.btnModLocal.Text = "Modificar Local";
            this.btnModLocal.UseVisualStyleBackColor = true;
            this.btnModLocal.Click += new System.EventHandler(this.btnModLocal_Click);
            // 
            // btnDelLocal
            // 
            this.btnDelLocal.Location = new System.Drawing.Point(429, 116);
            this.btnDelLocal.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelLocal.Name = "btnDelLocal";
            this.btnDelLocal.Size = new System.Drawing.Size(85, 24);
            this.btnDelLocal.TabIndex = 4;
            this.btnDelLocal.Text = "Eliminar";
            this.btnDelLocal.UseVisualStyleBackColor = true;
            this.btnDelLocal.Click += new System.EventHandler(this.btnDelLocal_Click);
            // 
            // dgvLocal
            // 
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColCodi,
            this.dgvColDesc,
            this.dgvColFecha,
            this.dgvColAdress});
            this.dgvLocal.Location = new System.Drawing.Point(29, 174);
            this.dgvLocal.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.RowTemplate.Height = 24;
            this.dgvLocal.Size = new System.Drawing.Size(521, 177);
            this.dgvLocal.TabIndex = 5;
            // 
            // dgvColCodi
            // 
            this.dgvColCodi.HeaderText = "Codigo";
            this.dgvColCodi.Name = "dgvColCodi";
            // 
            // dgvColDesc
            // 
            this.dgvColDesc.HeaderText = "Descripcion";
            this.dgvColDesc.Name = "dgvColDesc";
            // 
            // dgvColFecha
            // 
            this.dgvColFecha.HeaderText = "Fecha de Creacion";
            this.dgvColFecha.Name = "dgvColFecha";
            // 
            // dgvColAdress
            // 
            this.dgvColAdress.HeaderText = "Direccion";
            this.dgvColAdress.Name = "dgvColAdress";
            this.dgvColAdress.Width = 200;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(384, 43);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 21);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 362);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvLocal);
            this.Controls.Add(this.btnDelLocal);
            this.Controls.Add(this.btnModLocal);
            this.Controls.Add(this.btnAddLocal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ShopForm";
            this.Text = "Locales";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddLocal;
        private System.Windows.Forms.Button btnModLocal;
        private System.Windows.Forms.Button btnDelLocal;
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColAdress;
        private System.Windows.Forms.Button btnSearch;
    }
}

