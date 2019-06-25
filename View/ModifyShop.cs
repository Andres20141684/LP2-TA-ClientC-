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
namespace ShopsForm
{
    public partial class Modificar_Local : Form
    {
        private DBControllerWSClient serviceDA;
        public premises currentLocal;
        ShopForm refParent;
        public Modificar_Local()
        {
            InitializeComponent();
        }
        public void SetParent(ShopForm form)
        {
            refParent = form;
        }

        private void setLocalInformation()
        {
            txtDesc.Text = currentLocal.description;
            txtDir.Text = currentLocal.address;
            if (currentLocal.state == 1) cbActive.Checked = true;
            else cbActive.Checked = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            serviceDA = new DBControllerWSClient();
            currentLocal.description = txtDesc.Text;
            currentLocal.address = txtDir.Text;
            if (cbActive.Checked == true) currentLocal.state = 1;
            else currentLocal.state = 0;

            serviceDA.updatePremises(currentLocal);
            MessageBox.Show("El local se modificó satisfactoriamente");
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modificar_Local_Shown_1(object sender, EventArgs e)
        {
            setLocalInformation();
        }
    }
}
