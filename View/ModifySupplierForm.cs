using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.MateWSLocal;
namespace WindowsFormsApp1
{
    public partial class ModifySupplierForm : Form
    {
        SupplierForm refParent;
        private DBControllerWSClient serviceDA;
        public supplier currentSupplier;

        public ModifySupplierForm()
        {
            InitializeComponent();
            //cbActive.Checked = true;
        }

        public void SetParent(SupplierForm form)
        {
            refParent = form;
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
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else { 
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
        }
        private bool filledValues()
        {
            if (  txtRuc.Text.Length != 11)
            {
                MessageBox.Show("Ingrese un RUC válido");
                return false;
            }
            if (txtRuc.Text.Length == 11)
            {
                int result = 0;
                if (!Regex.Match(txtRuc.Text, @"([0-9]{3,})").Success)
                {
                    MessageBox.Show("Ha ingresado caracteres no numericos en el campo RUC, ingrese 11 caracteres numericos");
                    return false;
                }
            }
            if (txtNombre.Text == "" || txtNombre.Text.Length < 2)
            {
                MessageBox.Show("Ingrese un nombre válido");
                return false;
            }
            if (txtDireccion.Text == "" || txtDireccion.Text.Length < 10)
            {
                MessageBox.Show("Ingrese una dirección válida");
                return false;
            }
            if (txtCuenta.Text == "" || txtCuenta.Text.Length != 16)
            {
                MessageBox.Show("Ingrese un número de cuenta válido de 16 caracteres");
                return false;
            }
            if (txtTelefono.Text == "" || txtTelefono.Text.Length < 6)
            {
                MessageBox.Show("Ingrese un numero de telefono válido mayor a 6 caracteres");
                return false;
            }
            if (txtTelefono.Text.Length >= 6)
            {
                int result = 0;
                if (!Regex.Match(txtRuc.Text, @"([0-9]{3,})").Success)
                {
                    MessageBox.Show("Ingrese un numero de telefono con solo caracteres númericos");
                    return false;
                }
            }
            if (txtEmail.Text == "" || !txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Ingrese un email válido");
                return false;
            }
            if (txtPersonaContacto.Text == "")
            {
                MessageBox.Show("Complete la persona contacto del proveedor");
                return false;
            }
            if (txtCodProv.Text == "")
            {
                MessageBox.Show("Complete el código del proveedor");
                return false;
            }
            if (txtTerminoVenta.Text == "")
            {
                MessageBox.Show("Complete el término de venta del proveedor");
                return false;
            }
            return true;

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
