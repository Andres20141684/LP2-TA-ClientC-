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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código del Local:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnAddLocal
            // 
            this.btnAddLocal.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLocal.Location = new System.Drawing.Point(767, 178);
            this.btnAddLocal.Name = "btnAddLocal";
            this.btnAddLocal.Size = new System.Drawing.Size(115, 31);
            this.btnAddLocal.TabIndex = 2;
            this.btnAddLocal.Text = "Agregar ";
            this.btnAddLocal.UseVisualStyleBackColor = false;
            this.btnAddLocal.Click += new System.EventHandler(this.btnAddLocal_Click);
            // 
            // btnModLocal
            // 
            this.btnModLocal.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnModLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModLocal.Location = new System.Drawing.Point(882, 178);
            this.btnModLocal.Name = "btnModLocal";
            this.btnModLocal.Size = new System.Drawing.Size(115, 31);
            this.btnModLocal.TabIndex = 3;
            this.btnModLocal.Text = "Modificar ";
            this.btnModLocal.UseVisualStyleBackColor = false;
            this.btnModLocal.Click += new System.EventHandler(this.btnModLocal_Click);
            // 
            // dgvLocal
            // 
            this.dgvLocal.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColCodi,
            this.dgvColDesc,
            this.dgvColFecha,
            this.dgvColAdress});
            this.dgvLocal.Location = new System.Drawing.Point(54, 212);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.RowTemplate.Height = 24;
            this.dgvLocal.Size = new System.Drawing.Size(944, 397);
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
            this.textBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox1.Location = new System.Drawing.Point(217, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 26);
            this.textBox1.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::View.Properties.Resources.icono_buscar;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(586, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 40);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 639);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvLocal);
            this.Controls.Add(this.btnModLocal);
            this.Controls.Add(this.btnAddLocal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColAdress;
        private System.Windows.Forms.Button btnSearch;
    }
}

