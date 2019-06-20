using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.MateWSLocal;
namespace WindowsFormsApp1
{
    public partial class AddSupplierForm : Form
    {
        private DBControllerWSClient serviceDA;
        public AddSupplierForm()
        {
            InitializeComponent();
            cbActive.Checked = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                supplier s = new supplier();
                s.RUC = txtRuc.Text;
                s.name = txtNombre.Text;
                s.address = txtDireccion.Text;
                s.bankData = txtCuenta.Text;
                s.contactEmail = txtEmail.Text;
                s.contactPerson = txtPersonaContacto.Text;
                s.supplierCode = txtCodProv.Text;
                s.state = 1;
                serviceDA = new DBControllerWSClient();
                Cursor.Current = Cursors.WaitCursor;
                serviceDA.insertSupplier(s);
                Cursor.Current = Cursors.Arrow;
                MessageBox.Show("El proveedor se agregó satisfactoriamente");
                this.Close();
            }
        }


        private bool filledValues()
        {
            if (txtRuc.Text == "")
            {
                MessageBox.Show("Complete la RUC del proveedor");
                return false;
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("Complete el nombre del proveedor");
                return false;
            }
            else if (txtDireccion.Text == "")
            {
                MessageBox.Show("Complete la dirección del proveedor");
                return false;
            }
            else if (txtCuenta.Text == "")
            {
                MessageBox.Show("Complete la cuenta bancaria del proveedor");
                return false;
            }
            else if (txtTelefono.Text == "")
            {
                MessageBox.Show("Complete el telefono del proveedor");
                return false;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Complete el email del proveedor");
                return false;
            }
            else if (txtPersonaContacto.Text == "")
            {
                MessageBox.Show("Complete la persona contacto del proveedor");
                return false;
            }
            else if (txtCodProv.Text == "")
            {
                MessageBox.Show("Complete el código del proveedor");
                return false;
            }
            else if (txtTerminoVenta.Text == "")
            {
                MessageBox.Show("Complete el término de venta del proveedor");
                return false;
            }
            return true;

        }


        private void cbActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCuentaAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
