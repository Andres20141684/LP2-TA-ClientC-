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
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            /*
            serviceDA = new DBControllerWSClient();
            currentCustomer.id = txtClienteID.Text;
            currentCustomer.descriptionCustomer = txtDesc.Text;
            currentCustomer.address = txtAddress.Text;
            currentCustomer.occupation = txtOccupation.Text;
            currentCustomer.email = txtEmail.Text;
            currentCustomer.phone = txtPhone.Text;
            currentCustomer.kindOfCustomer = cbTipoCliente.Text;
            currentCustomer.state = cbActive.Checked ? 1 : 0;

            serviceDA.updateCustomer(currentCustomer);
            MessageBox.Show("El proveedor se modificó satisfactoriamente");
            this.Close();*/
        }

        private void ModifySupplierForm_Shown(object sender, EventArgs e)
        {
            setSupplierInformation();
        }
    }
}
