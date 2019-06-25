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
            if ( txtRuc.Text.Length!=11)
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
            if (txtNombre.Text == "" || txtNombre.Text.Length<2)
            {
                MessageBox.Show("Ingrese un nombre válido");
                return false;
            }
             if (txtDireccion.Text == "" || txtDireccion.Text.Length<10)
            {
                MessageBox.Show("Ingrese una dirección válida");
                return false;
            }
             if (txtCuenta.Text == "" || txtCuenta.Text.Length!=16)
            {
                MessageBox.Show("Ingrese un número de cuenta válido de 16 caracteres");
                return false;
            }
             if (txtTelefono.Text == "" || txtTelefono.Text.Length<6)
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
