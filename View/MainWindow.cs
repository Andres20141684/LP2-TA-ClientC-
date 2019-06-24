using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace View
{
    public partial class MainWindow : Form
    {
        public MateWSLocal.user currentUser;
        public MainWindow()
        {
            InitializeComponent();
            
            //Height = Screen.PrimaryScreen.Bounds.Height;
            //Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.Show();
            
        }

        public void darPermiso(Permiso permiso)
        {
            switch (permiso)
            {
                case Permiso.Gerente:
                    comprasToolStripMenuItem.Enabled = true;
                    ventasToolStripMenuItem.Enabled = true;
                    gestiondeinformacionToolStripMenuItem.Enabled = true;
                    break;
                case Permiso.Supervisor:
                    comprasToolStripMenuItem.Enabled = true;
                    ventasToolStripMenuItem.Enabled = true;
                    gestiondeinformacionToolStripMenuItem.Enabled = true;
                    reportesToolStripMenuItem.Enabled = false;
                    break;
                case Permiso.Vendedor:
                    comprasToolStripMenuItem.Enabled = false;
                    ventasToolStripMenuItem.Enabled = true;
                    gestiondeinformacionToolStripMenuItem.Enabled = false;
                    break;
              
            }
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load_1(object sender, EventArgs e)
        {
            lblNameUser.Text = currentUser.user1;
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entregable.EmployeeForm empForm = new entregable.EmployeeForm();
            empForm.SetParent(this);
            empForm.MdiParent = this;
            empForm.Show();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.UserForm userForm = new User.UserForm();
            userForm.SetParent(this);
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void ProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Producto.FrmProduct productForm = new Producto.FrmProduct();
            productForm.SetParent(this);
            productForm.MdiParent = this;
            //productForm.ShowDialog();
            productForm.Show();

        }

        private void FamiliaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto.FamilyProductForm famProdForm = new Producto.FamilyProductForm();
            famProdForm.SetParent(this);
            famProdForm.MdiParent = this;
            famProdForm.Show();


        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.ReportsForm repForm = new WindowsFormsApp1.ReportsForm();
            repForm.SetParent(this);
            repForm.MdiParent = this;
            repForm.Show();


        }

        private void ProovedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.SupplierForm supplierForm = new WindowsFormsApp1.SupplierForm();
            supplierForm.SetParent(this);
            supplierForm.MdiParent = this;
            supplierForm.Show();
        }

        private void VentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleForm saleForm = new SaleForm();
            saleForm.currentUser = currentUser;
            saleForm.Show();
        }

        private void LocalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopsForm.ShopForm shopForm = new ShopsForm.ShopForm();
            shopForm.MdiParent = this;
            shopForm.SetParent(this);
            shopForm.Show();

        }
        public enum Permiso
        {
            Gerente, Supervisor, Vendedor
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesClient.ClientesForms clientForm = new SalesClient.ClientesForms();
            clientForm.SetParent(this);
            clientForm.MdiParent = this;
            //clientForm.ShowDialog();
            clientForm.BringToFront();
            clientForm.Show();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //AuthenticationForm login = new AuthenticationForm();
            //login.ShowDialog();
         
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void lbTesto_Click(object sender, EventArgs e)
        {

        }

        private void lblNameUser_Click(object sender, EventArgs e)
        {

        }

        
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
}
