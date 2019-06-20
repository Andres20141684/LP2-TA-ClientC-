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

namespace View
{
    public partial class UpdateShopForm : Form
    {
        private DBControllerWSClient serviceDA;
        private DBControllerWSClient serviceDAA;
        public premises currentPremise;
        //private BindingList<brand> brands;
        //private BindingList<family> families;
        //private BindingList<discount> discounts;

        public UpdateShopForm()
        {
            InitializeComponent();
        }
        private void UpdateProductForm_Shown(object sender, EventArgs e)
        {
            setShopInformation();
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            serviceDAA = new DBControllerWSClient();
            //brands = new BindingList<brand>(serviceDAA.queryAllBrand());
            //for (int i = 0; i < brands.Count; i++)
            //{
            //    cboBrand.Items.Add("" + brands[i].name);
            //}

            //cboBrand.DataSource = brands;
            //families = new BindingList<family>(serviceDAA.queryAllFamily());
            //for (int i = 0; i < families.Count; i++)
            //{
            //    cboFamily.Items.Add("" + families[i].name);
            //}

            //discounts = new BindingList<discount>(serviceDAA.queryAllDiscount());
            //for (int i = 0; i < discounts.Count; i++)
            //{
            //    cboDiscount.Items.Add("" + discounts[i].description);
            //}
        }

        private void setShopInformation()
        {
            txtPremiseID.Text = currentPremise.idPremises;
            txtName.Text = currentPremise.description;
            txtDescription.Text = currentPremise.address;
            //cboBrand.Text = currentProduct.brand.name;
            //cboFamily.Text = currentProduct.family.name;
            //cboDiscount.Text = "--Seleccione--";
            //cboDiscount.Text = currentProduct.discount.description;
            //txtCareDescription.Text = currentProduct.productCareDescription;
            //txtSalePrice.Text = currentProduct.salePrice.ToString();
            //txtPurchasePrice.Text = currentProduct.purchasePrice.ToString();
            //txtIGV.Text = currentProduct.igv.ToString();
            //txtStock.Text = currentProduct.stock.ToString();
            if (currentPremise.state == 1) cbActive.Checked = true;
            else cbActive.Checked = false;
        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void gbGeneralInformation_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateShopForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            serviceDA = new DBControllerWSClient();
            currentPremise.idPremises = txtPremiseID.Text;
            currentPremise.address = txtDescription.Text;
            currentPremise.description = txtName.Text;
            if (cbActive.Checked == true) currentPremise.state = 1;
            else currentPremise.state = 0;

            serviceDA.updatePremises(currentPremise);
            MessageBox.Show("El producto se modificó satisfactoriamente");
            this.Close();


        }
    }
}
