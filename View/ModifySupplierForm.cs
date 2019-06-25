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
    public partial class ModifySupplierForm : Form
    {
        private DBControllerWSClient serviceDA;
        public supplier currentSupplier;
        public ModifySupplierForm()
        {
            InitializeComponent();
            //cbActive.Checked = true;
        }
      

        private void setSupplierInformation()
        {
            txtRuc.Text = currentSupplier.RUC;
            txtNombre.Text = currentSupplier.name;
            txtDireccion.Text = currentSupplier.address;
            txtCuenta.Text = currentSupplier.bankData;
            txtTelefono.Text = currentSupplier.contactPhone;
            txtEmail.Text = currentSupplier.contactEmail;
            txtPersonaContacto.Text = currentSupplier.contactPerson;
            txtCodProv.Text = currentSupplier.supplierCode;
            txtTerminoVenta.Text = currentSupplier.termOfSale;
            if (currentSupplier.state ==1)
            {
                cbActive.Checked = true;
            }else
            {
                cbActive.Checked = false;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            
            serviceDA = new DBControllerWSClient();
            currentSupplier.RUC = txtRuc.Text;
            currentSupplier.name = txtNombre.Text;
            currentSupplier.address = txtDireccion.Text;
            currentSupplier.bankData = txtCuenta.Text;
            currentSupplier.contactPhone = txtTelefono.Text;
            currentSupplier.contactEmail = txtEmail.Text;
            currentSupplier.contactPerson = txtPersonaContacto.Text;
            currentSupplier.supplierCode = txtCodProv.Text;
            currentSupplier.termOfSale = txtTerminoVenta.Text;
            currentSupplier.state = cbActive.Checked ? 1 : 0;

            serviceDA.updateSupplier(currentSupplier);
            MessageBox.Show("El proveedor se modificó satisfactoriamente");
            this.Close();
        }

        private void ModifySupplierForm_Shown(object sender, EventArgs e)
        {
            setSupplierInformation();
        }

        private void TxtTerminoVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
