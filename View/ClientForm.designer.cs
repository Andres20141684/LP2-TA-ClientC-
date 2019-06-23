namespace SalesClient
{
    partial class ClientesForms
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
            this.textDniRuc = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.dgvColCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgColTypeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI / RUC";
            // 
            // textDniRuc
            // 
            this.textDniRuc.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textDniRuc.Location = new System.Drawing.Point(217, 58);
            this.textDniRuc.Name = "textDniRuc";
            this.textDniRuc.Size = new System.Drawing.Size(349, 26);
            this.textDniRuc.TabIndex = 1;
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(767, 178);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(115, 31);
            this.btnAddClient.TabIndex = 2;
            this.btnAddClient.Text = "Agregar Cliente";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.Location = new System.Drawing.Point(882, 178);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(115, 31);
            this.btnEditClient.TabIndex = 3;
            this.btnEditClient.Text = "Modificar Cliente";
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColCod,
            this.dgvColDesc,
            this.dgvColEmail,
            this.dgvColTel,
            this.dvgColTypeClient});
            this.dgvClients.Location = new System.Drawing.Point(54, 212);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(944, 397);
            this.dgvClients.TabIndex = 5;
            // 
            // dgvColCod
            // 
            this.dgvColCod.HeaderText = "Codigo";
            this.dgvColCod.Name = "dgvColCod";
            // 
            // dgvColDesc
            // 
            this.dgvColDesc.HeaderText = "Descripción";
            this.dgvColDesc.Name = "dgvColDesc";
            this.dgvColDesc.Width = 200;
            // 
            // dgvColEmail
            // 
            this.dgvColEmail.HeaderText = "Email";
            this.dgvColEmail.Name = "dgvColEmail";
            this.dgvColEmail.Width = 210;
            // 
            // dgvColTel
            // 
            this.dgvColTel.HeaderText = "Telefono";
            this.dgvColTel.Name = "dgvColTel";
            // 
            // dvgColTypeClient
            // 
            this.dvgColTypeClient.HeaderText = "Tipo de Cliente";
            this.dvgColTypeClient.Name = "dvgColTypeClient";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::View.Properties.Resources.icono_buscar;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(586, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 40);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ClientesForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 639);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.textDniRuc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClientesForms";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClientesForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDniRuc;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgColTypeClient;
    }
}

