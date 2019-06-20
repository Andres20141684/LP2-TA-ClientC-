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

namespace Producto
{
    public partial class UpdateProductForm : Form
    {
        private DBControllerWSClient serviceDA;
        private DBControllerWSClient serviceDAA;
        public product currentProduct;
        private BindingList<brand> brands;
        private BindingList<family> families;
        private BindingList<discount> discounts;

        public UpdateProductForm()
        {
            InitializeComponent();
        }

        private void UpdateProductForm_Shown(object sender, EventArgs e)
        {
            setProductInformation();
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            serviceDAA = new DBControllerWSClient();
            brands = new BindingList<brand>(serviceDAA.queryAllBrand());
            for (int i = 0; i < brands.Count; i++)
            {
                cboBrand.Items.Add("" + brands[i].name);
            }

            //cboBrand.DataSource = brands;
            families = new BindingList<family>(serviceDAA.queryAllFamily());
            for (int i = 0; i < families.Count; i++)
            {
                cboFamily.Items.Add("" + families[i].name);
            }

            discounts = new BindingList<discount>(serviceDAA.queryAllDiscount());
            for (int i = 0; i < discounts.Count; i++)
            {
                cboDiscount.Items.Add("" + discounts[i].description);
            }
        }

        private void setProductInformation()
        {
            txtSKUCode.Text = currentProduct.SKUcode;
            txtName.Text = currentProduct.name;
            txtDescription.Text = currentProduct.productDescription;
            cboBrand.Text = currentProduct.brand.name;
            cboFamily.Text = currentProduct.family.name;
            cboDiscount.Text = "--Seleccione--";
            //cboDiscount.Text = currentProduct.discount.description;
            txtCareDescription.Text = currentProduct.productCareDescription;
            txtSalePrice.Text = currentProduct.salePrice.ToString();
            txtPurchasePrice.Text = currentProduct.purchasePrice.ToString();
            txtIGV.Text = currentProduct.igv.ToString();
            txtStock.Text = currentProduct.stock.ToString();
            if (currentProduct.state == 1) cbActive.Checked = true;
            else cbActive.Checked = false;
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {         
            if (cboDiscount.Text == "--Seleccione--"){
                MessageBox.Show("Elija un descuento");
            }
            else
            {
                serviceDA = new DBControllerWSClient();
                currentProduct.SKUcode = txtSKUCode.Text;
                currentProduct.name = txtName.Text;
                currentProduct.productDescription = txtDescription.Text;
                currentProduct.brand = brands[cboBrand.SelectedIndex];
                currentProduct.family = families[cboFamily.SelectedIndex];
                currentProduct.discount = discounts[cboDiscount.SelectedIndex];
                currentProduct.productCareDescription = txtCareDescription.Text;
                currentProduct.salePrice = float.Parse(txtSalePrice.Text);
                currentProduct.purchasePrice = float.Parse(txtPurchasePrice.Text);
                currentProduct.igv = float.Parse(txtIGV.Text);
                currentProduct.stock = int.Parse(txtStock.Text);
                if (cbActive.Checked == true) currentProduct.state = 1;
                else currentProduct.state = 0;

                serviceDA.updateProduct(currentProduct);
                MessageBox.Show("El producto se modificó satisfactoriamente");
                this.Close();
            }
           
            
        }

        
    }
}
