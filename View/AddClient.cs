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
            if(txtClienteID.Text == "")
            {
                MessageBox.Show("Complete el DNI o RUC del cliente");
                return false;
            }
            else if (txtDesc.Text == "")
            {
                MessageBox.Show("Complete la razón social o nombre del cliente");
                return false;
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Complete la dirección del cliente");
                return false;
            }
            else if (txtOccupation.Text == "")
            {
                MessageBox.Show("Complete la ocupación del cliente");
                return false;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Complete el correo del cliente");
                return false;
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Complete el teléfono del cliente");
                return false;
            }
            else if (cbTipoCliente.Text == "")
            {
                MessageBox.Show("Seleccione el tipo de cliente");
                return false;
            }
            return true;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
