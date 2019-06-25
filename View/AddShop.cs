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
    public partial class Agregar_Local : Form
    {
        private DBControllerWSClient serviceDA;
        ShopForm refParent;
        public Agregar_Local()
        {
            InitializeComponent();
        }

        private void btnSaveLocal_Click(object sender, EventArgs e)
        {
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                premises l = new premises();

                //p.brand = brands[cboBrand.SelectedIndex];
                l.description = txtNombre.Text;
                //p.discount = discounts[cboDiscount.SelectedIndex];
                l.address = txtAddress.Text;
                //p.SKUcode = txtSKUCode.Text;
                //p.name = txtName.Text;
                //p.productDescription = txtDescription.Text;
                //p.productCareDescription = txtCareDescription.Text;
                l.state = 1;
                //p.salePrice = float.Parse(txtSalePrice.Text);
                //p.purchasePrice = float.Parse(txtPurchasePrice.Text);
                //p.igv = float.Parse(txtIGV.Text);
                //p.stock = int.Parse(txtStock.Text);

                serviceDA = new DBControllerWSClient();
                Cursor.Current = Cursors.WaitCursor;
                serviceDA.insertPremises(l);
                Cursor.Current = Cursors.Arrow;
                MessageBox.Show("El local se guardó satisfactoriamente");
                this.Close();

            }
            //MessageBox.Show("Se ha agregado un nuevo local satisfactoriamente");
            //this.Close();
        }
        private bool filledValues()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un código válido.");
                return false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del local");
                return false;
            }
            /*if (txtDesc.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del local");
                return false;
            }*/
            return true;
        }
        public void SetParent(ShopForm form)
        {
            refParent = form;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
