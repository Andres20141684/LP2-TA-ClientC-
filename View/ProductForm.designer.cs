namespace Producto
{
    partial class FrmProduct
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.clmSKUCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSKUCode,
            this.clmName,
            this.clmBrand,
            this.clmFamily,
            this.clmStock,
            this.clmAvailability});
            this.dgvProducts.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvProducts.Location = new System.Drawing.Point(44, 210);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(944, 389);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // clmSKUCode
            // 
            this.clmSKUCode.HeaderText = "SKU Código";
            this.clmSKUCode.Name = "clmSKUCode";
            this.clmSKUCode.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Nombre";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 150;
            // 
            // clmBrand
            // 
            this.clmBrand.HeaderText = "Marca";
            this.clmBrand.Name = "clmBrand";
            this.clmBrand.ReadOnly = true;
            this.clmBrand.Width = 150;
            // 
            // clmFamily
            // 
            this.clmFamily.HeaderText = "Familia";
            this.clmFamily.Name = "clmFamily";
            this.clmFamily.ReadOnly = true;
            this.clmFamily.Width = 150;
            // 
            // clmStock
            // 
            this.clmStock.HeaderText = "Stock";
            this.clmStock.Name = "clmStock";
            this.clmStock.ReadOnly = true;
            // 
            // clmAvailability
            // 
            this.clmAvailability.HeaderText = "Habilitado";
            this.clmAvailability.Name = "clmAvailability";
            this.clmAvailability.ReadOnly = true;
            this.clmAvailability.Width = 80;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(213, 62);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(349, 26);
            this.txtProduct.TabIndex = 2;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnUpdateProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(873, 178);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(115, 31);
            this.btnUpdateProduct.TabIndex = 4;
            this.btnUpdateProduct.Text = "Modificar ";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código de Producto:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.PaleTurquoise;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.username.Location = new System.Drawing.Point(887, -1);
            this.username.Name = "username";
            this.username.Padding = new System.Windows.Forms.Padding(6);
            this.username.Size = new System.Drawing.Size(160, 34);
            this.username.TabIndex = 7;
            this.username.Text = "Nombre de Usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::View.Properties.Resources.icono;
            this.pictureBox2.Location = new System.Drawing.Point(837, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddProduct.Location = new System.Drawing.Point(744, 178);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(130, 31);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Agregar";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::View.Properties.Resources.icono_buscar;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSearch.Image = global::View.Properties.Resources.icono_buscar;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(581, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 639);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmProduct";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSKUCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvailability;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

