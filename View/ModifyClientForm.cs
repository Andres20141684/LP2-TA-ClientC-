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
        public ModificarClienteForm()
        {
            InitializeComponent();
            cbActive.Checked = true;
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
            serviceDA = new DBControllerWSClient();
            //currentCustomer.idCustomer = int.Parse(txtClienteID.Text);
            currentCustomer.id = txtClienteID.Text;
            currentCustomer.descriptionCustomer = txtDesc.Text;
            currentCustomer.address = txtAddress.Text;
            currentCustomer.occupation = txtOccupation.Text;
            currentCustomer.email = txtEmail.Text;
            currentCustomer.phone = txtPhone.Text;
            currentCustomer.kindOfCustomer = cbTipoCliente.Text;
            currentCustomer.state = cbActive.Checked? 1: 0;
            
            serviceDA.updateCustomer(currentCustomer);
            MessageBox.Show("El cliente se modificó satisfactoriamente");
            this.Close();
        }
    }
}
