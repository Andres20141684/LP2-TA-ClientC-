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

namespace SalesClient
{
    public partial class ModificarClienteForm : Form
    {
        private DBControllerWSClient serviceDA;
        public customer currentCustomer;
        ClientesForms refParent;
        public ModificarClienteForm()
        {
            InitializeComponent();
            cbActive.Checked = true;

        }

        public void SetParent(ClientesForms form)
        {
            refParent = form;
        }
        private void ModificarClienteForm_Shown(object sender, EventArgs e)
        {
            setCustomerInformation();
        }
        private void setCustomerInformation()
        {
            txtClienteID.Text = currentCustomer.id;
            txtDesc.Text = currentCustomer.descriptionCustomer;
            txtAddress.Text = currentCustomer.address;
            txtOccupation.Text = currentCustomer.occupation;
            txtPhone.Text = currentCustomer.phone;
            txtEmail.Text = currentCustomer.email;
            cbTipoCliente.Text = currentCustomer.kindOfCustomer;
        }

        private void BtnSaveClient_Click(object sender, EventArgs e)
        {
            if (!filledValues())
            {

            }
            else
            {
                serviceDA = new DBControllerWSClient();
                //currentCustomer.idCustomer = int.Parse(txtClienteID.Text);
                currentCustomer.id = txtClienteID.Text;
                currentCustomer.descriptionCustomer = txtDesc.Text;
                currentCustomer.address = txtAddress.Text;
                currentCustomer.occupation = txtOccupation.Text;
                currentCustomer.email = txtEmail.Text;
                currentCustomer.phone = txtPhone.Text;
                currentCustomer.kindOfCustomer = cbTipoCliente.Text;
                currentCustomer.state = cbActive.Checked ? 1 : 0;

                serviceDA.updateCustomer(currentCustomer);
                MessageBox.Show("El cliente se modificó satisfactoriamente");
                this.Close();
            }
        }
        private bool filledValues()
        {
            if (txtClienteID.Text == "")
            {
                MessageBox.Show("Ingrese el DNI/RUC del cliente");
                return false;
            }
            if (cbTipoCliente.Text == "")
            {
                MessageBox.Show("Seleccione el tipo de cliente");
                return false;
            }
            if (cbTipoCliente.Text == "Natural" && txtClienteID.Text.Length != 8)
            {

                MessageBox.Show("Ingrese un DNI valido de 8 dígitos númericos");
                return false;
            }
            if (cbTipoCliente.Text == "Jurídica" && txtClienteID.Text.Length != 11)
            {

                MessageBox.Show("Ingrese un DNI valido de 11 dígitos númericos");
                return false;
            }

            if (cbTipoCliente.Text == "Natural" && txtClienteID.Text.Length == 8)
            {
                int result = 0;
                if (!int.TryParse(txtClienteID.Text, out result))
                {
                    MessageBox.Show("Ha ingresado caracteres no númericos en el campo DNI, ingrese 8 dígitos númericos ");
                    return false;
                }

            }
            if (cbTipoCliente.Text == "Jurídica" && txtClienteID.Text.Length == 11)
            {
                int result = 0;
                if (!int.TryParse(txtClienteID.Text, out result))
                {
                    MessageBox.Show("Ha ingresado caracteres no númericos en el campo RUC, ingrese 11 dígitos númericos ");
                    return false;
                }

            }
            
            if (txtDesc.Text == "")
            {
                MessageBox.Show("Ingrese la descripción del cliente");
                return false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Ingrese la dirección del cliente");
                return false;
            }
            if (txtOccupation.Text == "")
            {
                MessageBox.Show("Ingrese la ocupación del cliente");
                return false;
            }
            if (txtEmail.Text == "" || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo válido ");
                return false;
            }

            if (txtPhone.Text == "" || txtPhone.Text.Length < 3)
            {
                MessageBox.Show("Ingrese un teléfono válido (Mayor a 3 y menor a 15 digitos)");
                return false;
            }
            if (txtPhone.Text.Length >= 3)
            {
                int result = 0;
                if (!int.TryParse(txtPhone.Text, out result))
                {
                    MessageBox.Show("Ha ingresado caracteres no númericos en el campo del Telefono, ingrese de 3 a 15 dígitos ");
                    return false;
                }

            }
            return true;
        }
    }
}
