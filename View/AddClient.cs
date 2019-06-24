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
    public partial class AgregarClienteForm : Form
    {
        private DBControllerWSClient serviceDA;

        public AgregarClienteForm()
        {
            InitializeComponent();
            cbActive.Checked = true;
        }

        private void AgregarClienteForm_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                //getCustomerData
                customer c = new customer();
                c.id = txtClienteID.Text;
                c.descriptionCustomer = txtDesc.Text;
                c.address = txtAddress.Text;
                c.occupation = txtOccupation.Text;
                c.email = txtEmail.Text;
                c.phone = txtPhone.Text;
                c.kindOfCustomer = cbTipoCliente.Text;
                c.state = 1;
                serviceDA = new DBControllerWSClient();
                Cursor.Current = Cursors.WaitCursor;
                serviceDA.insertCustomer(c);
                Cursor.Current = Cursors.Arrow;
                MessageBox.Show("El cliente se agregó satisfactoriamente");
                this.Close();
            }
            
        }
        private bool filledValues()
        {
            
            if (cbTipoCliente.Text == "")
            {
                MessageBox.Show("Seleccione el tipo de cliente");
                return false;
            }

            else if (cbTipoCliente.Text == "Natural" && txtClienteID.Text.Length != 8 )
            {
                
                MessageBox.Show("Ingrese un DNI valido de 8 dígitos númericos");
                return false;
            }
            else if(cbTipoCliente.Text == "Natural" && txtClienteID.Text.Length == 8)
            {
                int result = 0;
                if (!int.TryParse(txtClienteID.Text, out result))
                {
                    MessageBox.Show("Ha ingresado caracteres no númericos en el campo DNI, ingrese 8 dígitos númericos ");
                    return false;
                }
                
            }

            else if (cbTipoCliente.Text == "Jurídica" && txtClienteID.Text.Length != 11)
            {
                MessageBox.Show("Ingrese un RUC valido de 11 dígitos númericos");
                return false;
            }
            else if (cbTipoCliente.Text == "Jurídica" && txtClienteID.Text.Length == 11)
            {
                int result = 0;
                if (!int.TryParse(txtClienteID.Text, out result))
                {
                    MessageBox.Show("Ha ingresado caracteres no númericos en el campo del RUC, ingrese 11 dígitos númericos ");
                    return false;
                }
                
            }
             if (txtDesc.Text == "" )
            {
                MessageBox.Show("Ingrese la razón social o nombre del cliente válida (Mayor a 0 y menor a 50 caracteres)");
                return false;
            }
             if (txtAddress.Text == "")
            {
                MessageBox.Show("Ingrese una dirección del cliente valida (Mayor a 0 y menor a 50 caracteres)");
                return false;
            }
             if (txtOccupation.Text == "" )
            {
                MessageBox.Show("Ingrese una ocupación del cliente valida (Mayor a 0 y menor a 50 caracteres)");
                return false;
            }
             if (txtEmail.Text == "" || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo válido ");
                return false;
            }

             if (txtPhone.Text == "" || txtPhone.Text.Length < 3 )
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtClienteID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
